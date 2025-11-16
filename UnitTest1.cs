using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace WebDriverTests
{
    public class SearchTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()

        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");             // Run Chrome without GUI
            options.AddArgument("--no-sandbox");           // Required for Linux servers
            options.AddArgument("--disable-dev-shm-usage"); // Prevents memory issues in Docker/Linux
            driver = new ChromeDriver();
            Console.WriteLine("test ");
        }

        [Test]
        public void SearchValidation()

        {
            // driver.Navigate().GoToUrl("https://www.google.com/");
            // driver.Manage().Window.Maximize();
            // IWebElement searchBox = driver.FindElement(By.Name("q"));
            // string searchText = "Automation ";
            // searchBox.SendKeys(searchText);

            // System.Threading.Thread.Sleep(5000);
            // string pageSource = driver.PageSource;
            // Assert.That(pageSource, Does.Contain(searchText), $"Search results do not contain '{searchText}'");
            // Console.WriteLine("assert complete");
            
           // ====================================
        //     driver.Navigate().GoToUrl("https://www.amazon.in/");
        //     driver.Manage().Window.Maximize();
        //     driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //     driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("iphone"+ Keys.Enter);
        //     driver.FindElement(By.XPath("//h2[@aria-label='Sponsored Ad - Apple iPhone 15 (128 GB) - Black']")).Click();

        //    var parentWindow = driver.CurrentWindowHandle;

        //    var allWindow = driver.WindowHandles;

        //    foreach(var window in allWindow)
        //     {
        //         if (window != parentWindow)
        //         {
        //             driver.SwitchTo().Window(window);
        //         }
        //     }
        //     driver.FindElement(By.Id("buy-now-button")).Click();
                
        // }

        driver.Navigate().GoToUrl("https://www.facebook.com/r.php?entry_point=login");
        driver.Manage().Window.Maximize();
        IWebElement month = driver.FindElement(By.Id("month"));
        SelectElement selectElement = new SelectElement(month);
        selectElement.SelectByText("Aug");
        
        }

        [TearDown]
        public void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();  // ✅ This line disposes of WebDriver correctly
            }
        }
 
    }
}
 
 

 