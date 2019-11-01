using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Model.Requests;
using eProdaja.WebApi.Database;
using eProdaja.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
      
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
               
        }
        [HttpGet]
        public ActionResult<List<Model.Korisnici>> Get([FromQuery]KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Korisnici> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Korisnici Update(int id,[FromBody]KorisniciInsertRequest request)
        {
            return _service.Update(id,request);
        }
    }
}