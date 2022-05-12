global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.Text;
global using TheBetterLimited_Server.Helpers.Extension;

using System.Globalization;
using CsvHelper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MySqlConnector;
using Swashbuckle.AspNetCore.Filters;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Helpers;
using TheBetterLimited_Server.Helpers.File;
using static TheBetterLimited_Server.Helpers.SecretConf;
using System.Data;

class Foo 
{
    public string Id {get; set;}
    public string Name {get; set;}
}
public class Program
{
    private static void Main(string[] args)
    {
        // using (var reader = new StreamReader("./resource/localization/test.csv"))
        // using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        // {
        //     var records = csv.GetRecords<Foo>();
        //     foreach (var record in records)
        //     {
        //         Console.WriteLine(record.Id);
        //         Console.WriteLine(record.Name);
        //     }
        // }
        var builder = WebApplication.CreateBuilder(args);
        // Add services to the container.
        builder.Services.AddControllers().AddNewtonsoftJson();
        builder.Services.AddDbContext<DataContext>(options =>
        {
            var ConnString = _Secret["ConnectionString"];
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
                        .GetBytes(_Secret["Token"])),
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

        using (var conn = new MySqlConnection(_Secret["ConnectionString"]))
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