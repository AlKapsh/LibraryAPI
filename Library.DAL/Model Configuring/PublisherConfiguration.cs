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

}
