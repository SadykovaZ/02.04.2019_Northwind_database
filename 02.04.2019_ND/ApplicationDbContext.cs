using _02._04._2019_ND.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._04._2019_ND
{
    public class ApplicationDbContext:DbContext
    {
        static readonly string connection= ConfigurationManager.ConnectionStrings["NorthwindDB2"].ConnectionString;
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        public ApplicationDbContext():base(connection)
        {

        }

    }
}
