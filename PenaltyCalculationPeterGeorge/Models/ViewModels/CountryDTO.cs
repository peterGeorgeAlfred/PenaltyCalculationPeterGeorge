using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace PenaltyCalculationPeterGeorge.Models.ViewModels
{
    public class CountryDTO
    {
        [Required]
        public string CountryName { get; set; }

        [Required]
        public string CountryLanguageCode { get; set; }

        [Required]
        [Range(1,int.MaxValue)]
        public int PenaletyValue { get; set; } = 1;

        [Required]
        [MinLength(1, ErrorMessage = "Choose at lesat one day")]
        public DayOfWeek[] Weekends { get; set; } = { }; 
    }
}

