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
