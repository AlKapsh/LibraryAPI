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
    internal class AutorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a=> a.Id);

            builder.Property(a => a.FistName)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(a => a.SecondName)
                .IsRequired()
                .HasMaxLength(30);
        }

    }

    internal class AutorsToBookConfiguration : IEntityTypeConfiguration<AuthorToBook>
    {
        public void Configure(EntityTypeBuilder<AuthorToBook> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.AuthorId)
                .IsRequired();

            builder.Property(a => a.BookId)
                .IsRequired();

            builder.HasOne(b => b.Author).WithMany(a => a.AuthorsToBooks);
            builder.HasOne(b => b.Book).WithMany(a => a.AuthorsToBooks);

        }

    }

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

    internal class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(prop => prop.Address)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(prop => prop.Address)
                .HasMaxLength(30);

            builder.Property(prop => prop.PhoneNumber)
                .HasMaxLength(13)
                .IsRequired();

            builder.HasMany(b => b.Books).WithOne(c => c.Publisher);
        }

    }

    internal class ReaderConfiguration : IEntityTypeConfiguration<Reader>
    {
        public void Configure(EntityTypeBuilder<Reader> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(prop => prop.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(prop => prop.SecondName)
                 .IsRequired()
                 .HasMaxLength(30);

            builder.HasMany(b => b.Issuances).WithOne(c => c.Reader);
        }

    }

    internal class IssuanceConfiguration : IEntityTypeConfiguration<Issuance>
    {
        public void Configure(EntityTypeBuilder<Issuance> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.IssuanceDate)
                .HasColumnType("date");

            builder.Property(b => b.ReturnDate)
                 .HasColumnType("date");

            builder.HasOne(b => b.Reader).WithMany(c => c.Issuances);

            builder.HasOne(b => b.Book).WithOne(c => c.Issuance).HasForeignKey<Book>(c => c.IssuanceId);

        }

    }
}
