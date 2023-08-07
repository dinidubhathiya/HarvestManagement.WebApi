using System;
using Hectre.HarvestManagement.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Hectre.HarvestManagement.DataPersistence
{
	public class ApplicationDbContext: DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		public DbSet<Harvest> Harvests { get; set; }
        public DbSet<Orchard> Orchards { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }
    }
}

