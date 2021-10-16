using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Models
{
    public class Phone
    {
        public bool isMain { get; set; }
        public string type { get; set; }
        public string additionalInfo { get; set; }
        public string countryCallingCode { get; set; }
        public string areaCode { get; set; }
        [Key]
        public string number { get; set; }
        public string phoneExtension { get; set; }
    }
}
