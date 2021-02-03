using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba.Pages
{
    public class VodicPage : BasePage
    {
        public VodicPage(IWebDriver driver) : base(driver) { }

        public VerificationPage GoToVerifyAccount() { 
        ///... xpath 
        ///... xpath 
        }
        public VerificationPage GoToVerifyYourHomeAddress()
        {
            ///... xpath 
            ///... xpath 
        }
        public SettingsPage ChangeSettingsOfYourAccount()
        {
            ///... xpath 
            ///... xpath 
        }
        public AdPage PublishAd()
        {
            ///... xpath 
            ///... xpath 
        }

    }
}
