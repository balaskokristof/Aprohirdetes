using Aprohirdetes.Properties;

namespace Aprohirdetes
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddRazorPages();

			builder.Services.AddDbContext<AprohirdetesContext>();

			var app = builder.Build();

			app.UseStaticFiles();

			app.MapRazorPages();

			app.UseRouting();

			app.Run();
		}
	}
}