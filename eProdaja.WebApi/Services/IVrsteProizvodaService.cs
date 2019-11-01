using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebApi.Services
{
    public interface IVrsteProizvodaService
    {
        List<Model.VrsteProizvoda> Get();
        Model.VrsteProizvoda GetById(int id);
    }
}
