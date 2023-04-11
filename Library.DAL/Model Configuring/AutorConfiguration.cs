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

}
