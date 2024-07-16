using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomationTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var url = "";
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("");
            driver.FindElement(By.XPath("//*[@id='editor']"));


            Console.WriteLine("Application End");
        }
    }
}
