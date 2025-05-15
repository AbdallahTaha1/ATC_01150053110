using EMS.Application;
using EMS.Infrastructure;
using EMS.Infrastructure.Seeder;
using EMS.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddSwaggerService();

    builder.Services.AddApplicationServices()
                    .AddInfrastructure(builder.Configuration);

    // Allow CORS
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAngular",
            policy =>
            {
                policy.WithOrigins("http://localhost:4200")
                      .AllowAnyHeader()
                      .AllowAnyMethod();
            });
    });
}

var app = builder.Build();
{
    using (var scope = app.Services.CreateScope())
    {
        var serviceProvider = scope.ServiceProvider;

        await RoleSeeder.SeedAsync(serviceProvider);
        await UserSeeder.SeedAsync(serviceProvider);
        await CategorySeedeer.SeedAsync(serviceProvider);
        await EventSeeder.SeedAsync(serviceProvider);
    }

    app.UseDefaultFiles();
    app.UseStaticFiles();

    if (app.Environment.IsDevelopment())
        app.UseSwagger()
           .UseSwaggerUI();

    app.UseCors("AllowAngular");


    app.UseHttpsRedirection();

    app.UseAuthentication();

    app.UseAuthorization();

    app.MapControllers();

    app.MapFallbackToFile("/index.html");

    app.Run();
}