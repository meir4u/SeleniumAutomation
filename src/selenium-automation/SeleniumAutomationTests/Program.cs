using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeleniumAutomationTests
{
    internal class Program
    {
        private static readonly string url = "https://mdn.github.io/learning-area/html/tables/assessment-finished/planets-data.html";
        private static readonly string fileLocation = "..\\..\\..\\..\\..\\client\\data\\site-data.json";

        static void Main(string[] args)
        {
            var dictionaryData = new Dictionary<string, int>();
            var dictionaryDataOrdered = new Dictionary<string, int>();            

            using var driver = new ChromeDriver();

            
            driver.Navigate().GoToUrl(url);

            var elements = driver.FindElements(By.XPath("//tbody/tr"));

            foreach ( var element in elements )
            {
                var name = element.FindElement(By.XPath("./th[@scope='row' and not(@colspan)]"));
                var diameter = element.FindElement(By.XPath("./td[2]"));


                try
                {
                    dictionaryData.Add(name.Text, (int)double.Parse(diameter.Text));

                }catch( Exception ex )
                {
                    Console.WriteLine(ex.Message);
                }
            }

            driver.Close();

            dictionaryDataOrdered = dictionaryData.OrderByDescending( d => d.Value ).ToDictionary(x=>x.Key, x => x.Value);

            var jsonData = JsonConvert.SerializeObject(dictionaryDataOrdered);
            
            System.IO.File.WriteAllText(fileLocation, jsonData.ToString());

            Console.WriteLine("Application End");


        }
    }
}
