using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderWeb.Models;


namespace OrderWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderServiceContext orderDB;

        //构造函数把TodoContext 作为参数，Asp.net core 框架可以自动注入TodoContext对象
        public OrderController(OrderServiceContext context)
        {
            this.orderDB = context;
        }

        // GET: api/todo/{id}  id为路径参数
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var o = orderDB.Orders.FirstOrDefault(t => t.ID == id);
            if (o == null)
            {
                return NotFound();
            }
            return o;
        }
        [HttpGet]
        public List<Order> QueryAll()
        {
            return orderDB.Orders.OrderBy(o => o.Price).ToList<Order>();
        }
        //添加订单
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                orderDB.Orders.Add(order);
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }
        // DELETE: api/todo/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTodoItem(long id)
        {
            try
            {
                var order = orderDB.Orders.FirstOrDefault(t => t.ID == id);
                if (order != null)
                {
                    orderDB.Remove(order);
                    orderDB.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        // edit the order, found by id
        [HttpPatch("")]
        public ActionResult<Order> EditOrder( Order order)
        {
            try
            {
                orderDB.Entry(order).State = EntityState.Modified;
                orderDB.SaveChanges();
                return order;
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

    }


}