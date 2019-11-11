using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDriver.PageObjects
{
    public class CommonObjects : BasePage
    {
        WindowsElement resultDisplay => WindowsDriver.FindElementByAccessibilityId("CalculatorResults");
        WindowsElement btnChangeCalculatorView => WindowsDriver.FindElementByAccessibilityId("TogglePaneButton");
        WindowsElement calculatorViewList => WindowsDriver.FindElementByAccessibilityId("MenuItemsHost");
        public string GetResult()
        {
            Console.WriteLine(BasePage.WindowsDriver);
            return resultDisplay.Text;
        }

        public void ChangeCalculatorView(string view) 
        {
            btnChangeCalculatorView.Click();
            calculatorViewList.FindElementByAccessibilityId(view).Click();
        }
    }
}
