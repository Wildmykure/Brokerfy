using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Brokerfy.Shared.Models.Brokers
{
    public class BrokersDto
    {
        [JsonConstructor]
        public BrokersDto()
        {

        }

        public BrokersDto(Brokers broker)
        {
            FirstName = broker.FirstName;
            LastName = broker.LastName;
            Mail = broker.Mail;
            CI = broker.CI;
            City = broker.City;
            Addres = broker.Addres;
            Telephone = broker.Telephone;
            Empresa = broker.Empresa;
            Role = broker.Role;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string CI { get; set; }

        public string? City { get; set; }
        public string? Addres { get; set; }
        public string Telephone { get; set; }
        public string? Empresa { get; set; }
        public string Role { get; set; }

        public string Password { get; set; }

    }
}
