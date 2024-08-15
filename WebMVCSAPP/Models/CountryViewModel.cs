namespace WebMVCSAPP.Models
{
    public class CountryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CountryViewModel()
        {
            Name = string.Empty;
        }
    }
}
