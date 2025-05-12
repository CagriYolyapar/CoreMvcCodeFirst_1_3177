using CoreMvcCodeFirst_1.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CoreMvcCodeFirst_1.Models.Configurations
{
    public class AppUserConfiguration : BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder); //Configure metodunun orijinal görevidir (BaseConfiguration generic class'ında tanımlanmıs görevidir)

            builder.HasOne(x => x.AppUserProfile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.BenimId); //Bu ifade EF Core icerisinde birebir ilişkiyi tamamlayan ifadedir...BUrada demek istedigimiz ifade : AppUser girilmesi zorunlu olan alandır ama AppUserProfile dilerseniz bos gecilebilir....Bos gecilebilecek alanın AppUserProfile oldugunu belirten kod parcacıgı HasForeignKey<AppUserProfilie> ile ve (x => x.Id) expression parametresi ile belirtilmiştir...
        }
    }
}
