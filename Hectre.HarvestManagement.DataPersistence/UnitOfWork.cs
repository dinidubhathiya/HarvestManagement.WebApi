using Hectre.HarvestManagement.Core.Interfaces;
using Hectre.HarvestManagement.Core.Models;

namespace Hectre.HarvestManagement.DataPersistence
{
    public class UnitOfWork: IUnitOfWork
    {
        private ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
        }

        private IGenericRepository<Harvest> harvestRepository;
        private IGenericRepository<Timesheet> timesheetRepository;
        private IGenericRepository<Orchard> orchardRepository;

        public IGenericRepository<Harvest> HarvestRepository
        {
            get
            {

                if (this.harvestRepository == null)
                {
                    this.harvestRepository = new GenericRepository<Harvest>(context);
                }
                return harvestRepository;
            }
        }

        public IGenericRepository<Timesheet> TimesheetRepository
        {
            get
            {

                if (this.timesheetRepository == null)
                {
                    this.timesheetRepository = new GenericRepository<Timesheet>(context);
                }
                return timesheetRepository;
            }
        }

        public IGenericRepository<Orchard> OrchardRepository
        {
            get
            {

                if (this.orchardRepository == null)
                {
                    this.orchardRepository = new GenericRepository<Orchard>(context);
                }
                return orchardRepository;
            }
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}


