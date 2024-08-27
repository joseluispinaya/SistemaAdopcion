using SisemaAdopcion.Shared.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisemaAdopcion.Shared.Dtos
{
    public class PetDetailDto : PetListDto
    {
        public bool IsFavorite { get; set; }
        public string? Description { get; set; }

        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public AdoptionStatus AdoptionStatus { get; set; }

        public string? GenderDisplay => Gender.ToString();

        //public string GenderImage => Gender switch { Gender.Male => "male", Gender.Female => "female" };

        public string? GenderImage => Gender switch
        {
            Gender.Male => "male",
            Gender.Female => "female",
            _ => throw new InvalidOperationException("Unexpected Gender value.")
        };

        public string? Age
        {
            get
            {
                var diff = DateTime.Now.Subtract(DateOfBirth);
                var days = diff.Days;
                return days switch
                {
                    < 30 => days + " dias",
                    >= 30 and <= 31 => "1 mes",
                    < 365 => Math.Floor(diff.TotalDays / 30) + " meses",
                    365 => "1 Year",
                    _ => Math.Floor(diff.TotalDays / 365) + " years"
                };
            }
        }
    }
}
