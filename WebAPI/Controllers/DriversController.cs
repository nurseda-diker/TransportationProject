using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        IDriverService _driverService;

        public DriversController(IDriverService driverService)
        {
            _driverService = driverService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _driverService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Driver driver)
        {
            var result = _driverService.Add(driver);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
