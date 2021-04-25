using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualFund.Models
{
    public class MutualFundDb : IMutualFundDb
    {
        public static List<MutualFundDetail> mutualFundDetailList = new List<MutualFundDetail> {
            new MutualFundDetail { MutualFundId = 1, MutualFundName = "Axis Mutual Funds",MutualFundValue=100},
            new MutualFundDetail { MutualFundId = 2, MutualFundName = "Reliance Mutual Funds", MutualFundValue = 200 },
            new MutualFundDetail { MutualFundId = 3, MutualFundName = "SBI Mutual Funds", MutualFundValue = 300 },
            new MutualFundDetail { MutualFundId = 4, MutualFundName = "ICICI Mutual Funds", MutualFundValue = 400 },
            new MutualFundDetail { MutualFundId = 5, MutualFundName = "UTI Mutual Funds", MutualFundValue = 500 }
            };

        public MutualFundDetail MutualFundNav(string mutualFundName)
        {
            return mutualFundDetailList.FirstOrDefault(c => c.MutualFundName.ToLower() == mutualFundName.ToLower());

        }
    }
}
