using BAL.Mangers;
using DataAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UOW
{
    public class UnitOfWork
    {
        private readonly MyDbContext Context;
        public UnitOfWork(MyDbContext context)
        {
            Context = context;
        }
    }
}
