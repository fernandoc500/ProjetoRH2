using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHModel
{
    public class RHContext : DbContext
    {
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<HistoricoCargo> HistoricoCargo { get; set; }
        public DbSet<HistoricoEmpregadoSetor> HistoricoEmpregadoSetor { get; set; }
        public DbSet<HistoricoSalarioCargo> HistoricoSalarioCargo { get; set; }
        public DbSet<HistoricoSalarioEmpregado> HistoricoSalarioEmpregado { get; set; }

        public RHContext()
        {
            Database.SetInitializer(new Initializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }

    public class Initializer : DropCreateDatabaseAlways<RHContext>
    {
        protected override void Seed(RHContext context)
        {
            base.Seed(context);
            context.Database.Delete();
            context.Database.Create();

            

        }

        
    }

}
