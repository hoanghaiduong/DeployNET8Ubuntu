
namespace DeployNET8Ubuntu;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

  
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
      
        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseSwagger();
        app.UseSwaggerUI();

  
        app.UseAuthorization();

        app.MapGet("/",()=>{
            return "Hello World,  Đây là CI/CD WITH GITHUB ACTIONS SELF HOSTED RUNNER";
        });
      
        

        app.Run();
    }
}
