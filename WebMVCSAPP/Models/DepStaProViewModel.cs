using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVCSAPP.Models
{
    public class DepStaProViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public DepStaProViewModel()
        {
            Name = string.Empty;
        }
    }
}
