using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entity
{
    public class Order
    {
        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Key, Column(Order = 2)]
        public int BranchId { set; get; }

        [ForeignKey("BranchId")]
        public Branch Branch { set; get; }
    }
}
