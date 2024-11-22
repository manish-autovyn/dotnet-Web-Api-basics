using _01.introduction.Models;
using _01.introduction.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace _01.introduction.controllers
{
    [Route("api/v1/{controller}")]
    public class EmployeeController : ControllerBase
    {
        [Route("")]
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>
            {
                new EmployeeModel() {Id = 1, Name = "zrx"},
                new EmployeeModel() {Id = 2, Name = "xrz"}
            };
        }

        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            Console.WriteLine("Request user id : " + id);
            if (id == 0) return NotFound();
            return Ok(new EmployeeModel() { Id = id, Name = "xrz" });
        }

        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeesBasicDetails(int id)
        {
            if (id == 0) return NotFound();
            return new EmployeeModel() { Id = id, Name = "zrx" };
        }

        [HttpGet("name")]
        public IActionResult GetName([FromServices] IProductRepository _productRepository)
        {
            var name = _productRepository.GetName();
            return Ok(name);
        }
    }
}
