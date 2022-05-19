using AObaidiP5.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AObaidiP5.Server
{
    public class SnowBoardDbContext:DbContext
    {
        public SnowBoardDbContext(DbContextOptions<SnowBoardDbContext> options)
            : base(options) { 
                            }
        public DbSet<SnowBoard> SnowBoardstb { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var boardEntity = modelBuilder.Entity<SnowBoard>();
            boardEntity.HasKey(SnowBoard => SnowBoard.OrderId);
        }
    }
}
