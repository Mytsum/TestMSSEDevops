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
        [TestMethod]
        public void Test_Value_Check()
        {
            string searchText = "ali msse riphah";
            int waitingTime = 2000;
            By textField = By.Name("inp");
            By checkButton = By.Name("chk");
            By outputField = By.Id("txtOutput");

            IWebDriver webDriver = new ChromeDriver();

            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://test-mssedevopssp23.azurewebsites.net/");

            Thread.Sleep(waitingTime);

            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(textField).SendKeys(searchText);

            Thread.Sleep(waitingTime);

            webDriver.FindElement(checkButton).Click();

            Thread.Sleep(waitingTime);

            var actualResultText = webDriver.FindElement(outputField);

            Assert.IsTrue(actualResultText.Text.Equals(searchText));

            webDriver.Quit();
        }
    }
}