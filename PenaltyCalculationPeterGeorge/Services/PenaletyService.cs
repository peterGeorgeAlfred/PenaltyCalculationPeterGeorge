using Microsoft.AspNetCore.Components;
using PenaltyCalculationPeterGeorge.Models;
using PenaltyCalculationPeterGeorge.Repositry.IManger;

namespace PenaltyCalculationPeterGeorge.Services
{
    public class PenaletyService : IPenaletyService
    {

        private readonly ICountryWeekEnds CountryWeekendsService ;

        public PenaletyService(ICountryWeekEnds _CountryWeekendsService)
        {
            CountryWeekendsService = _CountryWeekendsService; 
        }
        async Task<int> GetBussinessDay(DateTime startDate, DateTime endDate, int countryID)
        {
            int TotalBusinessDays = 0;

            if(startDate.Date == endDate.Date)
            {
                TotalBusinessDays = 0;
                return TotalBusinessDays; 
            }

            var  countryWeekEnds = await CountryWeekendsService.GetByCountryId(countryID);
           

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (!countryWeekEnds.Select(i => i.DayOf).Contains(date.DayOfWeek))
                    TotalBusinessDays++;
            }

            return TotalBusinessDays;
        }

        public async Task<int> GetPenality (int valuePerDay , DateTime startDate, DateTime endDate, int countryID)
        {
            return await GetBussinessDay(startDate, endDate, countryID) * valuePerDay;
            
        }
    }
}

