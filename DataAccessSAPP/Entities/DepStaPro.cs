using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessSAPP.Entities
{
    public class DepStaPro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(80)")]
        public string Name { get; set; }

        public int CountryId { get; set; }
        public DepStaPro() 
        {
            Name = string.Empty;
        }

        public class DepStaProdConfiguration : IEntityTypeConfiguration<DepStaPro>
        {
            [Obsolete]
            public void Configure(EntityTypeBuilder<DepStaPro> builder)
            {
                builder.HasIndex(dsp => dsp.CountryId)
                    .HasName("Id");

                builder.HasOne(typeof(Country))
                    .WithMany()
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }
    }
}
