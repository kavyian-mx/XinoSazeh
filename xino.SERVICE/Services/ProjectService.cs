

using Microsoft.EntityFrameworkCore;
using xino.DEL.ContextFile;
using xino.DEL.Entity;

namespace xino.SERVICE.Services;

public class ProjectService(MyContext context)
{
    private readonly MyContext _context = context;

    public async Task<List<Project>> GetAllAsync()
    {

        return await _context.Projects.Where(x => !x.IsDeleted).OrderByDescending(x => x.BuildDate).ToListAsync();
    }

    public async Task<List<Project>> SoftDeleted()
    {

        return await _context.Projects.Where(x => x.IsDeleted).OrderByDescending(x => x.BuildDate).ToListAsync();
    }

    public async Task<bool> ExitsAsync(int id)
    {

        return await _context.Projects.AnyAsync(x => x.Id == id);
    }

    public async Task<bool> ExitsBySlugAsync(string slug)
    {

        return await _context.Projects.AnyAsync(x => x.Slug == slug && !x.IsDeleted);
    }

    public async Task<Project?> GetByIdAsync(int id)
    {
        return await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);

    }

    public async Task<Project?> GetBySlugAsync(string slug)
    {


        return await _context.Projects.FirstOrDefaultAsync(x => x.Slug == slug);
    }


    public async Task<int> UpdateAsync(Project project)
    {
        _context.Projects.Update(project);

        await _context.SaveChangesAsync();

        return project.Id;

    }


    public async Task<int> AddAsync(Project project)
    {

        await _context.Projects.AddAsync(project);

        await _context.SaveChangesAsync();
        return project.Id;
    }

    public async Task DeletedAsync(int id)
    {
        var iteam = await _context.Projects.FindAsync(id);

        if (iteam is null)

            return;

        iteam.IsDeleted = true;

        await _context.SaveChangesAsync();

        

    }

}

