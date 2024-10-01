using Microsoft.EntityFrameworkCore;
using API_Rest_CP1_C4.Models;

namespace API_Rest_CP1_C4.Context
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
		public DbSet<Producto> Productos { get; set; }
	}
}
