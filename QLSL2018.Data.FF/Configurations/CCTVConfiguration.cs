using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLSL2018.Data.Entities;
using QLSL2018.Data.FF.Extensions;
    

namespace QLSL2018.Data.FF.Configurations
{
    public class CCTVConfiguration : DbEntityConfiguration<CCTV>
    {
        public override void Configure(EntityTypeBuilder<CCTV> entity)
        {
            entity.Property(x => x.Id).ValueGeneratedNever();

        }
    }
}
