using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace selenium_webdriver_test_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //chrome driverの呼び出し
            IWebDriver chrome = new ChromeDriver();
            SearchGoogle(chrome);


        }
        //処理内容
        static void SearchGoogle(IWebDriver _webdriver)
        {
            _webdriver.Url = "https://www.google.co.jp";
            IWebElement element = _webdriver.FindElement(By.Name("q"));
            element.SendKeys("Hello WebDriver!!C#!!");
            element.Submit();
            while(true){
                Thread.Sleep(TimeSpan.FromSeconds(10));
            }
            //webDriver.Quit();
        }
    }
}
