using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testAPBD.Models;

namespace testAPBD.EFConfigurations
{
    public class MusicLabelEntityTypeConfiguration : IEntityTypeConfiguration<MusicLabel>
    {
        public void Configure(EntityTypeBuilder<MusicLabel> builder)
        {
            builder.HasKey(e => e.IdMusicLabel);
            builder.Property(e => e.IdMusicLabel).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);

            builder.HasData(
               new MusicLabel {IdMusicLabel = 1, Name = "Duck"},
               new MusicLabel {IdMusicLabel = 2, Name = "Quack" }
               );
        }
    }
}
