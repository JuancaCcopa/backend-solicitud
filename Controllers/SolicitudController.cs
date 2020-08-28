using Aplicacion.Interface;
using Entidad;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace appbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {

        private readonly ISolicitudAp _solicitud;
        public SolicitudController(ISolicitudAp credito)
        {
            _solicitud = credito ?? throw new ArgumentException(nameof(credito));
        }

        [HttpGet]
        public async Task<IEnumerable<SolicitudEnt>> get() {

            var lista = await _solicitud.listar();
            return lista;
        }

    }
}