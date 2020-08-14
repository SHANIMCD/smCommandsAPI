using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using smCommander.Data;
using smCommander.Models;

namespace smCommander.Controllers

{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        public CommandsController(IsmCommanderRepo repository)
        {
            _repo = repository;
        }

        // private readonly MockCommanderRepo _repo = new MockCommanderRepo();
        private readonly IsmCommanderRepo _repo;

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetListCommands()
        {
            var commandItems = _repo.getAllCommands();

            return Ok(commandItems);
        }
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repo.GetCommandById(id);

            return Ok(commandItem);
        }
        
    }
}