﻿using CoreMvcCodeFirst_1.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMvcCodeFirst_1.Models.Configurations
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {

        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.UnitPrice).HasColumnType("money");
        }
    }
}
