using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testAPBD.Models;

namespace testAPBD.EFConfigurations
{
    public class MusicianEntityTypeConfiguration : IEntityTypeConfiguration<Musician>
    {
       public void Configure(EntityTypeBuilder<Musician> builder)
        {
            builder.HasKey(e => e.IdMusician);
            builder.Property(e => e.IdMusician).ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Nickname).HasMaxLength(20);

            builder.HasData(
                new Musician { IdMusician = 1, FirstName = "Robert", LastName = "Wasovski", Nickname = "Bobby" },
                new Musician { IdMusician = 2, FirstName = "Michael", LastName = "Jordan", Nickname = "MJ" }
                );
        }
    }
}
