using AlienShopWebsite.Services;
using Microsoft.EntityFrameworkCore;
using AlienShopWebsite.Repositories;
using AlienShopWebsite.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<Irepository, Repository>();
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


