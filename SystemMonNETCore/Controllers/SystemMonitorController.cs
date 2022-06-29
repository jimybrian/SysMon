using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemMonNETCore.Repository;

namespace SystemMonNETCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemMonitorController : ControllerBase
    {
        readonly SystemMonitorRepo sRepo = new SystemMonitorRepo();


        [Route("getSystemInfo")]
        [HttpGet]        
        public IActionResult getSystemInfo()
        {
            return Ok(sRepo.GetSystemInfo());
        }

    }
}
