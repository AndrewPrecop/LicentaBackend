using API.Mappers;
using Core.Commands;
using Core.Commands.ConfigurationPC;
using Core.Entities;
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
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfigurationPCService _configurationPCService;

        public ConfigurationController(IConfigurationPCService configurationPCService)
        {
            _configurationPCService = configurationPCService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _configurationPCService.GetAll();

            return Ok(result.Select(c => c.Map()).ToList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            var result = await _configurationPCService.GetById(id);

            return Ok(result.Map());
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AddConfigurationPCCommand command)
        {
            var result = await _configurationPCService.Add(command);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConfigurationPC>> Delete(Guid id)
        {
            await _configurationPCService.Delete(id);

            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateConfigurationPCCommand command)
        {
            var result = await _configurationPCService.Update(command);

            return Ok(result);
        }

    }
}