using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace api_vanilla.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<ActionResult> Get()
        {
            var data = await _context.Profiles.Select(o => new{id=o.Id,name=o.name}).ToListAsync();
            return Ok(data);
        }

        [HttpGet]
        [Route("getbyid")]
        public async Task<ActionResult> GetById([FromQuery]int id)
        {   
            var data = await _context.Profiles.Where(o=>o.Id==id).Select(o => o).FirstOrDefaultAsync();
            if(data==null) return BadRequest();
            return Ok(data);
        }

        [HttpGet]
        [Route("deleteall")]
        public async Task<ActionResult> Delete()
        {
            var data = await _context.Profiles.Select(o => o).ToListAsync();
            _context.RemoveRange(data);
            await _context.SaveChangesAsync();
            return Ok(data);
        }

        [HttpGet]
        [Route("generate")]
        public async Task<ActionResult> Generate(int count)
        {

            List<Profile> listOfProfile = new List<Profile>();
            for (int i = 1; i <= count; i++)
            {
                Profile profile = new Profile
                {
                    name = Faker.Name.FullName(),
                    age = Faker.RandomNumber.Next(100),
                    firstName = Faker.Name.First(),
                    lastName = Faker.Name.Last(),
                    email = Faker.Internet.Email(),
                    address = Faker.Address.StreetAddress(),
                    city = Faker.Address.City(),
                    dob = Faker.Identification.DateOfBirth(),
                };
                listOfProfile.Add(profile);
            }
            await _context.Profiles.AddRangeAsync(listOfProfile);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
