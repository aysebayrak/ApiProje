using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly ApiContext _context;

        public EventsController(ApiContext context)
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult CreateEvent(Event Event)
        {
            _context.Events.Add(Event);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult ListEvent()
        {
            var values = _context.Events.ToList();
            return Ok(values);
        }

        [HttpDelete]
        public IActionResult DeleteEvent(int id)
        {
            var value = _context.Events.Find(id);
            _context.Events.Remove(value);
            _context.SaveChanges();
            return Ok();
        }


        [HttpGet("GetEvent")]
        public IActionResult GetEvent(int id)
        {
            var value = _context.Events.Find(id);
            return Ok(value);
        }

        [HttpPut]

        public IActionResult UpdateEvent(Event Event)
        {
            _context.Events.Update(Event);
            _context.SaveChanges();
            return Ok();
        }


    }
}
