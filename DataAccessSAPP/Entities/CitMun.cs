using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessSAPP.Entities
{
    public class CitMun
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(80)")]
        public string Name { get; set; }
        public int DepStaProId { get; set; }
        public class CitMunConfiguration : IEntityTypeConfiguration<CitMun>
        {
            [Obsolete]
            public void Configure(EntityTypeBuilder<CitMun> builder)
            {
                builder.HasIndex(cm => cm.DepStaProId)
                    .HasName("Id");

                builder.HasOne(typeof(DepStaPro))
                    .WithMany()
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }
    }
}
