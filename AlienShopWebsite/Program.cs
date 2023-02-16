using AlienShopWebsite.Services;
using Microsoft.EntityFrameworkCore;
using AlienShopWebsite.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DBContext>(options => options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));
builder.Services.AddTransient<IalienRepo, AlienRepo>();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");
});


using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<DBContext>();
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();
}
/* added*/
app.Run();


