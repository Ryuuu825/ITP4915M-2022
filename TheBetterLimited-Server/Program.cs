global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.Text;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MySqlConnector;
using Swashbuckle.AspNetCore.Filters;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Helpers;
using TheBetterLimited_Server.Helpers.File;
using TheBetterLimited_Server.Helpers.Entity;
using TheBetterLimited_Server.Helpers.Secure;
using Microsoft.AspNetCore.ResponseCompression;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        // Add services to the container.
        builder.Services.AddControllers().AddNewtonsoftJson();
        builder.Services.AddDbContext<DataContext>(options =>
        {
            var ConnString = SecretConf.Instance["ConnectionString"];
            options.UseMySql(
                ConnString,
                ServerVersion.AutoDetect(ConnString)
            );
        });
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                        .GetBytes(SecretConf.Instance["Token"])),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });


        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
            {
                Description = "Auth using the bearer",
                In = ParameterLocation.Header,
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey
            });
            options.OperationFilter<SecurityRequirementsOperationFilter>();
        });


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
        Console.Title = "The Better Limited Server";

        using (var conn = new MySqlConnection(SecretConf.Instance["ConnectionString"]))
        {
            try // test the connection with sql server
            {
                conn.Open();
            }
            catch (MySqlException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Timeout: {conn.ConnectionTimeout}s\nError occur during create a connection with MySQL server");
                Console.WriteLine("Please make sure the connection string is right or Start the MySQL server");
                return;
            }
            finally
            {
                conn.Close();
                Console.ResetColor();
            }
        }


        app.Run();

        TempFileManager.CloseAllTempFile();
    }
}