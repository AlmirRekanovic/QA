using NUnit.Framework;
using proba.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba.Tests
{   
   [TestFixture]
    public class Registration : TestBase
    {
        [Test]
        public void VerifyThatUserCanRegister() {

            LoginPage loginPage = basePage.OpenLoginForm();
            RegistrationPage registerPage = loginPage.SelectRegisterOption();
            registerPage.RegisterUser("kollidsfds@sda.com", "Password!", "yyuyuyyuuyrtyu");
            registerPage.VerifyThatUserIsRegistered("yyuyuyyuuyrtyu");
        }
    }
}
