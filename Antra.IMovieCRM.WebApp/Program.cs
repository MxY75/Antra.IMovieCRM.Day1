using IMovieCRM.Core.Contracts.Repository;
using IMovieCRM.Core.Contracts.Service;
using IMovieCRM.Infrastructure.Data;
using IMovieCRM.Infrastructure.Repository;
using IMovieCRM.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICastRepository, CastRepository>();
builder.Services.AddScoped<IMovieCastRepositoryAsync, MovieCastRepositoryAsync>();
builder.Services.AddScoped<IMovieGenreRepositoryAsync, MovieGenreRepositoryAsyn>();
builder.Services.AddScoped<IGenreRepositoryAsync,GenreRepositoryAsyn>();

builder.Services.AddScoped<ICastService, CastService>();
builder.Services.AddScoped<IMovieCastServiceAsync, MovieCastService>();
builder.Services.AddScoped<IMovieGenreService, MovieGenreService>();
builder.Services.AddScoped<IGenreService, GenreService>();

builder.Services.AddSqlServer<IMovieCrmDBContext>(builder.Configuration.GetConnectionString("IMovie"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
