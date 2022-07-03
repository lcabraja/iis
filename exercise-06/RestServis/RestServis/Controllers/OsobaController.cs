using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestServis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OsobaController : ControllerBase
    {
        private List<Osoba> PopisOsoba;

        public OsobaController(List<Osoba> popisOsoba)
        {
            PopisOsoba = popisOsoba;
        }

        public List<Osoba> Get()
        {
            return PopisOsoba;
        }

        [HttpGet("{datum:DateTime}")]
        public List<Osoba> Get(DateTime datum)
        {
            return PopisOsoba.Where(x => x.DatumRodenja < datum).ToList();
        }
    }
}
