using Microsoft.AspNetCore.Identity;
using WebAPI.Application;
using WebAPI.Persistence;
using WebAPI.Persistence.Models;
using WebAPI.WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAplication();
builder.Services.AddPersistence(builder.Configuration);

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
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
await app.SeedDataAuthentication();
app.MapControllers();

app.Run();

