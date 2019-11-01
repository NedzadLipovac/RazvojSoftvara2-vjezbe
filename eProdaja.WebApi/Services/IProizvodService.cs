using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebApi.Services
{
    public interface IProizvodService
    {
        IList<Proizvod> Get();
    }
}
