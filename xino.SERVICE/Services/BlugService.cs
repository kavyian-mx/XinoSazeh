

using Microsoft.EntityFrameworkCore;
using xino.DEL.ContextFile;
using xino.DEL.Entity;

namespace xino.SERVICE.Services;

public class BlugService(MyContext context)
{
    private readonly MyContext _context = context;

    public async Task<List<blug>> GetAllAsync()
    {
        return await _context.Blugs.Where(x=>x.IsDeleted==false)
            .OrderBy(x => x.BuildDate)
            .ToListAsync();
    }

    // بررسی وجود بلاگ با Id
    public async Task<bool> ExistsAsync(int id)
    {
        return await _context.Blugs.AnyAsync(x => x.Id == id);
    }

    // گرفتن یک بلاگ برای Admin با Id
    public async Task<blug?> GetByIdAsync(int id)
    {
        return await _context.Blugs
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    // گرفتن بلاگ با Slug
    public async Task<blug?> GetBySlugAsync(string slug)
    {
        return await _context.Blugs
            .FirstOrDefaultAsync(x => x.Slug == slug);
    }

    // بررسی وجود بلاگ با Slug
    public async Task<bool> ExistsBySlugAsync(string slug)
    {
        return await _context.Blugs.AnyAsync(x => x.Slug == slug);
    }


    public async Task<int> UpdateAsync(blug blug)
    {
        _context.Blugs.Update(blug);

         await _context.SaveChangesAsync();

        return blug.Id;

    }

    public async Task<int> AddAsync(blug blug)
    {
        await _context.AddAsync(blug);

        await _context.SaveChangesAsync();
        return blug.Id;
    }


    public async Task DeleteAsync(int id)
    {

        var item = await _context.Blugs.FindAsync(id);
        if (item == null)
            return;

        item.IsDeleted = true;
        await _context.SaveChangesAsync();

    }

}

