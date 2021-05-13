using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testAPBD.EFConfigurations;
using testAPBD.Models;

namespace testAPBD
{
    public interface IDbContext
    {
        DbSet<Musician> Musicians { get; set; }

        DbSet<MusicLabel> MusicLabels { get; set; }

        DbSet<Album> Albums { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
    public class UniversityDbContext : DbContext, IDbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options)
        {
        }
        //sets
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }

        public DbSet<Album> Albums { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MusicianEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MusicLabelEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumEntityTypeConfiguration());
        }
    }
}
