using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGlasser.Context;
using APIGlasser.Models.TablasPlabal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGlasser.Controllers
{
    [Produces("application/json")]
    [Route("api/ECOM_PEDIDOS")]
    public class ECOM_PEDIDOSController : Controller
    {
        private readonly PlabalDBContext context;

        public ECOM_PEDIDOSController(PlabalDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Feriados> Get()
        {
            return context.Feriados.ToList();
        }
    }
}