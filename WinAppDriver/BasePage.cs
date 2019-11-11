using OpenQA.Selenium.Appium.Windows;

namespace WinAppDriver
{
    public class BasePage
    {
        public static WindowsDriver<WindowsElement> WindowsDriver { get; set; }
        public static bool isCalculatorLaunched = false;
    }
}
