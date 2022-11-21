using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaty
{
    public class KeycloakPage
    {
        IWebDriver driver;

        public KeycloakPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By userName = By.Id("username");
        public By password = By.Id("password");

        public void fillCredentials(string login, string passwordInput)
        {
            driver.FindElement(userName).SendKeys(login);
            driver.FindElement(password).SendKeys(passwordInput);
        }
    }
}
