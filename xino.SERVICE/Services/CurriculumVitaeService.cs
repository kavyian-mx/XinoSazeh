

using Microsoft.EntityFrameworkCore;
using xino.DEL.ContextFile;
using xino.DEL.Entity;

namespace xino.SERVICE.UserService;

   public class CurriculumVitaeService(MyContext context)
    {
    private readonly MyContext _context = context;

    public async Task Create(CurriculumVitae curriculumVitae)
    {


        _context.CurriculumVitaes.Add(curriculumVitae);
        await _context.SaveChangesAsync();
    }

    public async Task<List<CurriculumVitae>> ToListCheck()
    {
        return await _context.CurriculumVitaes.Where(x => x.IsChacket == false).OrderBy(x => x.BuildDate).ToListAsync();


    }
        public async Task<List<CurriculumVitae>> ToNotCheck()
    {


        return await _context.CurriculumVitaes.Where(x=>x.IsChacket==true).OrderBy(x => x.BuildDate).ToListAsync();
    }


    public async Task IsCheck(int id)
    {
        var item = await _context.CurriculumVitaes.FindAsync(id);

        if (item == null)
            return;

        item.IsChacket = true;

        await _context.SaveChangesAsync();
    }

    }

