using Microsoft.EntityFrameworkCore;
using RecipeAPI.Core.Interfaces;
using RecipeAPI.Core.Services;
using RecipeAPI.Data;
using RecipeAPI.Data.Interfaces;
using RecipeAPI.Data.Repos;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper (AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IRecipeRepo, RecipeRepo>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<IRatingRepo, RatingRepo>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepo, UserRepo>();


var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();
app.UseRouting();
app.UseEndpoints(endpoints => {endpoints.MapControllers();});
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
