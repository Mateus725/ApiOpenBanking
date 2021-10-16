using ApiOpenBanking.Data;
using ApiOpenBanking.Models;
using ApiOpenBanking.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOpenBanking.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        AccountService _accountService;

        public AccountController(DataContext dataContext) { _accountService = new AccountService(dataContext); }
       
        [HttpGet]
        public IEnumerable<Account> GetAllAccounts()
        {
            return _accountService.GetAllAccountsPF();
        }

        [Route("{cpf}")]
        [HttpGet]
        public Account GetAccount(string cpf)
        {
            return _accountService.GetAccountPF(cpf);
        }
        
    }
}
