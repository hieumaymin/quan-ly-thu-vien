using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyLibraryDemo.Data;
using MyLibraryDemo.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

public class LoanController : Controller
{
    private readonly LibraryDbContext _context;

    public LoanController(LibraryDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var libraryDbContext = _context.Loans.Include(l => l.Book).Include(l => l.Reader);
        return View(await libraryDbContext.ToListAsync());
    }

    public IActionResult Create()
    {
        PrepareViewBagForCreate();
        return View(new Loan { LoanDate = DateTime.Today });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("BookId,ReaderId,LoanDate")] Loan loan)
    {
        if (!ModelState.IsValid)
        {
            PrepareViewBagForCreate();
            return View(loan);
        }

        try
        {

            
            if (loan.LoanDate == default)
            {
                loan.LoanDate = DateTime.Now;
            }

            _context.Add(loan);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Tạo phiếu mượn thành công!";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", "Có lỗi xảy ra khi tạo phiếu mượn. Vui lòng thử lại.");
            // Log the exception
            Console.WriteLine(ex);
            PrepareViewBagForCreate();
            return View(loan);
        }
    }

    private void PrepareViewBagForCreate()
    {
        var books = _context.Books.Select(b => new { b.Id, DisplayText = $"{b.Title} - {b.Author}" });
        ViewBag.BookId = new SelectList(books, "Id", "DisplayText");
        ViewBag.ReaderId = new SelectList(_context.Readers, "Id", "Name");
    }

    public async Task<IActionResult> Return(int? id)
    {
        if (id == null) return NotFound();
        var loan = await _context.Loans
            .Include(l => l.Book)
            .Include(l => l.Reader)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (loan == null) return NotFound();
        return View(loan);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ReturnConfirmed(int id)
    {
        var loan = await _context.Loans.FindAsync(id);
        if (loan == null) return NotFound();
        loan.ReturnDate = DateTime.Now;
        _context.Update(loan);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Search(string bookTitle, string readerName, string status)
    {
        IQueryable<Loan> query = _context.Loans.Include(l => l.Book).Include(l => l.Reader);

        if (!string.IsNullOrWhiteSpace(bookTitle))
        {
            bookTitle = bookTitle.ToLower();
            query = query.Where(l => l.Book != null && l.Book.Title.ToLower().Contains(bookTitle));
        }

        if (!string.IsNullOrWhiteSpace(readerName))
        {
            readerName = readerName.ToLower();
            query = query.Where(l => l.Reader != null && l.Reader.Name.ToLower().Contains(readerName));
        }

        if (!string.IsNullOrWhiteSpace(status))
        {
            status = status.ToLower();
            if (status == "đã trả")
            {
                query = query.Where(l => l.ReturnDate.HasValue);
            }
            else if (status == "chưa trả")
            {
                query = query.Where(l => !l.ReturnDate.HasValue);
            }
        }

        return View("Index", await query.ToListAsync());
    }
}