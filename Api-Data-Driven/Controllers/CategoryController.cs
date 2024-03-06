using Api_Data_Driven.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_Data_Driven.Controllers
{
    [Route("categories")]
    public class CategoryController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Get()
        {
            return "ola mundo inteiro";
        }

        [HttpGet]
        [Route("{id:int}")]
        public string GetById(int id)
        {
            return "GET" + id.ToString();
        }

        [HttpPost]
        [Route("")]
        public Category Post([FromBody] Category model)
        {
            return model;
        }

        [HttpPut]
        [Route("id:int")]
        public Category Put(int id, [FromBody]Category model)
        {
            if(model.Id == id)
                return model;
            
            return null;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public string Delete()
        {
            return "Delete";
        }
    }
}
