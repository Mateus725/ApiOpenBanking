using ApiOpenBanking.Data;
using ApiOpenBanking.Models;
using ApiOpenBanking.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountPJController : Controller
    {
        AccountService _accountService;

        public AccountPJController(DataContext dataContext) { _accountService = new AccountService(dataContext); }

        [HttpGet]
        public IEnumerable<AccountPJ> GetAllAccounts()
        {
            return _accountService.GetAllAccountsPJ();
        }

        [Route("{cnpj}")]
        [HttpGet]
        public AccountPJ GetAccountPJ(string cnpj)
        {
            return _accountService.GetAccountPJ(cnpj);
        }

    }
    
}
