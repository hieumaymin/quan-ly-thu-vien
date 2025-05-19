using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyLibraryDemo.Data;
using MyLibraryDemo.Data.Models;
using System.Linq;
using System.Threading.Tasks;

public class BookController : Controller
{
    private readonly LibraryDbContext _context;

    public BookController(LibraryDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index() => View(await _context.Books.ToListAsync());
    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Title,Author,PublicationYear,Description")] Book book)
    {
        if (ModelState.IsValid)
        {
            _context.Add(book);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Thêm sách mới thành công!";
            return RedirectToAction(nameof(Index));
        }
        return View(book);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();
        var book = await _context.Books.FindAsync(id);
        if (book == null) return NotFound();
        return View(book);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Author,PublicationYear,Description")] Book book)
    {
        if (id != book.Id) return NotFound();
        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(book);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Cập nhật sách thành công!";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(book.Id)) return NotFound();
                else throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(book);
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return NotFound();
        var book = await _context.Books.FirstOrDefaultAsync(m => m.Id == id);
        if (book == null) return NotFound();
        return View(book);
        
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null) return NotFound();

        // Kiểm tra xem sách có đang được mượn không
        var hasActiveLoans = await _context.Loans
            .AnyAsync(l => l.BookId == id && !l.ReturnDate.HasValue);

        if (hasActiveLoans)
        {
            TempData["Error"] = "Không thể xóa sách này vì đang có người mượn.";
            return RedirectToAction(nameof(Index));
        }

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();
        TempData["Success"] = "Xóa sách thành công!";
        return RedirectToAction(nameof(Index));
    }

    private bool BookExists(int id) => _context.Books.Any(e => e.Id == id);

    public async Task<IActionResult> Search(string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm)) return View("Index", await _context.Books.ToListAsync());
        var results = await _context.Books
            .Where(b => b.Title.Contains(searchTerm) ||
                        b.Author.Contains(searchTerm) ||
                        b.PublicationYear.ToString().Contains(searchTerm))
            .ToListAsync();
        return View("Index", results);
    }
}