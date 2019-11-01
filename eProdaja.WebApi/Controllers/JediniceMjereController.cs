using eProdaja.Model;
using eProdaja.WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebApi.Controllers
{

    public class JediniceMjereController : BaseController<Model.JediniceMjere, object>
    {
        public JediniceMjereController(IService<JediniceMjere, object> service) : base(service)
        {
        }
    }
}
