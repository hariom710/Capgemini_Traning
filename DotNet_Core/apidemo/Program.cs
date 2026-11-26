using Microsoft.EntityFrameworkCore;
using apidemo.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddControllers();
//builder.Services.AddDbContext<AprdbContext>(options =>options.UseSqlServer("server=HARRY-DEVRIG\\SQLEXPRESS;database=aprdb;trusted_connection=true;encrypt=false"));
builder.Services.AddDbContext<AprdbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Aprdb")));
builder.Services.AddScoped<IDept, DeptRepo>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("MyPolicy");
app.MapControllers();

app.Run();

