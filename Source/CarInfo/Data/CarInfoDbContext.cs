using System.Data.Entity;
using Data.Contracts;
using Models;

namespace Data
{
    public class CarInfoDbContext : DbContext, ICarInfoDbContext
    {
        public CarInfoDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CarInfoDbContext>());
        }

        public IDbSet<Driver> Drivers { get; set; }

        public IDbSet<Car> Cars { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
