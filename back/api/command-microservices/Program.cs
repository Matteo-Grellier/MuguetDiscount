using Microsoft.EntityFrameworkCore;
using command_microservices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CommandDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("postgresConnection"))
    // x=>x.MigrationsHistoryTable("_EfMigrations", Configuration.GetSection("Schema").GetSection("<YourDataSchema>").Value)));
);

var app = builder.Build();

using (var serviceScope = app.Services.CreateScope())
{
    var dbContext = serviceScope.ServiceProvider.GetRequiredService<CommandDbContext>();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
