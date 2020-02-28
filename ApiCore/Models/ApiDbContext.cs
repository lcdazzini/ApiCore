using Microsoft.EntityFrameworkCore;

namespace ApiCore.Models
{
	public class ApiDbContext : DbContext
	{
		public ApiDbContext(DbContextOptions options) : base(options){ }
	}
}
