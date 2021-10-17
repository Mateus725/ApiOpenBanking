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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int personalID { get; set; }
        public string brandName { get; set; }
        public string civilName { get; set; }
        public string socialName { get; set; }
        public DateTime dateTime { get; set; }
        public string maritalStatusCode { get; set; }
        public string maritalStatusAdditionalInfo { get; set; }
        public string sex { get; set; }
        public string companyCnpj { get; set; }
        public string CPF { get; set; }
        //public List<OtherDocument> otherDocuments { get; set; }
        public bool hasBrazilianNationality { get; set; }
        public string otherNationalitiesInfo { get; set; }
        public string typeDocument { get; set; }
        public string typeAdditionalInfo { get; set; }
        public string numberDocument { get; set; }
        public char checkDigit { get; set; }
        public string additionalInfo { get; set; }
        public DateTime expirationDate { get; set; }
        public DateTime issueDate { get; set; }
        public string country { get; set; }

        //public List<Nationality> nationality { get; set; }
        //public List<Filiation> filiation { get; set; }
        public string typeFiliation { get; set; }
        public string civilNameFiliation { get; set; }
        public string socialNameFiliation { get; set; }
        //public Contacts contacts { get; set; }

        public string address { get; set; }
        public string additionalInfoAdress { get; set; }
        public string districtName { get; set; }
        public string townName { get; set; }
        public string ibgeTownCode { get; set; }
        public string countrySubDivision { get; set; }
        public string postCode { get; set; }
        public string countryAdress { get; set; }
        public string countryCode { get; set; }

        public string typePhone1 { get; set; }
        public string additionalInfoPhone1 { get; set; }
        public string countryCallingCode1 { get; set; }
        public string areaCodePhone1 { get; set; }
        public string numberPhone1 { get; set; }
        public string phoneExtension1 { get; set; }

        public string typePhone2 { get; set; }
        public string additionalInfoPhone2 { get; set; }
        public string countryCallingCode2 { get; set; }
        public string areaCodePhone2 { get; set; }
        public string numberPhone2 { get; set; }
        public string phoneExtension2 { get; set; }

        public string email { get; set; }

    }
}
