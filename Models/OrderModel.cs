using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderModel
    {
        public string _BranchName { set; get; }
        public int _Price { set; get; }
        public List<ProdName> _ProductList { set; get; }
    }
}
