using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using desafio01.Models;
using desafio01.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace desafio01.Controllers
{
    [ApiController]
    [Route("api/tools")]
    public class ToolsController : ControllerBase
    {
        private readonly IToolsRepository _repository;
        public ToolsController(IToolsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tool>>> GetTools([FromQuery] string tag)
        {

            var tools = await _repository.GetTools(tag);
            return Ok(tools);

        }

        [HttpPost]
        public async Task<ActionResult<ToolsForReturn>> createTool([FromBody] ToolForCreation tool)
        {
            if (tool == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var toolResult = await _repository.Create(tool);

            return toolResult;
        }

        [HttpDelete("{toolsId}")]
        public async Task<ActionResult> deleteTools([FromRoute] Guid toolsId)
        {

            await _repository.Delete(toolsId);
            return NoContent();
        }
    }
}