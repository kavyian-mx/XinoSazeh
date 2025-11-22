

using Microsoft.EntityFrameworkCore;
using xino.DEL.ContextFile;
using xino.DEL.Entity;

namespace xino.SERVICE.Service;

   public class CurriculumVitaeService(MyContext context)
    {
    private readonly MyContext _context = context;

    public async Task AddAsync(CurriculumVitae curriculumVitae)
    {


        _context.CurriculumVitaes.Add(curriculumVitae);
        await _context.SaveChangesAsync();
    }

    public async Task<List<CurriculumVitae>> GetUncheckedAsync()
    {
        return await _context.CurriculumVitaes.Where(x => x.IsChacket == false).OrderBy(x => x.BuildDate).ToListAsync();


    }
        public async Task<List<CurriculumVitae>> GetCheckedAsync()
    {


        return await _context.CurriculumVitaes.Where(x=>x.IsChacket==true).OrderBy(x => x.BuildDate).ToListAsync();
    }


    public async Task MarkAsCheckedAsync(int id)
    {
        var item = await _context.CurriculumVitaes.FindAsync(id);

        if (item == null)
            return;

        item.IsChacket = true;

        await _context.SaveChangesAsync();
    }

    }

