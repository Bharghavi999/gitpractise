using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace gitpractise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com");

            driver.Manage().Window.Maximize();

            IWebElement search = driver.FindElement(By.Name("q"));

            //IWebElement find = driver.FindElement(By.XPath("//div[@class='wM6W7d']//span[1]"));

            search.SendKeys("Selenium");

            search.Submit();

            Thread.Sleep(3000);

            driver.Close();

        }
    }

}

