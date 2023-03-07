using JQueryDataTable.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JQueryDataTable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CustomersController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult GetCustomers()
        {
         /*   var pageSize = 50;// int.Parse(Request.Form["length"]);
            var skip = 10;//int.Parse(Request.Form["start"]);
            var searchValue = Request.Form["search[value]"];
            IQueryable<Customer> customers = _context.Customers.Where(
                m => string.IsNullOrEmpty(searchValue) 
                ? true 
                : (m.FirstName.Contains(searchValue)) || (m.LastName.Contains(searchValue))|| (m.Contact.Contains(searchValue)));
         *
            var data = customers.Skip(skip).Take(pageSize).ToList();*/
           var customers = _context.Customers.ToList();
            var recordersTotal = customers.Count();
            var jsonData = new { recordsFiltered = recordersTotal, recordersTotal, data= customers};

            return Ok(jsonData);
        }
    }
}
