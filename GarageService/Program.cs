using CustomerService.Data;
using GarageService.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using CustomerService.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( c => {
                                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                                c.IgnoreObsoleteActions();
                                c.IgnoreObsoleteProperties();
                                c.CustomSchemaIds(type => type.FullName);
                                    });
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("InMem"));
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

