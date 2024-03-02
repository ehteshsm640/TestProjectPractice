using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace AutomationFrameWork.Helper.BrowserHelper
{
    internal class BrosewrLoad
    {
        public static IWebDriver CreateChromeDriver()
        {

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            IWebDriver driver = new ChromeDriver(chromeOptions);
            return driver;
        }
        public static IWebDriver CreateFirefoxDriver()
        {

            FirefoxOptions firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArgument("--start-maximized");

            IWebDriver driver = new FirefoxDriver(firefoxOptions);
            return driver;
        }
        public static IWebDriver CreateEdgeDriver()
        {
            EdgeOptions edgeOptions = new EdgeOptions();
            // Add any specific options if needed

            IWebDriver driver = new EdgeDriver(edgeOptions);
            return driver;
        }
        public static IWebDriver CreateSafariDriver()
        {
            SafariOptions safariOptions = new SafariOptions();
            // Add any specific options if needed

            IWebDriver driver = new SafariDriver(safariOptions);
            return driver;
        }

        public static IWebDriver CreateInternetExplorerDriver()
        {
            InternetExplorerOptions ieOptions = new InternetExplorerOptions();
            IWebDriver driver = new InternetExplorerDriver(ieOptions);
            return driver;
        }

    }
}
/*
 case chrome:
Iwebdriver driver;
driver =new 
 */