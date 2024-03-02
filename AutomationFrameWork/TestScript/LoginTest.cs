using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomationFrameWork.PageObject;
using AutomationFrameWork.Configuration;

namespace AutomationFrameWork.TestScript
{
    [TestClass]
    public class LoginTest:ObjectRepoistry
    {
        public LoginTest()
        {
        }
        public By username => By.XPath("//input[contains(@name,'username')]");
        public By Pasword => By.XPath("//input[contains(@name,'password')]");
        public By login => By.XPath("//button[contains(@type,'submit')]");

        [TestMethod]
        public void LoginTestMethod()
        {
            Page page = new Page();
            AppConfigReader.GetBrowser();
            ObjectRepoistry.driver.Navigate().GoToUrl(AppConfigReader.getUrl());
            try
            {
                ObjectRepoistry.driver.Manage().Window.Maximize();
            }
            catch
            {

            }
           page.EnterText(username,AppConfigReader.GetUsername());
            page.EnterText(Pasword,AppConfigReader.GetPassword());
            Thread.Sleep(1000);
            page.ClickElement(login);
            ObjectRepoistry.driver.Dispose();
            ObjectRepoistry.driver.Quit();


        }
        
    } 
}
        

    

