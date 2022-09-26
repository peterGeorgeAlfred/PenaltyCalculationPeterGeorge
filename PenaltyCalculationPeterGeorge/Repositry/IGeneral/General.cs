using Microsoft.EntityFrameworkCore;
using PenaltyCalculationPeterGeorge.Context;

namespace PenaltyCalculationPeterGeorge.Repositry.IGeneral
{
    public abstract class General<T> : IGeneral<T> where T : class

    {
        private readonly DBContext db;


        public General(DBContext _db)
        {
            db = _db;
        }
        public virtual async Task<T> ADD(T addedItem)
        {

            try
            {
                if (addedItem == null)
                    return null;
                await db.AddAsync<T>(addedItem);
                await db.SaveChangesAsync();
                return addedItem;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error When Add Item");
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public virtual async Task<T> Delete(int id)
        {
            T t = await GetById(id);
            try
            {
                if (t == null)
                    return null;

                db.Set<T>().Remove(t);
                await db.SaveChangesAsync();
                return t;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(".............. EX on Deleting ..............");
                return null;
            }
        }

        public virtual async Task<List<T>> GetAll()
        {

            return await db.Set<T>().ToListAsync();

        }

        public virtual async Task<T> GetById(int id)
        {

            var result = await db.Set<T>().FindAsync(id);
            return result;
        }

        public virtual async Task<T> Update(T UpdatedItem)
        {
            if (UpdatedItem == null)
                return null;
            db.Set<T>().Update(UpdatedItem);
            await db.SaveChangesAsync();
            return UpdatedItem;
        }
    }
}
