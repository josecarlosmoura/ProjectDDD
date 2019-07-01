using DDDApplication.Domain.Entites;
using DDDApplication.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace DDDApplication.Infra.Data.Contexto
{
    public class DDDApplicationContext : DbContext
    {
        //Trei de criar o banco de dados e depois colocar a string de conexão aqui.
        //Lembrar de configurar no arquivo de configuração.
        public DDDApplicationContext() : base("MYConection")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name.Equals("Id"))
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(255));

            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrationDate") != null))
            {
                if (item.State == EntityState.Added)
                    item.Property("RegistrationDate").CurrentValue = DateTime.Now;

                if (item.State == EntityState.Modified)
                    item.Property("RegistrationDate").IsModified = false;

            }
            return base.SaveChanges();
        }
    }
}
