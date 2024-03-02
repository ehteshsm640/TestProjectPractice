using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AutomationFrameWork;
using AutomationFrameWork.Helper.BrowserHelper;
using OpenQA.Selenium;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.Chrome;
using AutomationFrameWork.Configuration;
using OpenQA.Selenium.DevTools.V118.Debugger;
namespace AutomationFrameWork.Configuration
{
    internal static class AppConfigReader
    {
        static Dictionary<string,string> ConfigData=new();
        public const string ProjectSetup = "ProjectSetup.json";

        public static string ReadJsonData(string FileName,string FieldName)
        {
            string value;
            using (StreamReader reader = new StreamReader(FileName))
            {
                string json=reader.ReadToEnd();
                ConfigData = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                ConfigData.TryGetValue(FieldName, out value);
            }
            return value;

        }

        public static string   getUrl()
        {
            AppConfigKeys.url = ReadJsonData(ProjectSetup,nameof(AppConfigKeys.url));
            return AppConfigKeys.url;
        }
        public static string GetUsername() {
            return ReadJsonData(ProjectSetup, "username");
        }
        public static string GetPassword() {
            return ReadJsonData(ProjectSetup, "Password");
                }
        public static void GetBrowser()
        {
                AppConfigKeys.Browser = ReadJsonData(ProjectSetup, nameof(AppConfigKeys.Browser));

                switch (AppConfigKeys.Browser)
                {
                    case "Chrome":
                        ObjectRepoistry.driver= BrosewrLoad.CreateChromeDriver();
                        break;
                    case "Firefox":
                        ObjectRepoistry.driver=BrosewrLoad.CreateFirefoxDriver();
                        break;
                    case "Safari":
                        ObjectRepoistry.driver = BrosewrLoad.CreateSafariDriver();
                        break;
                //case "Opera":
                // ObjectRepoistry.driver=BrosewrLoad.
                // break;
                    case "InternetExplorer":
                    ObjectRepoistry.driver = BrosewrLoad.CreateInternetExplorerDriver();
                    break;
                    case "Edge":
                    ObjectRepoistry.driver=BrosewrLoad.CreateEdgeDriver();
                    break;
                }

            }
           




        }
        //public static IWebDriver SetBrowser(Browser? Browser)
        //{
        //    IWebDriver driver=new ChromeDriver(BrosewrLoad.CreateChromeDriver());
        //    return driver;
        //}
    }

