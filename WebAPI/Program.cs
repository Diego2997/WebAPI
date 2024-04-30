using Microsoft.AspNetCore.Identity;
using WebAPI.Application;
using WebAPI.Application.interfaces;
using WebAPI.Infrastructure.Reports;
using WebAPI.Persistence;
using WebAPI.Persistence.Models;
using WebAPI.WebAPI.Extensions;
using WebAPI.WebAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAplication();
builder.Services.AddPersistence(builder.Configuration);
//builder.Services.AddScoped<IReportService, ReportService>();
//se haria de esta forma si no se estuviera utilizando genericos

builder.Services.AddScoped(typeof(IReportService<>), typeof(ReportService<>));
//hay que agregar la referencia de infra hacia api

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddIdentityCore<AppUser>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.User.RequireUniqueEmail = true;

}).AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
//builder.Services.AddMediatR(configuration =>
//{
//    configuration.RegisterServicesFromAssemblies(typeof(Program).Assembly);
//}); //Comentado porque ahora lo hace dependecy injection

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
await app.SeedDataAuthentication();
app.MapControllers();

app.Run();

