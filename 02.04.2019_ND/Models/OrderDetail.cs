using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._04._2019_ND.Models
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
    public class OrderDetailConfiguration : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailConfiguration()
        {
            HasKey(p => new
            {
                p.OrderID,
                p.ProductID
            });
            Property(p => p.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(p => p.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(p => p.UnitPrice).HasColumnType("money");
        }

    }
}
