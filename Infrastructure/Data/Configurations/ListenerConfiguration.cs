using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configurations
{
    public class ListenerConfiguration : IEntityTypeConfiguration<Listener>
    {
        public void Configure(EntityTypeBuilder<Listener> builder)
        {
            builder.HasKey(l => l.Id);

            builder.HasOne(l => l.Users)
                .WithMany(u => u.listeners)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.Tracks)
                .WithMany(t => t.listeners)
                .HasForeignKey(l => l.TrackId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.PlayLists)
                .WithMany(p => p.listeners)
                .HasForeignKey(l => l.PlaylistId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
