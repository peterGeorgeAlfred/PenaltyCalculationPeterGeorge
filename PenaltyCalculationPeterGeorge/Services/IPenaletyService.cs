namespace PenaltyCalculationPeterGeorge.Services
{
    public interface IPenaletyService
    {
        Task<int> GetPenality(int valuePerDay, DateTime startDate, DateTime endDate, int countryID);
    }
}
