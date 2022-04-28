global using Microsoft.EntityFrameworkCore;
global using TheBetterLimited_Server.AppLogic.Data;

public class Program
{
    static void Main(String[] args)
    {

        //var filename = "test.html";
        //Console.Write(TheBetterLimited_Server.Helpers.File.DynamicHtml.GetFile( "test.html" , new string[] {"pw:sdf"}));
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers().AddNewtonsoftJson();
        builder.Services.AddDbContext<DataContext>(options =>
        {
            string ConnString = builder.Configuration.GetConnectionString("DefaultConnection");
            options.UseMySql(
                ConnString,
                ServerVersion.AutoDetect(ConnString)
            );
        });
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();
        app.MapControllers();

        Console.Title = "The Better Limited Server";
        app.Run();

        TheBetterLimited_Server.Helpers.File.TempFileManager.CloseAllTempFile();
    }

}