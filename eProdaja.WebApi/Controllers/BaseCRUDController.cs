﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.WebApi.Controllers
{
    public class BaseCRUDController<T, TSearch,TInsert,TUpdate> : BaseController<T, TSearch>
    {
        private ICRUDService<T, TSearch, TInsert, TUpdate> _service = null;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }
        [HttpPost]
        public T Insert(TInsert request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public T  Update(int id, [FromBody]TUpdate request)
        {
            return _service.Update(id, request);
        }
    }
}
