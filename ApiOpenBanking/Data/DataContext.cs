using ApiOpenBanking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Filiation> Filiations { get; set; }
        public DbSet<GeographicCoordinate> GeographicCoordinates { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<OtherDocument> OtherDocuments { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<PostalAdress> PostalAdresses { get; set; }

        public DbSet<CompanyCNPJ> CompanyCNPJs { get; set; }

    }
}
