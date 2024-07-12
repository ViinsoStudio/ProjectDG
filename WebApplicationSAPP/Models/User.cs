﻿namespace WebApiSAPP.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string MiddleName { get; set; }
        public required string LastName { get; set; }
        public string MiddleLastName { get; set; }
        public required int IdentificationTypeDocumentId { get; set; }
        public  required string IdentificationDocumentNumber { get; set; }
        public required int CountryId { get; set; }
        public required int StaProDepId {get; set;}
        public required int CityId { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }

    }
}
