using System.ComponentModel.DataAnnotations.Schema;

namespace PenaltyCalculationPeterGeorge.Models
{
    public class CountryWeekEnds
    {
        public int Id { get; set; }

        [ForeignKey("Country")]
        public int CountryID { get; set; }

        public virtual Country Country { get; set; }

        public DayOfWeek DayOf { get; set; }

    }
}
