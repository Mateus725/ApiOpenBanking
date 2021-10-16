using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Models
{
    
    public class Account
    {
        [Key]
        public int personalID { get; set; }
        public string brandName { get; set; }
        public string civilName { get; set; }
        public string socialName { get; set; }
        public DateTime dateTime { get; set; }
        public string maritalStatusCode { get; set; }
        public string maritalStatusAdditionalInfo { get; set; }
        public string sex { get; set; }
        public List<CompanyCNPJ> companyCnpj { get; set; }
        public Document document { get; set; }
        public List<OtherDocument> otherDocuments { get; set; }
        public bool hasBrazilianNationality { get; set; }
        public List<Nationality> nationality { get; set; }
        public List<Filiation> filiation { get; set; }
        public Contacts contacts { get; set; }

    }
}
