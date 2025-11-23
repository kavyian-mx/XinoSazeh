

using Microsoft.EntityFrameworkCore;
using xino.DEL.ContextFile;
using xino.DEL.Entity;

namespace xino.SERVICE.Services;

public class InteriorDecorationService(MyContext context)
{
    private readonly MyContext _contex = context;

    public async Task<List<InteriorDecoration>> GetAllAsync()
    {


        return await _contex.InteriorDecorations.Where(x => x.IsDeleted == false).OrderByDescending(x => x.BuildDate).ToListAsync();
    }

    public async Task<List<InteriorDecoration>> SoftDeleted()
    {

        return await _contex.InteriorDecorations.Where(x => x.IsDeleted).OrderByDescending(x => x.BuildDate).ToListAsync();
    }

    public async Task<bool> ExitsAsync(int id)
    {

        return await _contex.InteriorDecorations.AnyAsync(x => x.Id == id);
    }

    public async Task<bool> ExitsBySlugAsync(string slug)
    {

        return await _contex.InteriorDecorations.AnyAsync(x => x.Slug == slug && !x.IsDeleted);
    }


    public async Task<InteriorDecoration?> GetByIdAsync(int id)
    {

        return await _contex.InteriorDecorations.Where(x =>x.Id==id).FirstOrDefaultAsync();

    }

    public async Task<InteriorDecoration?> GetBySlugAsync(string slug)
    {

        return await _contex.InteriorDecorations.Where(x => x.Slug == slug && !x.IsDeleted).FirstOrDefaultAsync();

    }


    public async Task<int> AddAsync(InteriorDecoration InteriorDecoration)
    {
        await _contex.InteriorDecorations.AddAsync(InteriorDecoration);

        await _contex.SaveChangesAsync();

        return InteriorDecoration.Id;


    }

    public async Task<int> UpdateAsync(InteriorDecoration interiorDecoration)
    {
        _contex.InteriorDecorations.Update(interiorDecoration);

        await _contex.SaveChangesAsync();

        return interiorDecoration.Id;

    }

    public async Task DeletedAsync(int id)
    {
        var iteam = await _contex.InteriorDecorations.FindAsync(id);

        if(iteam is null)
            return;


        iteam.IsDeleted = true;

        await _contex.SaveChangesAsync();
      

    }

}

