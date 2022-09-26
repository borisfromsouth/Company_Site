var builder = WebApplication.CreateBuilder(args);

// добавляем сервисы
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints => 
{ 
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/");
}): 
//app.UseAuthorization();

app.MapRazorPages();

app.Run();
