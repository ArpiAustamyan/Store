using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OrderProduct
    {
        [Key, Column(Order = 1)]
        public int OrderId { get; set; }
        [Key, Column(Order = 2)]
        public int BranchId { set; get; }
        [Key, Column(Order = 3)]
        public int ProductId { get; set; }
        public int Count { set; get; }

        [ForeignKey("OrderId,BranchId")]
        public Order Order { set; get; }
        [ForeignKey("ProductId")]
        public Product Product { set; get; }
    }
}
