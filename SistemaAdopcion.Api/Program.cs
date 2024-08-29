using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using SistemaAdopcion.Api.Data;
using SistemaAdopcion.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(jwtOptions => jwtOptions.TokenValidationParameters = TokenService.GetTokenValidationParameters(builder.Configuration));


var connectionString = builder.Configuration.GetConnectionString("Pet");
builder.Services.AddDbContext<PetContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Transient);

builder.Services.AddTransient<IAuthService, AuthService>()
                .AddTransient<TokenService>()
                .AddTransient<IPetService, PetService>()
                .AddTransient<IUserPetService, UserPetService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    ApplyDbMigrations(app.Services);
    app.UseSwagger();
    app.UseSwaggerUI();
}

//si deseo ver imgenes con url estatica
//app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
//https://localhost:7126/swagger/index.html

//app.Run();
app.Run("https://localhost:7126");

static void ApplyDbMigrations(IServiceProvider serviceProvider)
{
    using var scope = serviceProvider.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<PetContext>();
    if (dbContext.Database.GetPendingMigrations().Any())
        dbContext.Database.Migrate();
}