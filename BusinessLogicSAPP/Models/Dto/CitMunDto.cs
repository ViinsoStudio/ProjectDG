using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicSAPP.Models.Dto
{
    public class CitMunDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepStaProId { get; set; }

        public CitMunDto()
        {
            Name = string.Empty;
        }
    }
}
