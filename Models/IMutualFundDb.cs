using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualFund.Models
{
   public interface IMutualFundDb
    {
        MutualFundDetail MutualFundNav(string mutualFundName);
    }
}
