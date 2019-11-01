using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebApi.Services
{
   public interface IJediniceMjereService
    {
        List<Model.JediniceMjere> Get();
        Model.JediniceMjere GetById(int id);
    }
}
