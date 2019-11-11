using OpenQA.Selenium.Appium.Windows;

namespace WinAppDriver.PageObjects
{
    public class CommonObjects : BasePage
    {
        WindowsElement resultDisplay => WindowsDriver.FindElementByAccessibilityId("CalculatorResults");
        WindowsElement btnChangeCalculatorView => WindowsDriver.FindElementByAccessibilityId("TogglePaneButton");
        WindowsElement calculatorViewList => WindowsDriver.FindElementByAccessibilityId("MenuItemsHost");
        public string GetResult()
        {            
            return resultDisplay.Text;
        }

        public void ChangeCalculatorView(string view) 
        {
            btnChangeCalculatorView.Click();
            calculatorViewList.FindElementByAccessibilityId(view).Click();
        }
    }
}
