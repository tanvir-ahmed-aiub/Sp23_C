using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFCodeFirst.EF.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public int Amount { get; set; }
        [ForeignKey("OrderedBy")]
        public string OrderedById { get; set; }
        public virtual User OrderedBy { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public Order() {
            OrderDetails = new List<OrderDetail>();
        }
    }
}