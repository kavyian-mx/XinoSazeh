using Microsoft.EntityFrameworkCore;
using xino.DEL.ContextFile;
using xino.DEL.Entity;

namespace xino.SERVICE.Services;

public class BlugService(MyContext context)
{
    private readonly MyContext _context = context;

    public async Task<List<blug>> SoftDeleted()
    {


        return await _context.Blugs.Where(x => x.IsDeleted).OrderByDescending(x => x.BuildDate).ToListAsync();
    }

    public Task<List<blug>> GetAllAsync()
    {
        return _context.Blugs
            .Where(x => !x.IsDeleted)
            .OrderByDescending(x => x.BuildDate)
            .ToListAsync();
    }

    public Task<bool> ExistsAsync(int id)
    {
        return _context.Blugs.AnyAsync(x => x.Id == id);
    }

    public Task<blug?> GetByIdAsync(int id)
    {
        return _context.Blugs
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task<blug?> GetBySlugAsync(string slug)
    {
        return _context.Blugs
            .FirstOrDefaultAsync(x => x.Slug == slug && !x.IsDeleted);
    }

    public Task<bool> ExistsBySlugAsync(string slug)
    {
        return _context.Blugs.AnyAsync(x => x.Slug == slug && !x.IsDeleted);
    }

    public async Task<int> AddAsync(blug blug)
    {
        await _context.Blugs.AddAsync(blug);
        await _context.SaveChangesAsync();
        return blug.Id;
    }

    public async Task<int> UpdateAsync(blug blug)
    {
        _context.Blugs.Update(blug);
        await _context.SaveChangesAsync();
        return blug.Id;
    }

    public async Task DeleteAsync(int id)
    {
        var item = await _context.Blugs.FindAsync(id);
        if (item is null)
            return;

        item.IsDeleted = true;
        await _context.SaveChangesAsync();
    }
}
