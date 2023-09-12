using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportRequestsController : ControllerBase
    {
        ITransportRequestService _transportRequestService;
        public TransportRequestsController(ITransportRequestService transportRequestService)
        {
            _transportRequestService = transportRequestService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _transportRequestService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(TransportRequest transportRequest)
        {
            var result = _transportRequestService.Add(transportRequest);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
