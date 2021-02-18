using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCRUD
{
    interface IStartupTask
    {
        Task Execute(IServiceProvider serviceProvider);
    }
}
