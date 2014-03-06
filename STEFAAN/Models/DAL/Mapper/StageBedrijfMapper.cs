using System.Data.Entity.ModelConfiguration;
using STEFAAN.Models.Domain;


namespace STEFAAN.Models.DAL.Mapper
{
    public class StageBedrijfMapper : EntityTypeConfiguration<StageBedrijf>
    {
        public StageBedrijfMapper()
        {
            HasKey(t => t.StageBedrijfId);
            Property(t => t.StageBedrijfName).HasMaxLength(50);
            Property(t => t.Name).IsRequired().HasMaxLength(100);
            Property(t => t.FirstName).IsRequired().HasMaxLength(100);
            Property(t => t.Street).HasMaxLength(100);
            Property((t => t.Email)).IsRequired();
            ToTable("StageBedrijf");
            //HasMany(t => t.Orders).WithRequired().Map(m => m.MapKey("CustomerName")).WillCascadeOnDelete(true);
            //HasRequired(t => t.City).WithMany().Map(m => m.MapKey("PostalCode")).WillCascadeOnDelete(false);

        }
    }
}