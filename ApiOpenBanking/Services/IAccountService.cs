using ApiOpenBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Services
{
    public interface IAccountService 
    {
        Account GetAccountPF(string CPF);

        List<Account> GetAllAccountsPF();


    }
}
