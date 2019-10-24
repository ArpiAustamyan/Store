using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Project.Models;

namespace Project
{
    public class OrderModel
    {
        public string _BranchName {set;get;}
        public int _Price { set; get; }
        public List<ProdName> _ProductList { set; get; }
    }
    public class ProdName
    {
        public string _Product { set; get; }
        public int _Count { set; get; }
        public int _Amount { set; get; }
    }
    public class ErrModel
    {
        public int _Code;
        public string _Message; 
    }
}