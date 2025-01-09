using ECommerceAPI.Application.Validators.Products;
using ECommerceAPI.Infrastructure;
using ECommerceAPI.Infrastructure.Filters;
using ECommerceAPI.Infrastructure.Services.Storage.Local;
using ECommerceAPI.Persistence;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();

builder.Services.AddStorage<LocalStorage>();

//Add cors policy for connection client with server. With this policy any user access our API.
//!! But if we filter with localhost:4200(our access canal) we only access with this canal.  
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
//policy
//.AllowAnyHeader()
//.AllowAnyMethod()
//.AllowAnyOrigin()
policy
.WithOrigins("http://localhost:4200", "https://localhost:4200")
.AllowAnyHeader()
.AllowAnyMethod()
));


builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
                .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>
                ())
                .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();   

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
