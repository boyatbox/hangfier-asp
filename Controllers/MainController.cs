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

        // [HttpGet]
        // [Route("add")]
        // public async Task<ActionResult> add()
        // {
        //     try
        //     {
        //         //Guid.NewGuid().ToString()
        //         Profile profile = new Profile { name = Faker.Name.FullName() };
        //         await _context.Profiles.AddAsync(profile);
        //         await _context.SaveChangesAsync();

        //         return Ok(profile);
        //     }
        //     catch (Exception e)
        //     {
        //         return Ok(new { error = e.Message });
        //     }
        // }


        // [HttpGet]
        // [Route("nq")]
        // public async Task<IActionResult> nqJob()
        // {
        //     string id = Guid.NewGuid().ToString();
        //     string userName = Faker.Internet.UserName();
        //     var jobId = Hangfire.BackgroundJob.Enqueue(() => TestJob(userName));
        //     // RecurringJob.AddOrUpdate(() => Console.WriteLine("Minutely Job executed="+id), Cron.Minutely);  
        //     return Ok($"Job Completed");
        // }

        // [HttpGet]
        // [Route("run")]
        // public async Task<IActionResult> taskrun()
        // {
        //     await Task.Run(async () => TestLongJob());
        //     return Ok($"Job triggered");
        // }

        // [HttpGet]
        // [Route("recur")]
        // public async Task<IActionResult> recur()
        // {
        //     RecurringJob.AddOrUpdate(() => TestRecurringJob(), Cron.Minutely);
        //     RecurringJob.Trigger("task-id");
        //     return Ok($"Job Completed");
        // }
        
       
        // private async Task TestJob(string userName)
        // {
        //     int wait = 10;
        //     Console.WriteLine($"Waiting {wait} sec");
        //     Task.Delay(wait * 1000).Wait();
        //     Profile profile = new Profile { name = Faker.Name.FullName() };
        //     await _context.Profiles.AddAsync(profile);
        //     await _context.SaveChangesAsync();
        //     Console.WriteLine($"Done waiting. Hello {userName}");
        // }

        // private async Task TestLongJob()
        // {
        //     for (int i = 0; i < 30; i++)
        //     {
        //         int wait = 1;
        //         Console.WriteLine($"{i} -> Waiting {wait} sec");
        //         Task.Delay(wait * 1000).Wait();
        //         // Profile profile = new Profile { FullName = Faker.Name.FullName() };
        //         // await _context.Profiles.AddAsync(profile);
        //         // await _context.SaveChangesAsync();
        //         Console.WriteLine($"{i} -> Done waiting.");
        //     }

        // }


        // private async Task TestRecurringJob()
        // {
        //     Console.WriteLine($"Done waiting. Hello {Faker.Name.FullName()}");
        // }





    }
}
