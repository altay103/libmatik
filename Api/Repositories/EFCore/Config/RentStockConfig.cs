using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class RentStockConfig : IEntityTypeConfiguration<RentStock>
    {
        public void Configure(EntityTypeBuilder<RentStock> builder)
        {
            builder.HasKey(rs => rs.Id);

            builder.Property(rs => rs.Time)
                    .HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc)); 

            builder.Property(rs => rs.Status)
                   .HasConversion<int>(); // Enum to int

            builder.HasOne(rs => rs.User)
                   .WithMany()
                   .HasForeignKey(rs => rs.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(rs => rs.Book)
                   .WithMany()
                   .HasForeignKey(rs => rs.BookId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
