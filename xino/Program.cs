using ENDPOINTs.Models.mapping;
using Microsoft.EntityFrameworkCore;
using xino.DEL.ContextFile;

using xino.SERVICE.Service;
using xino.SERVICE.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddAutoMapper(typeof(Profilemap));

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ConsultationService>();
builder.Services.AddScoped<CurriculumVitaeService>();
builder.Services.AddScoped<AdminService>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Route برای Area
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);

// Route پیش‌فرض
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
