using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LugaresController : ControllerBase
    {
        [HttpGet]
        public string GetLugares()
        {
            return "Esta sera una lista de los lugares";
        }
        [HttpGet("{id}")]
        public string GetLugar(int id)
        {
            return "Retornara un lugar";
        }
    }
}