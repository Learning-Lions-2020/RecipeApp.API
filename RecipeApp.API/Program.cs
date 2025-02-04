using Microsoft.EntityFrameworkCore;
using RecipeApp.API.DbContexts;
using RecipeApp.API.Models;
using RecipeApp.API.Services;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/recipelogs.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();


var builder = WebApplication.CreateBuilder(args);

//Replacing the default logger with Serilog
builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddDbContext<RecipeDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson()
  .AddXmlDataContractSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Registering RecipeDataStore as a singleton
builder.Services.AddSingleton<RecipeDataStore>();


// Register mail services conditionally based on environment
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddScoped<IMailService, LocalMailService>();
}
else
{
    builder.Services.AddScoped<IMailService, CloudMailService>();
}

var app = builder.Build();

// Configure the HTTP request pipeline.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();

}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
