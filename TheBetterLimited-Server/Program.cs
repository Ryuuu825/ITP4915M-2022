global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.Text;

using TheBetterLimited_Server.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Filters;

public class Program
{
    static void Main(String[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        // Add services to the container.
        builder.Services.AddControllers().AddNewtonsoftJson();
        builder.Services.AddDbContext<DataContext>(options =>
        {
            string ConnString = TheBetterLimited_Server.Helpers.SecretConf.Instance["ConnectionString"];
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
                            .GetBytes(TheBetterLimited_Server.Helpers.SecretConf.Instance["Token"])),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            options.AddSecurityDefinition("oauth2", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Description = "Auth using the bearer",
                In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                Name = "Authorization",
                Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey
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

        using (MySqlConnector.MySqlConnection conn = new MySqlConnector.MySqlConnection(connectionString: TheBetterLimited_Server.Helpers.SecretConf.Instance["ConnectionString"]))
        {
            try // test the connection with sql server
            {
                conn.Open();

            }
            catch (MySqlConnector.MySqlException e)
            {
                Console.WriteLine("Error ocurr during create a connection with MySQL server");
                Console.WriteLine(e.Message + " : " + conn.ConnectionTimeout + "s");
                return;
            }
            finally
            {
                conn.Close();
            }
        }


        app.Run();

        
        TheBetterLimited_Server.Helpers.File.TempFileManager.CloseAllTempFile();
    }

}