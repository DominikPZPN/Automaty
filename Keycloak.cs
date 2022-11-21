using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Automaty
{
    public class Keycloak
    {
        IWebDriver driver = new ChromeDriver();


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Logowanie()
        {
            KeycloakPage keycloakPage = new KeycloakPage(driver);

            driver.Navigate().GoToUrl("https://logintest.laczynaspilka.pl/auth/realms/PZPN/protocol/openid-connect/auth?client_id=KLUBY_BACKEND&redirect_uri=https%3A%2F%2Fkluby-test.pzpn.pl");
            keycloakPage.fillCredentials("sed_1@yopmail.com", "Haslo");

        }

        [Test]
        public void Rejestracja()
        {
        }
    }
}