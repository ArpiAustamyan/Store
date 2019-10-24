using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project
{
    public class Models
    {
        public class Branch
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { set; get; }
            public string Name { set; get; }
        }

        public class Product
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { set; get; }
            public string Name { set; get; }
            public int Price { set; get; }
        }

        public class Order
        {
            [Key, Column(Order = 1)]
            public int Id { set; get; }
            [Key, Column(Order = 2)]
            public int BranchId { set; get; }

            [ForeignKey("BranchId")]
            public Branch Branch { set; get; }
        }

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
}