using CoreMvcCodeFirst_1.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMvcCodeFirst_1.Models.Configurations
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            //builder.Property(x => x.CreatedDate).HasColumnName("Yaratılma Tarihi");
            //builder.Property(x => x.DeletedDate).HasColumnName("Silme Tarihi");
            //builder.Property(x => x.UpdatedDate).HasColumnName("Güncelleme Tarihi");
            //builder.Property(x => x.Status).HasColumnName("Veri Durumu");
        }
    }


    /*
     
     public abstract class BaseConfiguration<T> : EntityTypeConfiguration<T> where T: BaseEntity
    {
        public BaseConfiguration<T>()
    {
      
    }

    }
     
     
     
     
     
     
     
     
     
     */
}
