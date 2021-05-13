using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testAPBD.Models;

namespace testAPBD.EFConfigurations
{
    public class AlbumEntityTypeConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(e => e.IdAlbum);
            builder.Property(e => e.IdAlbum).ValueGeneratedOnAdd();
            builder.Property(e => e.AlbumName).IsRequired().HasMaxLength(30);
            builder.Property(e => e.PublishDate).IsRequired().HasColumnType("Date");

            builder.HasOne(e => e.MusicLabel).WithMany(e => e.Albums).HasForeignKey(e => e.IdMusicLabel);

            builder.HasData(
                new Album { IdAlbum = 1, AlbumName = "AAA", PublishDate = DateTime.Parse("01/01/2021"), IdMusicLabel=1 },
                new Album { IdAlbum = 2, AlbumName = "BBB", PublishDate = DateTime.Parse("02/01/2021"), IdMusicLabel = 2 }
                );
        }
    }
}
