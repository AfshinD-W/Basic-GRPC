using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrintController : ControllerBase
    {
        private readonly ServerJobClass _job;

        public PrintController(ServerJobClass job)
        {
            _job = job;
        }

        [HttpGet(Name = "print")]
        public IActionResult Print(string message)
        {
            var result = _job.Print(message);

            return Ok(result);
        }
    }
}
