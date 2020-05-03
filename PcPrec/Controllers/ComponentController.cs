using API.Mappers;
using Core.Commands;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;


namespace PcPrec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentController : ControllerBase
    {
        private readonly IComponentService _componentService;

        public ComponentController(IComponentService componentService)
        {
            _componentService = componentService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _componentService.GetAll();

            return Ok(result.Select(c => c.Map()).ToList());
        }




        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            var result = await _componentService.GetById(id);

            return Ok(result.Map());
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Component>> Get(Guid id)
        //{
        //    var result = await _componentService.GetById(id);

        //    return Ok(result);
        //}

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AddComponentCommand command)
        {
            var result = await _componentService.Add(command);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Component>> Delete(Guid id)
        {
            await _componentService.Delete(id);

            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateComponentCommand command)
        {
            var result = await _componentService.Update(command);

            return Ok(result);
        }
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}
    }

}   
    

    
   
