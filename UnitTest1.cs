using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




namespace WebDriverTests
{
    public class SearchTest
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
    
        {
            driver = new ChromeDriver();
            Console.WriteLine("test ");
        }

        [Test]
        public void SearchValidation()
                
        {   
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            string searchText = "Automation ";
            searchBox.SendKeys(searchText);

            System.Threading.Thread.Sleep(5000);
            string pageSource = driver.PageSource;
            Assert.That(pageSource,Does.Contain(searchText), $"Search results do not contain '{searchText}'");
            Console.WriteLine("assert complete");
    //test dkdsks
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
 