using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFrameWork.Configuration
{
    public  class ObjectRepoistry
    {
        public static IWebDriver driver { get; set; }

        protected  ObjectRepoistry() { }
    }
}
