using Hectre.HarvestManagement.Core.Models;

namespace Hectre.HarvestManagement.Core.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<Harvest> HarvestRepository { get; }
        IGenericRepository<Timesheet> TimesheetRepository { get; }
        IGenericRepository<Orchard> OrchardRepository { get; }

        public Task SaveAsync();
    }
}

