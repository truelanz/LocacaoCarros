using AutoMapper;
using LocadoraDeCarros.Middlewares;
using Microsoft.Extensions.DependencyInjection;
using Negocio.Repositorio;
using Negocio.RepositorioDados;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IClienteRepositorio, ClienteRepositorio>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Custom middleware (com parâmetro)
app.UseMiddleware<FriendListMiddleware>(
    builder.Configuration["SafeList"]
);

app.UseAuthorization();

// Rotas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
