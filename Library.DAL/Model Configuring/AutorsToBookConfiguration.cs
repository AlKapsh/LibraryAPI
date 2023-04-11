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

}
