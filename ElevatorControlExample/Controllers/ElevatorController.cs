using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElevatorControlExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorController : ControllerBase
    {
        [HttpPost(Name = "CallElevator")]
        public bool Post(int floor)
        {
            return true;
        }
    }
}
