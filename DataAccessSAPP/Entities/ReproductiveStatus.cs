using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessSAPP.Entities
{
    public class ReproductiveStatus
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int AnimalTypeId { get; set; }
    }
}
