using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Dtos.ContactDtos;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{

    //Dto ile Manuel Mapleme İşlemi
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext _context;
        public ContactsController(ApiContext context)
        {
            _context = context; 
        }

        [HttpGet]
        private IActionResult ContactList()
        {
            var values = _context.Contacts.ToList();
            return Ok(values);

        }

        [HttpPost]
        private IActionResult CreateContact(CreateContactDto createContactDto)
        {
            Contact contact = new Contact();    
            contact.Email = createContactDto.Email; 
            contact.Address = createContactDto.Address;
            contact.Phone = createContactDto.Phone; 
            contact.MapLocation = createContactDto.MapLocation; 
            contact.OpenHours = createContactDto.OpenHours;
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok();
  
        }

        [HttpDelete]

        private IActionResult DeleteContact(int id)
        {
            var value = _context.Contacts.Find(id);
            _context.Contacts.Remove(value);    
            _context.SaveChanges(); 
            return Ok();    

        }


        [HttpGet("GetContact")]
        private IActionResult GetContact(int id)
        {
           var value =  _context.Contacts.Find(id);
            return Ok(value);
        }

         [HttpPut]
         public IActionResult UpdateContect(UpdateContcatDto updateContcatDto)
         {
            Contact contact = new Contact();
            contact.ContactId = updateContcatDto.ContactId; 
            contact.Email = updateContcatDto.Email; 
            contact.Address = updateContcatDto.Address; 
            contact.Phone = updateContcatDto.Phone;
            contact.MapLocation = updateContcatDto.MapLocation; 
            contact.OpenHours = updateContcatDto.OpenHours; 
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return Ok();    

         }

    }
}
