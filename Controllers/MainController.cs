using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api_vanilla.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        private readonly AppDbContext _context;
        public MainController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new { msg = "hello..ur in main controller" });
        }

        [HttpGet]
        [Route("add")]
        public async Task<ActionResult> add()
        {
            try
            {
                //Guid.NewGuid().ToString()
                Profile profile = new Profile { FullName = Faker.Name.FullName() };
                await _context.Profiles.AddAsync(profile);
                await _context.SaveChangesAsync();
                return Ok(profile);
            }
            catch (Exception e)
            {
                return Ok(new { error = e.Message });
            }
        }


        [HttpGet]
        [Route("job")]
        public async Task<IActionResult> Job()
        {
            string userName=Faker.Internet.UserName();
            var jobId = BackgroundJob.Enqueue(() => SendWelcomeMail(userName));
            return Ok($"Job Id {jobId} Completed");
        }

        public void SendWelcomeMail(string userName)
        {
            Console.WriteLine($"Hello {userName}");
        }




    }
}
