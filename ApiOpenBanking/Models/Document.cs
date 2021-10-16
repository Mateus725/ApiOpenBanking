using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Models
{
    public class Document
    {
        [Key]
        public string cpfNumber { get; set; }
        public string passportNumber { get; set; }
        public DateTime passportExpirationDate { get; set; }
        public DateTime passportIssueDate { get; set; }

    }
}
