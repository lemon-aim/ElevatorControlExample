using ElevatorControlExample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;
using System.Text.Json;

namespace ElevatorControlExample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ElevatorController : ControllerBase
    {
        private IElevatorService _elevatorService;

        public ElevatorController(IElevatorService elevatorService)
        {
            _elevatorService = elevatorService;
        }

    
        [HttpPost(Name = "CallElevator")]
        public ActionResult<bool> CallElevator(int floor)
        {
            var floorRange = _elevatorService.GetFloorRange();
            if (floor > floorRange.max || floor < floorRange.min)
            {
                return UnprocessableEntity("Elevator does not service this floor.");
            }
            return true;
        }

        [HttpPost(Name = "SelectFloor")]
        public ActionResult<bool> SelectFloor(int floor)
        {
            var floorRange = _elevatorService.GetFloorRange();
            if (floor > floorRange.max || floor < floorRange.min)
            {
                return UnprocessableEntity("Elevator does not service this floor.");
            }
            return true;
        }

        [HttpGet(Name = "SelectedFloors")]
        public ActionResult<IEnumerable<int>> SelectedFloors()
        {
            return _elevatorService.FloorsSelected().ToList();
        }

        [HttpGet(Name = "NextFloor")]
        public ActionResult<int> NextFloor()
        {
            return _elevatorService.NextFloor();
        }
    }
}
