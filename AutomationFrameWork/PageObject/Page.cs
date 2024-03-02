using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationFrameWork.Configuration;
namespace AutomationFrameWork.PageObject
{
    internal partial  class Page : ObjectRepoistry
    {
        public void EnterText(By element, string elementData)
        {
            Thread.Sleep(1000);
            IWebElement webElement = driver.FindElement(element);
            if (webElement.Enabled)
            {
                webElement.SendKeys(elementData);
                //webElement.SendKeys(Keys.Enter);
            }

        }
        public void ClickElement(By Element)
        {
            Thread.Sleep(1000);
            IWebElement element = driver.FindElement(Element);
            if (element.Enabled)
            {
                element.Click();
            }
            
        }

    }
}