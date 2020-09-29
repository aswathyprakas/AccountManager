using AccountManager.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.Business.Services
{
    public class AccountService : IAccountService
    {
        public async Task<double> GetAccountAmount(int accountId)
        {
            var amount = accountId + 300;
            return await Task.FromResult<double>(amount);
        }
    }
}
