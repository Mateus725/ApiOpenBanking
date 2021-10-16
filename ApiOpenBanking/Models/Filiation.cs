using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Models
{
    public class Filiation
    {
        public string type { get; set; }
        [Key]
        public string civilName { get; set; }
        public string socialName { get; set; }
    }
}
