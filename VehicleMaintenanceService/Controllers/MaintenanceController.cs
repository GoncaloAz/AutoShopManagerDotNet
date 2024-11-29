using Microsoft.AspNetCore.Mvc;

namespace VehicleMaintenanceService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        public MaintenanceController()
        {
            
        }
        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("Inbound post from garage service works");
            return Ok("Inbound test succ");
        }
    }
}