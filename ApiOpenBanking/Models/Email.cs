using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Models
{
    public class Email
    {
        public bool isMain { get; set; }

        [Key]
        public string email { get; set; }
    }
}
