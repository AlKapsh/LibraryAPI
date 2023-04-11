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
}
