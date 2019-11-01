using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.WebApi.Database;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Skladista = eProdaja.Model.Skladista;

namespace eProdaja.WebApi.Services
{
    public class SkladistaService : BaseCRUDService<Model.Skladista,SkladistaSearchRequest, Database.Skladista, SkladistaUpsertRequest, Model.Requests.SkladistaUpsertRequest>
    {
        public SkladistaService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<eProdaja.Model.Skladista>Get(SkladistaSearchRequest search)
        {
            var query = _context.Set<eProdaja.WebApi.Database.Skladista>().AsQueryable();

            if(!string.IsNullOrEmpty(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            query = query.OrderBy(x => x.Naziv);
            var list = query.ToList();
            return _mapper.Map<List<Model.Skladista>>(list);

        }
    }
}
