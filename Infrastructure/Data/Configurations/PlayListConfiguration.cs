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
    public class PlayListConfiguration : IEntityTypeConfiguration<PlayList>
    {
        public void Configure(EntityTypeBuilder<PlayList> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(p => p.listeners)
                .WithOne(l => l.PlayLists)
                .HasForeignKey(p => p.PlaylistId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
