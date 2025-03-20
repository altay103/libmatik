using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Title).IsRequired().HasMaxLength(100);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
            builder.HasData(
                new Book { Id = 1, Title = "The Great Gatsby", isAvailable = true },
                new Book { Id = 2, Title = "The Catcher in the Rye", isAvailable = true },
                new Book { Id = 3, Title = "To Kill a Mockingbird", isAvailable = true },
                new Book { Id = 4, Title = "1984", isAvailable = true }
            );
        }
    }
}
