using OurFirstWebApi.Data;
using OurFirstWebApi.Data.Interfaces;
using OurFirstWebApi.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Access the IConfiguration object
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllers();

// Register DbContext
builder.Services.AddDbContext<SchoolDbContext>();

// Register IRepository to use SchoolRepository
builder.Services.AddScoped<IRepository, SchoolRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
