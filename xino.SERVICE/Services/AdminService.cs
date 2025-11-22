

using Microsoft.EntityFrameworkCore;
using xino.DEL.ContextFile;
using xino.DEL.Entity;

namespace xino.SERVICE.Services;

  public  class AdminService(MyContext context)
   {
        private readonly MyContext _context = context;

    public async Task<int> AddAsync(Admin admin)
    {
        await _context.Admins.AddAsync(admin);

        await _context.SaveChangesAsync();

        return admin.Id;


    }

    public async Task<int> UpdateAysnc(Admin admin)
    {
        _context.Admins.Update(admin);

        await _context.SaveChangesAsync();

        return admin.Id;



    }

    public async Task<List<Admin>> AdminsListAsync()
    {
        return await _context.Admins.OrderBy(x => x.Id).ToListAsync();

    }


    public async Task<bool> DeleteAsync(int id)
    {
        var item = await _context.Admins.FindAsync(id);
        if (item == null)
            return false;

        _context.Admins.Remove(item);
        await _context.SaveChangesAsync();
        return true;
    }



}

