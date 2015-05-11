using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourNewTaxi.Domain.Entities;

namespace YourNewTaxi.Domain.Abstract
{
    public interface IExecutorRepository
    {
        IQueryable<Executor> Executors { get; }
        void DeleteExecutor(int executorID);
        void SaveExecutor(Executor newExecutor);
        void UpdateExecutor(Executor existingExecutor);
    }
}
