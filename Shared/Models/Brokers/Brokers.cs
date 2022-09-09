using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brokerfy.Shared.Models.Brokers
{
    public class Brokers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string CI { get; set; }

        public string? City { get; set; }
        public string? Addres { get; set; }
        public string Telephone { get; set; }
        public string? Empresa { get; set; }
        public string Role { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public void UpdateBroker(Brokers newdata)
        {
            FirstName = newdata.FirstName;
            LastName = newdata.LastName;
            Mail = newdata.Mail;
            CI = newdata.CI;
            City = newdata.City;
            Addres = newdata.Addres;
            Telephone = newdata.Telephone;
            Empresa = newdata.Empresa;
            Role = newdata.Role;
        }

    }

}
