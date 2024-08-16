using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicSAPP.Models.Dto
{
    public class AnimalDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime DateUpdated { get; set; }
        public string Name { get; set; }
        public string NumberId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfAcquisition { get; set; }
        public int AnimalTypeId { get; set; }
        public int RaceId { get; set; }
        public int NumberOfDeliveries { get; set; }
        public int ReproductiveStatusId { get; set; }
        public string Photo {  get; set; }
        public AnimalDto()
        {
            Name = string.Empty;
            NumberId = string.Empty;
            Photo = string.Empty;
        }
    }
}
