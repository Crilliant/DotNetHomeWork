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
        public class CustomerController : ControllerBase
        {
            private readonly OrderServiceContext orderDB;

            //构造函数把TodoContext 作为参数，Asp.net core 框架可以自动注入TodoContext对象
            public CustomerController(OrderServiceContext context)
            {
                this.orderDB = context;
            }

            // GET: api/todo/{id}  id为路径参数
            [HttpGet("{id}")]
            public ActionResult<Customer> GetOrder(int id)
            {
                var customer = orderDB.Customers.FirstOrDefault(c => c.ID == id);
                if (customer == null)
                {
                    return NotFound();
                }
                return customer;
            }
           
            //添加订单
            [HttpPost]
            public ActionResult<Order> PostOrder(Customer c)
            {
                try
                {
                    orderDB.Customers.Add(c);
                    orderDB.SaveChanges();
                }
                catch (Exception e)
                {
                    return BadRequest(e.InnerException.Message);
                }
                return c;
            }
            // DELETE: api/todo/{id}
            [HttpDelete("{id}")]
            public ActionResult DeleteTodoItem(int id)
            {
                try
                {
                    var customer = orderDB.Customers.FirstOrDefault(c => c.ID == id);
                    if (customer != null)
                    {
                        orderDB.Remove(customer);
                        orderDB.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(e.InnerException.Message);
                }
                return NoContent();
            }
        
}
