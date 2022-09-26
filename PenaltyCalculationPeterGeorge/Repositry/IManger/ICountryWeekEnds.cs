using PenaltyCalculationPeterGeorge.Models;
using PenaltyCalculationPeterGeorge.Repositry.IGeneral;

namespace PenaltyCalculationPeterGeorge.Repositry.IManger
{
    public interface ICountryWeekEnds : IGeneral<CountryWeekEnds>
    {
        Task<List<CountryWeekEnds>> GetByCountryId(int countryId);
    }
}
