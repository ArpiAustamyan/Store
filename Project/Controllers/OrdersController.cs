using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using static Project.Models;

namespace Project.Controllers
{
    [RoutePrefix("api/OrdersController")]
    public class OrdersController : ApiController
    {
        private Context db = new Context();

        [HttpGet]
        public IQueryable<OrderModel> GetOrders()
        {
            var ob = from op in db.OrderProducts
                     join o in db.Orders on op.OrderId equals o.Id
                     join p in db.Products on op.ProductId equals p.Id
                     join b in db.Branchs on o.BranchId equals b.Id
                     group op by new { o1 = o, b1 = b } into gr
                     select new OrderModel
                     {
                         _BranchName = gr.Key.b1.Name,
                         _Price = gr.Sum(i => i.Count * i.Product.Price),
                         _ProductList = gr.Select(i => new ProdName
                         {
                             _Product = i.Product.Name,
                             _Count = i.Count,
                             _Amount = i.Product.Price
                         }).ToList()
                     };

            return ob;
        }

        [BasicAuthentication]
        public IHttpActionResult GetOrder(int id1, int id2)
        {
            if (GetBranch(id2)==false)
            {
                return Ok(new ErrModel { _Code = 13, _Message = "Problem with branch id" });
            }

            Order order = db.Orders.Find(id1, id2);

            if (order == null)
            {
                return Ok(new ErrModel { _Code = 12, _Message = "Problem with order id" });
            }

            var ob = from op in db.OrderProducts
                     join o in db.Orders on op.OrderId equals o.Id
                     join p in db.Products on op.ProductId equals p.Id
                     join b in db.Branchs on o.BranchId equals b.Id
                     where o.Id == id1 && o.BranchId == id2
                     group op by new { o1 = o, b1 = b } into gr
                     select new OrderModel
                     {

                         _BranchName = gr.Key.b1.Name,
                         _Price = gr.Sum(i => i.Count * i.Product.Price),
                         _ProductList = gr.Select(i => new ProdName
                         {
                             _Product = i.Product.Name,
                             _Count = i.Count,
                             _Amount = i.Product.Price
                         }).ToList()
                     };

            return Ok(ob);
        }

        private bool GetBranch(int id2)
        { 
            Branch branch = db.Branchs.Find(id2);

            if (branch == null)
            {
                return false;
            }
            return true;
        }

    }
}

