using AccountManager.Api.Controllers;
using AccountManager.Business.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.Tests
{
    public class AccountInfoTest
    {
        private int _accountId;
        private IAccountService _accountService;
        private double _amount;

        [TestInitialize]
        public void Initialize()
        {
            _accountId = 1;
            _amount = 301;
            Mock<IAccountService> accountServiceObj = new Mock<IAccountService>();
            _accountService = accountServiceObj.Object;
        }
        [TestMethod]
        public void Amount_ReturnsZero()
        {
            AccountInfo account = new AccountInfo(_accountId, _accountService);
            Assert.AreEqual(0, account.Amount);
        }
    }
}
