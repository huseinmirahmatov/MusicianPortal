﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configurations
{
    public class TrackConfiguration : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                .IsRequired();
            builder.HasOne(t => t.Artists)
                .WithMany(a => a.Tracks)
                .HasForeignKey(t => t.ArtistId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Albums)
                .WithMany(a => a.Tracks)
                .HasForeignKey(t => t.AlbumId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.Genres)
                .WithMany(a => a.Tracks)
                .HasForeignKey(t => t.GenreId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Property(t => t.Reveiew)
                .IsRequired();
            builder.Property(t => t.Duration)
                .IsRequired();
        }
    }
}
