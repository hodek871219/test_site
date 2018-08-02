using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;
using Navistar.Model.common;

namespace Navistar.DataContext
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public partial class DBDataMartEntityFmwImp : DbContext 
    {
        
        public DbSet<TCP001_PEDIDO> TCP001_PEDIDO { get; set; }

        
        public DBDataMartEntityFmwImp(DbContextOptions<DBDataMartEntityFmwImp> options) : base(options)
        {
          
          
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
   
            // ignore a property that is not mapped to a database column
            modelBuilder.Entity<TCP001_PEDIDO>()
                .Ignore(p => p.Id);
            modelBuilder.Entity<TCP001_PEDIDO>().HasKey(x => x.CD_PEDIDO);
 
        }

    }
}
