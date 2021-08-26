using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace api_vanilla.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public TaskController(IServiceScopeFactory serviceProvider, AppDbContext context)
        {
            _context = context;
            _serviceScopeFactory = serviceProvider;
        }

        // [HttpGet]
        // [Route("run")]
        // public async Task<IActionResult> run()
        // {
        //     await Task.Run(async () => TestLongJob());
        //     return Ok($"Job triggered");
        // }

        // public async Task TestLongJob()
        // {
        //     using (var scope = _serviceScopeFactory.CreateScope())
        //     {
        //         var dbContext = scope.ServiceProvider.GetService<AppDbContext>();

        //         for (int i = 0; i < 300; i++)
        //         {
        //             int wait = 1;
        //             // Console.WriteLine($"{i} -> Waiting {wait} sec");
        //             Task.Delay(wait * 1000).Wait();
        //             string name_ = $"TestLongJob-{i}-{Faker.Name.FullName()}";
        //             Profile profile = new Profile { name = name_ };
        //             await dbContext.Profiles.AddAsync(profile);
        //             await dbContext.SaveChangesAsync();

        //             Console.WriteLine($"TestLongJob# {i}");
        //         }
        //     }



        // }
        // public async Task TestJob(string userName)
        // {
        //     int wait = 10;
        //     Console.WriteLine($"Waiting {wait} sec");
        //     Task.Delay(wait * 1000).Wait();
        //     Profile profile = new Profile { name = Faker.Name.FullName() };
        //     await _context.Profiles.AddAsync(profile);
        //     await _context.SaveChangesAsync();
        //     Console.WriteLine($"Done waiting. Hello {userName}");
        // }

        // [HttpGet]
        // [Route("up1")]
        // public async Task up1()
        // {
        //     for (int i = 0; i < 30; i++)
        //     {
        //         int wait = 1;
        //         Console.WriteLine($"{i} -> Waiting {wait} sec");
        //         Task.Delay(wait * 1000).Wait();
        //         string name_ = $"Update1-{i}-{Faker.Name.FullName()}";
        //         Profile profile = new Profile { name = name_ };
        //         await _context.Profiles.AddAsync(profile);
        //         await _context.SaveChangesAsync();

        //         Console.WriteLine($"Update1# {i}");
        //     }
        // }

        // [HttpGet]
        // [Route("up2")]
        // public async Task up2()
        // {
        //     for (int i = 0; i < 30; i++)
        //     {
        //         int wait = 1;
        //         Console.WriteLine($"{i} -> Waiting {wait} sec");
        //         Task.Delay(wait * 1000).Wait();
        //         string name_ = $"Update2-{i}-{Faker.Name.FullName()}";
        //         Profile profile = new Profile { name = name_ };
        //         await _context.Profiles.AddAsync(profile);
        //         await _context.SaveChangesAsync();

        //         Console.WriteLine($"Update2# {i}");
        //     }
        // }

        // [HttpGet]
        // [Route("up3")]
        // public async Task up3()
        // {
        //     for (int i = 0; i < 30; i++)
        //     {
        //         int wait = 1;
        //         Console.WriteLine($"{i} -> Waiting {wait} sec");
        //         Task.Delay(wait * 1000).Wait();
        //         string name_ = $"Update3-{i}-{Faker.Name.FullName()}";
        //         Profile profile = new Profile { name = name_ };
        //         await _context.Profiles.AddAsync(profile);
        //         await _context.SaveChangesAsync();

        //         Console.WriteLine($"Update3# {i}");
        //     }
        // }
    }
}
