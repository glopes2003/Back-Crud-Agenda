using Agenda.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Data
{
    public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		public DbSet<AgendaCrud> Agenda { get; set; }
	}
}

