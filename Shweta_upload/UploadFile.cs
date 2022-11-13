using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FileUpload

{
    class program
    {
    static void Main(string[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "http://the-internet.herokuapp.com/upload";
            Thread.Sleep(1000);
            driver.FindElement(By.Id("file-upload")).SendKeys("/Users/shweta.gajjar/Documents//Test1");
            driver.FindElement(By.Id("file-submit")).Click();

            String actual_message = driver.FindElement(By.Id("uploaded-files")).Text;
                if (actual_message == "Test1")
                    Console.Write("Success");
                else
                 {
                    Console.Write("Failure");
                 }
        }
    }
}
    
