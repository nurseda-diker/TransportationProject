using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportationTeamsController : ControllerBase
    {
        ITransportationTeamService _transportationTeamService;

        public TransportationTeamsController(ITransportationTeamService transportationTeamService)
        {
            _transportationTeamService = transportationTeamService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _transportationTeamService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(TransportationTeam transportationTeam)
        {
            var result = _transportationTeamService.Add(transportationTeam);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getteambycompanyid")]
        public IActionResult GetTeamByCompanyId(int companyId)
        {
            var result = _transportationTeamService.GetTeamByCompanyId(companyId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
