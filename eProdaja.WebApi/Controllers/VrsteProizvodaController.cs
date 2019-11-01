using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VrsteProizvodaController : ControllerBase
    {
        //public VrsteProizvodaController(IService<VrsteProizvoda, object> service) : base(service)
        //{
        //}
        private readonly IVrsteProizvodaService _service;

        public VrsteProizvodaController(IVrsteProizvodaService service)
        {
            _service = service;

        }
        [HttpGet]
        public ActionResult<List<Model.VrsteProizvoda>> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public ActionResult<Model.VrsteProizvoda> GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
