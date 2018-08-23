using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLSL2018.Data.Entities;
using QLSL2018.Data.FF.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSL2018.Data.FF.Configurations
{
    public class FunctionConfiguration : DbEntityConfiguration<Function>
    {
        public override void Configure(EntityTypeBuilder<Function> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).IsRequired()
                .HasColumnType("varchar(128)");
            // etc.
        }
    }
}
