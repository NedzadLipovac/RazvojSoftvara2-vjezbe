using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class SkladistaUpsertRequest
    {
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Opis { get; set; }

    }
}
