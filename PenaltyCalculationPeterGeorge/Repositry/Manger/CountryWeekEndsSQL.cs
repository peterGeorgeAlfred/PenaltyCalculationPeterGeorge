using Microsoft.EntityFrameworkCore;
using PenaltyCalculationPeterGeorge.Context;
using PenaltyCalculationPeterGeorge.Models;
using PenaltyCalculationPeterGeorge.Repositry.IGeneral;
using PenaltyCalculationPeterGeorge.Repositry.IManger;

namespace PenaltyCalculationPeterGeorge.Repositry.Manger
{
    public class CountryWeekEndsSQL : General<CountryWeekEnds> , ICountryWeekEnds
    {
        private readonly DBContext db;
        public CountryWeekEndsSQL(DBContext _db) : base(_db)
        {
            db = _db; 
        }

        public async Task<List<CountryWeekEnds>> GetByCountryId(int countryId)
        {
            return await db.CountryWeekEnds.Where(i => i.CountryID == countryId).ToListAsync(); 
        }
    }
}
