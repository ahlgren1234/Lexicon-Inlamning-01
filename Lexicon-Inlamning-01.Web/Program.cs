using Lexicon_Inlamning_01.Web.Services;

namespace Lexicon_Inlamning_01.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IRunningShoeService, RunningShoeService>();
            var app = builder.Build();
            app.MapControllers();
            
            app.Run();
        }
    }
}
