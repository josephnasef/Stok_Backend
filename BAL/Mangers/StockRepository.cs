using BAL.Concert;
using BAL.interfaces;
using DataAL.Context;
using DataAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Mangers
{
    public class StockRepository : Repository<Stock>, IStockRepository
    {
        public StockRepository(MyDbContext BloggerContext) : base(BloggerContext)
        {
        }
    }
}
