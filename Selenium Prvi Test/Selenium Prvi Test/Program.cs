// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumPrviTest
{
    public class Program
    {
        static void Main(string[] args)
        {
          IWebDriver driver=new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com/");

            IWebElement element = driver.FindElement(By.Name("q"));
                element.SendKeys("Selenium");
            driver.Close;

            //IWebElement elementButton = driver.FindElement(By.Name("btnk"));
            //elementButton.Click();
        }
    }
}