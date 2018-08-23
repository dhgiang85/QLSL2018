using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLSL2018.Data.Entities;
using QLSL2018.Data.FF.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSL2018.Data.FF.Configurations
{
    public class CCTVOwerConfiguration : DbEntityConfiguration<CCTVOwer>
    {
        public override void Configure(EntityTypeBuilder<CCTVOwer> entity)
        {
            entity.Property(x => x.Id).ValueGeneratedNever();
        }
    }
}
