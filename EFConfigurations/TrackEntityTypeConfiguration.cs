using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testAPBD.Models;

namespace testAPBD.EFConfigurations
{
    public class TrackEntityTypeConfiguration : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.HasKey(e => e.IdTrack);
            builder.Property(e => e.IdTrack).ValueGeneratedOnAdd();
            builder.Property(e => e.TrackName).IsRequired().HasMaxLength(30);
            builder.Property(e => e.Duration).IsRequired();

            //builder.HasOne(e => e.Album).WithOne(e => e.IdTrack).HasForeignKey(e => e.IdMusicAlbum);

            builder.HasData(
                new Musician { IdMusician = 1, FirstName = "Robert", LastName = "Wasovski", Nickname = "Bobby" },
                new Musician { IdMusician = 2, FirstName = "Michael", LastName = "Jordan", Nickname = "MJ" }
                );
        }
    }
}
