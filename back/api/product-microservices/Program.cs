using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddControllers();

builder.Services.AddDbContext<ProductDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("postgresConnection"))
);

var app = builder.Build();

using (var serviceScope = app.Services.CreateScope())
{
    var dbContext = serviceScope.ServiceProvider.GetRequiredService<ProductDbContext>();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();
    app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
