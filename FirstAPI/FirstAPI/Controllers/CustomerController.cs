using FirstAPI.Models;
using FirstAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository repo;
        public CustomerController(ICustomerRepository repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repo.GetCustomers());
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(repo.GetCustomer(id));

        }
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            repo.AddCustomer(customer);
            return StatusCode(201, "Customer details saved successfully");
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Customer customer)

        {
            repo.UpdateCustomer(id, customer);
            return Ok("Customer details updated successfully");
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            repo.DeleteCustomer(id);
            return Ok("Customer details deleted succcessfully");
        }
    }
}
