using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class EFContext : DbContext

    {
        public EFContext() : base("EFConenectionsString")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<EspecialidadeMedica> EspecialidadeMedicas{ get; set; }
        public DbSet<Cidade> Cidades{ get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        


        public System.Data.Entity.DbSet<WebApplication7.Models.Medico> Medicos { get; set; }

        internal Cidade CidadesFind(int? id)
        {
            throw new NotImplementedException();
        }

        internal EspecialidadeMedica MedicosFind(int? id)
        {
            throw new NotImplementedException();
        }
    }
}