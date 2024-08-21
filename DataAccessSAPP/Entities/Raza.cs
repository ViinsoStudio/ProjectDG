using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessSAPP.Entities
{
    public class Raza
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoAnimalId { get; set; }
    }
}
