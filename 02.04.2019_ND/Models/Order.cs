using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._04._2019_ND.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
    public class OrderConfiguration:EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasKey(p => p.ID);
            HasMany(p => p.OrderDetails).WithRequired().HasForeignKey(p => p.OrderID);
        }

    }
}
