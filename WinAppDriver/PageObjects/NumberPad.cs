using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDriver.PageObjects
{
    public class NumberPad : BasePage
    {
        WindowsElement numberPad => WindowsDriver.FindElementByAccessibilityId("NumberPad");
        WindowsElement zero => (WindowsElement)numberPad.FindElementByAccessibilityId("num0Button");

        public void PressNumber(string number) 
        { 
            WindowsElement currentNumber = (WindowsElement)numberPad.FindElementByXPath("//Button[@AutomationId=\"num" + number +"Button\"]");
            currentNumber.Click();
        }
    }
}
