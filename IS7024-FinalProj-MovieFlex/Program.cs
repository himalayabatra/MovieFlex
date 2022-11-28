using Newtonsoft.Json;
using IS7024_FinalProj_MovieFlex.Pages;
using Movie;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/movieFlex/top250movies",() =>
{
    Top250MoviesModel top250Movies = new Top250MoviesModel();
    MovieList movies = new MovieList();
        //movies = top250Movies.httpCall();
    return movies;
})
.WithName("api");

app.Run();
