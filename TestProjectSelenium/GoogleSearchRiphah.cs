using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestProjectSelenium
{
    [TestClass]
    public class GoogleSearchRiphah
    {
        [TestMethod]
        public void Test_Search_Riphah_International_University()
        {
            int waitingTime = 2000;
            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");

            IWebDriver webDriver = new ChromeDriver();

            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://www.google.com.pk");

            Thread.Sleep(waitingTime);

            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchBar).SendKeys("riphah university");

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchButton).Click();

            webDriver.Quit();
        }
    }
}