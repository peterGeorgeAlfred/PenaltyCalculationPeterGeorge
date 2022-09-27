using System.ComponentModel.DataAnnotations;

namespace PenaltyCalculationPeterGeorge.Models
{
    public class Country
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Curreny { get; set; } = string.Empty; 

        public int   penaletyValue { get; set;  }
    }
}
