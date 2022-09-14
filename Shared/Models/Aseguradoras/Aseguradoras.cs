using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brokerfy.Shared.Models.Aseguradoras
{
    public class Aseguradoras
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Mail { get; set; }
        public string? Company { get; set; }
        public string Addres { get; set; }
        public string City { get; set; }
        public string Ruc { get; set; }
        public string Cellphone { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public void UpdateAseguradoras(Aseguradoras newdata)
        {
            Mail = newdata.Mail;
            Company = newdata.Company;
            Addres = newdata.Addres;
            City = newdata.City;
            Ruc = newdata.Ruc;
            Cellphone = newdata.Cellphone;

        }
    }
}
