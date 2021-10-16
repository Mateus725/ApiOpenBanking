using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Models
{
    public class PostalAdress
    {
        public bool isMain { get; set; }
        public string address { get; set; }
        public string additionalInfo { get; set; }
        public string districtName { get; set; }
        public string townName { get; set; }
        public string ibgeTownCode { get; set; }
        public string countrySubDivision { get; set; }
        [Key]
        public string postCode { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public GeographicCoordinate geographicCoordinates { get; set; }
    }
}
