var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Contexts

// Identity

// Repositories

// Services

var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
