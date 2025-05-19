using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyLibraryDemo.Data;
using MyLibraryDemo.Data.Models;
using System.Linq;
using System.Threading.Tasks;

public class ReaderController : Controller
{
    private readonly LibraryDbContext _context;

    public ReaderController(LibraryDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index() => View(await _context.Readers.ToListAsync());
    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Name,Email,PhoneNumber")] Reader reader)
    {
        if (ModelState.IsValid)
        {
            _context.Add(reader);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Thêm độc giả mới thành công!";
            return RedirectToAction(nameof(Index));
        }
        return View(reader);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();
        var reader = await _context.Readers.FindAsync(id);
        if (reader == null) return NotFound();
        return View(reader);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,PhoneNumber")] Reader reader)
    {
        if (id != reader.Id) return NotFound();
        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(reader);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Cập nhật độc giả thành công!";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReaderExists(reader.Id)) return NotFound();
                else throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(reader);
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return NotFound();
        var reader = await _context.Readers.FirstOrDefaultAsync(m => m.Id == id);
        if (reader == null) return NotFound();
        return View(reader);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var reader = await _context.Readers.FindAsync(id);
        if (reader == null) return NotFound();

        // Kiểm tra xem độc giả có đang mượn sách không
        var hasActiveLoans = await _context.Loans
            .AnyAsync(l => l.ReaderId == id && !l.ReturnDate.HasValue);

        if (hasActiveLoans)
        {
            TempData["Error"] = "Không thể xóa độc giả này vì đang có sách chưa trả.";
            return RedirectToAction(nameof(Index));
        }

        _context.Readers.Remove(reader);
        await _context.SaveChangesAsync();
        TempData["Success"] = "Xóa độc giả thành công!";
        return RedirectToAction(nameof(Index));
    }

    private bool ReaderExists(int id) => _context.Readers.Any(e => e.Id == id);

    public async Task<IActionResult> Search(string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm)) return View("Index", await _context.Readers.ToListAsync());
        var results = await _context.Readers
            .Where(r => r.Name.Contains(searchTerm) ||
                        r.Email.Contains(searchTerm) ||
                        r.PhoneNumber.Contains(searchTerm))
            .ToListAsync();
        return View("Index", results);
    }
}