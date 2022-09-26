using System.ComponentModel.DataAnnotations;

namespace PenaltyCalculationPeterGeorge.Models.ViewModels
{
    public class PenaletyDTO
    {
        public DateTime StartDate { get; set; } = DateTime.Now; 
        public DateTime EndDate { get; set; } = DateTime.Now;          
        public int CountryID { get; set; }
    }
}
