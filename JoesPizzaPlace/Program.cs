using JoesPizzaPlace.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPizzaRepository, MockPizzaRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
 
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
