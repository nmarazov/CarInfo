using Data.Contracts;

namespace Data
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly ICarInfoDbContext context;

        public UnitOfWork(ICarInfoDbContext context)
        {
            this.context = context;
        }

        public void Commit()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}
