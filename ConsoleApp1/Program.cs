using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Webdriver
{
    class Program
    {
        public static void Main(string[] args)
        {
            IWebDriver gcdriver = new ChromeDriver(@"C:\Libraries\");
            gcdriver.Url = "http://automationpractice.com";
            var popular = gcdriver.FindElements(By.Id("homefeatured"))[0];
            popular.Click();
            var pdk = gcdriver.FindElement(By.XPath("//*[@id='homefeatured']/li[2]/div/div[2]/div[2]/a[1]"));
            pdk.Click();

            Thread.Sleep(1500);

            var pdk1 = gcdriver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span"));
            pdk1.Click();

            Thread.Sleep(1000);

            var pdk2 = gcdriver.FindElement(By.XPath("//*[@id='homefeatured']/li[3]/div/div[2]/div[2]/a[2]"));
            pdk2.Click();          
            var pdk3 = gcdriver.FindElement(By.XPath("//*[@id='quantity_wanted_p']/a[2]"));
            pdk3.Click();
            pdk3.Click();
            var pdk4 = gcdriver.FindElement(By.XPath("//*[@id='add_to_cart']/button"));
            pdk4.Click();

            Thread.Sleep(1500);

            var pdk5 = gcdriver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span"));
            pdk5.Click();

            Thread.Sleep(1000);

            var pdk6 = gcdriver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[3]/a"));
            pdk6.Click();
            
            var pdk7 = gcdriver.FindElement(By.XPath("//*[@id='selectProductSort']/option[2]"));
            pdk7.Click();

            var pdk8 = gcdriver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[2]/div[2]/a[1]"));
            pdk8.Click();

            Thread.Sleep(1500);

            var p1 = gcdriver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span"));
            p1.Click();

            var p2 = gcdriver.FindElement(By.XPath("//*[@id='header']/div[3]/div/div/div[3]/div/a"));
            p2.Click();

            var p3 = gcdriver.FindElement(By.XPath("//*[@id='cart_quantity_up_1_1_0_0']"));
            p3.Click();
            p3.Click();
            p3.Click();
            p3.Click();

            var p4 = gcdriver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]"));
            p4.Click();
        }
    }
}
