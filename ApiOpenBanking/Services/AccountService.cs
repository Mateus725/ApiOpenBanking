using ApiOpenBanking.Data;
using ApiOpenBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Services
{
    public class AccountService : IAccountService
    {
        DataContext _dataContext;

        public AccountService(DataContext dataContext) { _dataContext = dataContext; }

        public Account GetAccountPF(string CPF)
        {
            try
            {
                return _dataContext.Accounts.Where(acc => acc.CPF == CPF).First();
            }
            catch
            {
                return null;
            }
        }

        public List<Account> GetAllAccountsPF()
        {
            try
            {
                return _dataContext.Accounts.ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
