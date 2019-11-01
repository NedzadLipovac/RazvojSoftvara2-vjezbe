using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebApi.Controllers
{
    public class SkladistaController : BaseCRUDController<Skladista, SkladistaSearchRequest, SkladistaUpsertRequest, SkladistaUpsertRequest>
    {
        public SkladistaController(ICRUDService<Skladista, SkladistaSearchRequest, SkladistaUpsertRequest, SkladistaUpsertRequest> service) : base(service)
        {
        }
    }
}
