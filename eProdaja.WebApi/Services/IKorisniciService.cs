﻿using eProdaja.Model.Requests;
using eProdaja.WebApi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.WebApi.Services
{
   public  interface IKorisniciService
    {
        List<Model.Korisnici> Get(KorisniciSearchRequest request);
        Model.Korisnici GetById(int id);
        Model.Korisnici Insert(KorisniciInsertRequest request);
        Model.Korisnici Update(int id,KorisniciInsertRequest request);
    }
}
