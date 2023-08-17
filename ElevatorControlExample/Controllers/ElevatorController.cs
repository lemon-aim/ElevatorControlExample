using ElevatorControlExample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ElevatorControlExample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ElevatorController : ControllerBase
    {
        private readonly ILogger<ElevatorController> _logger;
        private IElevatorService _elevatorService;

        public ElevatorController(IElevatorService elevatorService, ILogger<ElevatorController> logger)
        {
            _elevatorService = elevatorService;
            _logger = logger;
        }

    
        [HttpPost(Name = "CallElevator")]
        public HttpResponseMessage CallElevator(int floor)
        {
            var floorRange = _elevatorService.GetFloorRange();
            if (floor > floorRange.max || floor < floorRange.min)
            {
                return new HttpResponseMessage
                {
                    Content = new StringContent("Elevator does not service this floor."),
                    StatusCode = HttpStatusCode.UnprocessableEntity
                };
            }
            return new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK
            };
        }

        [HttpPost(Name = "SelectFloor")]
        public HttpResponseMessage SelectFloor(int floor)
        {
            var floorRange = _elevatorService.GetFloorRange();
            if (floor > floorRange.max || floor < floorRange.min)
            {
                return new HttpResponseMessage
                {
                    Content = new StringContent("Elevator does not service this floor."),
                    StatusCode = HttpStatusCode.UnprocessableEntity
                };
            }
            return new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK
            };
        }

    }
}
