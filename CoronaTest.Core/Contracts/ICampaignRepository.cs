using CoronaTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoronaTest.Core.Contracts
{
    public interface ICampaignRepository
    {
        Task AddRangeAsync(IEnumerable<Campaign> campaigns);
    }
}
