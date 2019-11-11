using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WinAppDriver.Hooks
{
    [Binding]
    public class TestInitialise
    {
        private WindowsDriver<WindowsElement> session;
        [BeforeTestRun]
        public static void TestSetup()
        {
            Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");           
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\DataDump");
        }

        public void StartCalculator()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "WindowsPC");
            capabilities.SetCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            Thread.Sleep(5000);
            session = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), capabilities);
            BasePage.WindowsDriver = session;
            BasePage.WindowsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            BasePage.isCalculatorLaunched = true;
        }

        public void CloseCalculator()
        {
            BasePage.WindowsDriver.CloseApp();
            BasePage.WindowsDriver.Dispose();
        }

    }
}
