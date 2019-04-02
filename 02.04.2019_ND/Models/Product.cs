using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._04._2019_ND.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Productname { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short RecorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.ID);
            HasMany(p => p.OrderDetails).WithRequired().HasForeignKey(p => p.ProductID);
            Property(p => p.UnitPrice).HasColumnType("money");
        }
    }
}
