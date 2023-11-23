using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace command_microservices;

[ApiController]
[Route("api/[controller]")]
public class CommandController : ControllerBase
{
    private CommandDbContext _commands;
    public CommandController(CommandDbContext commands)
    {
        _commands = commands;
    }

    // GET api/<CommandController>
    [HttpGet]
    public IActionResult Get()
    {
        var command = _commands.Commands;
        return Ok(command);
    }

    public Command GetById(int id)
    {
        var commands = _commands.Commands.Find(id);
        if (commands == null) { throw new KeyNotFoundException("Commands not found"); }
        return commands;
    }

    // GET api/<CommandController>/5
    [AllowAnonymous]
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var emp = _commands.Commands.Find(id);
        return Ok(emp);
    }

    // POST api/<CommandController>
    [HttpPost]
    public IActionResult Post([FromBody] Command model )
    {
        var commandExist = _commands.Commands.Any(e => e.ID == model.ID);
        if (commandExist == true)
        {
            return Ok(new { Message = "A command already exist with this ID" });
        }

        _commands.Add(model);
        _commands.SaveChanges();

        return Ok(new { Message = "Command created" });
    }

    // PUT api/<CommandController>/5
    [HttpPut("{id}")]
    public IActionResult Put([FromBody] Command model)
    {
        _commands.Commands.Attach(model);
        _commands.Entry(model).State = EntityState.Modified;        

        // _commands.Commands.Update(model);
        _commands.SaveChanges();
                    
        return Ok(new { Message = "Command updated" });
    }

    // DELETE api/<CommandController>/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var command = GetById(id);               

        _commands.Commands.Remove(command);
        _commands.SaveChanges();

        return Ok(new { Message = "Command deleted" });
    }
}
