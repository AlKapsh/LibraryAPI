using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.EFCore
{

    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(prop => prop.Title)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(prop => prop.ReleaseYear)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(prop => prop.ISBN)
                .IsRequired();

            builder.HasOne(b => b.Publisher).WithMany(c => c.Books);
            builder.HasOne(b => b.Issuance).WithOne(i => i.Book);
        }

    }
}
