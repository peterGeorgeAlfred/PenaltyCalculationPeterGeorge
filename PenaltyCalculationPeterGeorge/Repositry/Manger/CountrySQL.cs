using PenaltyCalculationPeterGeorge.Context;
using PenaltyCalculationPeterGeorge.Models;
using PenaltyCalculationPeterGeorge.Repositry.IGeneral;
using PenaltyCalculationPeterGeorge.Repositry.IManger;

namespace PenaltyCalculationPeterGeorge.Repositry.Manger
{
    public class CountrySQL : General<Country> , ICountry
    {

        public CountrySQL(DBContext _db) : base(_db)
        {

        }

        
    }
}
