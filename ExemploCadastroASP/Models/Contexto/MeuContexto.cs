using ExemploCadastroASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ExemploCadastroASP.Contexto
{
    public class MeuContexto : DbContext
    {
        public System.Data.Entity.DbSet<ExemploCadastroASP.Models.Pessoa> Pessoas { get; set; }

        public MeuContexto() : base("strConn")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MeuContexto>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) { modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); }

    }
}