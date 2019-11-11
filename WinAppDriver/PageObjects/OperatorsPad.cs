using OpenQA.Selenium.Appium.Windows;

namespace WinAppDriver.PageObjects
{
    public class OperatorsPad : BasePage
    {
        WindowsElement standardOperator => WindowsDriver.FindElementByAccessibilityId("StandardOperators");

        public void EnterOperator(string operatorName) 
        {
            WindowsElement currentOperator = (WindowsElement)standardOperator.FindElementByXPath("//Button[contains(@Name,\"" + operatorName + "\")]");
            currentOperator.Click();
        }

        public void EnterAddOperator()
        { 
            
        }
    }
}
