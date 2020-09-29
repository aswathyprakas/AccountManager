using AccountManager.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AccountManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public class AccountInfo
        {
            private readonly int _accountId;
            private readonly IAccountService _accountService;
            public AccountInfo(int accountId, IAccountService accountService)
            {
                _accountId = accountId;
                _accountService = accountService;
            }
            public double Amount { get; private set; }
            public async Task RefreshAmount()
            {
                Amount = await _accountService.GetAccountAmount(_accountId);
            }
        }
    }
}
