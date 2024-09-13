using System.ComponentModel.DataAnnotations;

namespace LoginRegistraionApp.Models
{
    public class Registration
    {
        
        public int Code { get; set; }

        public string ArabicName { get; set; } = null!;

        public string EnglishName { get; set; } = null!;

        public int Idnumber { get; set; }

        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string? Gender { get; set; }

        public int CountriesCode { get; set; }

        public int CityCode { get; set; }

        public string Password { get; set; } = null!;

        public string? EducationsType { get; set; }

        public string? Nots { get; set; } = null!;

        public string? Image { get; set; } = null!;

        public bool IsDelete { get; set; } = false;

        public bool IsBlock { get; set; } = false;

        public bool IsLocked { get; set; } = false;

        public bool Transfired { get; set; } = false;

        public DateTime? TransfiredDate { get; set; }

        public int? UserCode { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int? LastUpdateUserCode { get; set; }

        public DateTime? LastUpdateDate { get; set; }
    }
}
