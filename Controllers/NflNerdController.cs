using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NflStatsDotNet.Services;
using NflStatsDotNet.Services.Model;

namespace NflStatsDotNet.Controllers
{
    [ApiController]
    [Route("api")]
    public class NflNerdController : ControllerBase
    {
        private readonly NflNerdService _nflNerdService;
        
        public NflNerdController(NflNerdService nflNerdService)
        {
            _nflNerdService = nflNerdService;
        }

        [HttpGet("players")]
        public Task<NflPlayers> GetAllPlayers()
        {
            return _nflNerdService.GetAllPlayers();
        }

        [HttpGet("teams")]
        public Task<NflTeams> GetAllTeams()
        {
            return _nflNerdService.GetAllTeams();
        }
    }
}