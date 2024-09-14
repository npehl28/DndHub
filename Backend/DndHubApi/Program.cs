using DndHubApi.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add your DbContext and configure it to use SQLite instead of SQL Server
//Connection String is in appsetting.json
builder.Services.AddDbContext<RaceDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RaceConnection"))
);

builder.Services.AddDbContext<CharacterDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CharacterConnection"))
);

builder.Services.AddScoped<IDbSeeder, DbSeeder>(); // Replace DbSeeder with your actual implementation class

// Enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAllOrigins",
        policyBuilder =>
        {
            policyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        }
    );
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

// Flag to control whether seeding should run
bool shouldSeedDatabase = true;

if (shouldSeedDatabase)
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;

        try
        {
            Console.WriteLine(
                "Getting Required Service \"services.GetRequiredService<RaceDbContext>()\""
            );
            var context = services.GetRequiredService<RaceDbContext>();

            Console.WriteLine("Applying any pending database migrations.");

            context.Database.Migrate(); // Applies any pending migrations

            Console.WriteLine(
                "Getting Required Service \"services.GetRequiredService<IDbSeeder>()\""
            );
            var seeder = services.GetRequiredService<IDbSeeder>();
            seeder.AsyncSeedDatabase().Wait(); // Run your seeding logic
        }
        catch (Exception ex)
        {
            // Handle exceptions (e.g., logging)
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "An error occurred while seeding the database.");
        }
    }
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
