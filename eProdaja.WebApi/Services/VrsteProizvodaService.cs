using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Model;
using eProdaja.WebApi.Database;

namespace eProdaja.WebApi.Services
{
    public class VrsteProizvodaService : IVrsteProizvodaService

    {
        protected readonly eProdajaContext _context;
        private readonly IMapper _mapper;
        public VrsteProizvodaService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.VrsteProizvoda> Get()
        {
            var list = _context.VrsteProizvoda.ToList();
            List<Model.VrsteProizvoda> destinacija = new List<Model.VrsteProizvoda>();
            //return _mapper.Map<List<WebApi.Database.VrsteProizvoda>, List<Model.VrsteProizvoda>>(list, destinacija);
          
            return _mapper.Map<List<Model.VrsteProizvoda>>(list);
        }

        public Model.VrsteProizvoda GetById(int id)
        {
            var entity = _context.VrsteProizvoda.Find(id);
            return _mapper.Map<Model.VrsteProizvoda>(entity);
        }
    }
}