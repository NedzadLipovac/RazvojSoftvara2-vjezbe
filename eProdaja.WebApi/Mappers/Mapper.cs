using AutoMapper;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebApi.Mappers
{
   
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.Korisnici,KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Proizvodi, Model.Proizvod>();
            CreateMap<Database.Proizvodi,ProizvodiUpSetRequest>().ReverseMap();
            CreateMap<Database.Skladista, Model.Skladista>();
            CreateMap<Database.Skladista,SkladistaUpsertRequest>().ReverseMap();
        }
    }
}
