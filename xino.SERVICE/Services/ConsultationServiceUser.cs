

using Microsoft.EntityFrameworkCore;
using xino.DEL.ContextFile;
using xino.DEL.Entity;


namespace xino.SERVICE.UserService;

   public class ConsultationServiceUser(MyContext context)
    {
    private readonly MyContext _context = context;

    public async Task Create(Consultation consultation)
    {
        _context.Consultations.Add(consultation);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Consultation>> ToListCheck()
    {
        return await _context.Consultations
            .Where(x => x.IsChacket == false)
            .OrderBy(x => x.BuildDate)
            .ToListAsync();
    }

    public async Task<List<Consultation>> ToNotCheck()
    {
        return await _context.Consultations
            .Where(x => x.IsChacket == true)
            .OrderByDescending(x => x.BuildDate)
            .ToListAsync();
    }

    public async Task Check(int id)
    {
        var item = await _context.Consultations.FindAsync(id);

        if (item == null)
            return;

        item.IsChacket = true;
        await _context.SaveChangesAsync();
    }

}

