using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpMethodsExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/employee/{id}
        [HttpGet("employee/{id}")]
        public IActionResult Get(int id)
        {
            // Example logic to retrieve employee by id
            return Ok(new { id=1,Name="Test User", });
        }

        // POST: api/employee/create
        [HttpPost("employee/create")]
        public IActionResult Create(Employee employee)
        {
            // Your DB operation to save the employee
            return Ok("New employee added successfully");
        }


        // PUT: api/employee/update/{id}
        [HttpPut("employee/update/{id}")]
        public IActionResult Update(int id, Employee employee)
        {
            // Example logic to update employee by id
            // Your DB operation to update the employee
            return Ok("Employee updated successfully");
        }


        // DELETE: api/employee/delete/{id}
        [HttpDelete("employee/delete/{id}")]
        public IActionResult Delete(int id)
        {
            // Example logic to delete employee by id
            // Your DB operation to delete the employee
            return Ok("Employee deleted successfully");
        }

        // PATCH: api/employee/update/{id}
        [HttpPatch("employee/update/{id}")]
        public IActionResult Patch(int id, [FromBody] Employee employee)
        {
            // Example logic to partially update employee details
            // Your DB operation to partially update the employee
            return Ok("Employee details partially updated successfully");
        }

        // OPTIONS: api/employee
        [HttpOptions("employee")]
        public IActionResult Options()
        {
            Response.Headers.Add("Allow", "GET, POST, PUT, PATCH, DELETE, OPTIONS, TRACE");
            return Ok();
        }


        // HEAD: api/employee/{id}
        [HttpHead("employee/{id}")]
        public IActionResult Head(int id)
        {
            // Simulate checking if an employee exists by id
            var employeeExists = true; // Replace with actual logic

            if (employeeExists)
            {
                Response.Headers.Add("Content-Length", "1234"); // Example header
                Response.Headers.Add("Content-Type", "application/json");
                return Ok(); // No body is returned
            }
            else
            {
                return NotFound();
            }
        }
    }
}
