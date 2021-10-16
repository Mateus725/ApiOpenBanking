using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Models
{
    public class OtherDocument
    {
        public string type { get; set; }
        public string typeAdditionalInfo { get; set; }

        [Key]
        public string number { get; set; }
        public char checkDigit { get; set; }
        public string additionalInfo { get; set; }
        public DateTime expirationDate { get; set; }
        public DateTime issueDate { get; set; }
        public string country { get; set; }

    }
}
