using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eProdaja.Model;
using eProdaja.WebApi.Services;
using eProdaja.Model.Requests;

namespace eProdaja.WebApi.Controllers
{

    public class ProizvodController : BaseCRUDController<Model.Proizvod, ProizvodSearchRequest, ProizvodiUpSetRequest, ProizvodiUpSetRequest>
    {
        public ProizvodController(ICRUDService<Proizvod, ProizvodSearchRequest, ProizvodiUpSetRequest, ProizvodiUpSetRequest> service) : base(service)
        {
        }
    }



}