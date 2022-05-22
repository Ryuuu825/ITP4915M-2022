
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using TheBetterLimited_Server.AppLogic.Controllers;
using TheBetterLimited_Server.Data;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/supplier")]
    public class Supplier : ControllerBase
    {
        // CURD: ADD, Modify, Delete, search

        private readonly SupplierController controller;

        public Supplier(DataContext db)
        {
            controller = new SupplierController(db);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSupplier()
        {
            try
            {
                return Ok(await controller.GetAllSupplier());
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplierById(string id)
        {
            return Ok(await controller.GetSupplierById(id));
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetSupplierByQueryString(string queryString )
        {
            try
            {
                return Ok(await controller.GetSupplierByQueryString(queryString ));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddSupplier([FromBody] Data.Entity.Supplier supplier)
        {
            try
            {
                await controller.AddSupplier(supplier);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ModifySupplier(string id , [FromBody] List<AppLogic.Models.UpdateObjectModel> content)
        {
            try
            {
                await controller.ModifySupplier(id , content);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(string id)
        {
            try
            {
                await controller.DeleteSupplier(id);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

    }
} 