using AutoMapper;
using eProdaja.Model;
using eProdaja.WebApi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebApi.Services
{
    public class JediniceMjereService:IJediniceMjereService
    {
        protected readonly eProdajaContext _context;
        protected readonly IMapper _mapper;
        public JediniceMjereService(eProdajaContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.JediniceMjere> Get()
        {
            var list = _context.JediniceMjere.ToList();
            return _mapper.Map<List<Model.JediniceMjere>>(list);
        }

        public Model.JediniceMjere GetById(int id)
        {
            var entity = _context.JediniceMjere.Find(id);

            return _mapper.Map<Model.JediniceMjere>(entity);
        }
    }
}
