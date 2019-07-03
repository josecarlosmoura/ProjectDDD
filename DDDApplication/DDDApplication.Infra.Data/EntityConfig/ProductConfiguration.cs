using DDDApplication.Domain.Entites;
using System.Data.Entity.ModelConfiguration;

namespace DDDApplication.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.Value)
                .IsRequired();

            //Relacionamento onde diz que UM Cliente tem VÁRIOS Produtos.
            HasRequired(p => p.Customer)
                .WithMany()
                .HasForeignKey(p => p.CustomerId);
        }
    }
}
