﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using eProdaja.Model;

namespace eProdaja.WinUI
{
    public class ApiService
    {
        private string _route = null;
        public ApiService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            var results = await url.GetJsonAsync<T>();

            return results;
        }
        public async Task<T> GetById<T>(object id)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            return await url.GetJsonAsync<T>();

        }
        public async Task<T> Insert<T>(object request)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            return await url.PostJsonAsync(request).ReceiveJson<T>();

        }
        public async Task<T> Update<T>(object id, object request)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            return await url.PutJsonAsync(request).ReceiveJson<T>();

        }

    }
}
