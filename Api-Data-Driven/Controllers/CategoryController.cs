using Api_Data_Driven.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api_Data_Driven.Controllers
{
    [Route("categories")]
    public class CategoryController : Controller
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return new List<Category>();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> GetById(int id)
        {
            return new Category();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> Post([FromBody] Category model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
           
            return Ok(model);
        }

        [HttpPut]
        [Route("")]
        public async Task<ActionResult<Category>> Put(int id, [FromBody] Category model)
        {
            if (id != model.Id)
                return NotFound(new { message = "Categoria não encontrada" });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(model); 
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> Delete()
        {
            return Ok();
        }
    }
}
