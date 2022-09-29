using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// добавляем сервисы
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=HomeController}/{action=Index}/{id?}"); // Home и Index явл дефолтными настройками если ниго нету (напр. sitr.com/)
});
//app.UseAuthorization();

app.MapRazorPages();

app.Run();
