using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebApi.Database;
using eProdaja.WebApi.Exceptions;

namespace eProdaja.WebApi.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly eProdajaContext _context;
        private readonly IMapper _mapper;

        public KorisniciService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;


        }

        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.AsQueryable();
            if (!string.IsNullOrEmpty(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrEmpty(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);
            return _mapper.Map<Model.Korisnici>(entity);

        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);

            if(request.Password != request.PasswordConfirmation)
            {
                throw new UserException("passwordi se ne slazu");
            }

            entity.LozinkaHash = "test";
            entity.LozinkaSalt = "test";
            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Update(int id, KorisniciInsertRequest request)
        {
            var entity = _context.Korisnici.Find(id);
            _mapper.Map(request, entity);
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                throw new UserException("passwordi se ne slazu");

            }
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(entity);
            
        }
    }
}
