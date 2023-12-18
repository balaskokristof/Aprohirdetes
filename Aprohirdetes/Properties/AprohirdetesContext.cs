using Microsoft.EntityFrameworkCore;

namespace Aprohirdetes.Properties
{
	public class AprohirdetesContext : DbContext
	{
		public string connStr="server=localhost;database=aprohirdetes;user=root;password=;";
		public DbSet<Aprohird> Aprohirdetesek { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql(connStr, ServerVersion.AutoDetect(connStr));
		}
	}
}
