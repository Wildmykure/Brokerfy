using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Brokerfy.Shared.Models.Aseguradoras
{
    public class AseguradorasDto
    {
        [JsonConstructor]
        public AseguradorasDto()
        {

        }
        public AseguradorasDto(Aseguradoras aseguradoras)
        {
            Mail = aseguradoras.Mail;
            Company = aseguradoras.Company;
            Addres = aseguradoras.Addres;
            City = aseguradoras.City;
            Ruc = aseguradoras.Ruc;
            Cellphone = aseguradoras.Cellphone;
            public string Mail { get; set; }
            public string Company { get; set; }
            public string Addres { get; set; }
            public string City { get; set; }
            public string Ruc { get; set; }
            public string Cellphone { get; set; }
            public string Password { get; set; }

        }
    }
}
