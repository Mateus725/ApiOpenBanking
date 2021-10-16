using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Models
{
    public class Contacts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public List<PostalAdress> postalAdresses { get; set; }
        public List<Phone> phones { get; set; }
        public List<Email> emails { get; set; }
    }
}
