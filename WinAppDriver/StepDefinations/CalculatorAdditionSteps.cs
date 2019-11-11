using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WinAppDriver.Hooks;
using WinAppDriver.PageObjects;

namespace WinAppDriver.StepDefinations
{
    [Binding]
    public class CalculatorAdditionSteps
    {
        private static TestInitialise testInitialise;
        private static OperatorsPad operatorsPad;
        private static NumberPad numberPad;
        private static CommonObjects commonObjects;

        [Given(@"Launch calculator Application")]
        public void GivenLaunchCalculatorApplication()
        {
            if (!BasePage.isCalculatorLaunched)
            {
                testInitialise = new TestInitialise();
                testInitialise.StartCalculator();
            }
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            numberPad = new NumberPad();
            numberPad.PressNumber(p0.ToString());
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            operatorsPad = new OperatorsPad();
            operatorsPad.EnterOperator("Plus");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            commonObjects = new CommonObjects();
            string result = commonObjects.GetResult();
            Assert.IsTrue(result.Contains(p0.ToString()));
        }

        [Given(@"I press add")]
        public void GivenIPressAdd()
        {
            operatorsPad = new OperatorsPad();
            operatorsPad.EnterOperator("Plus");
        }

        [Given(@"I click Equals")]
        public void GivenIClickEquals()
        {
            operatorsPad = new OperatorsPad();
            operatorsPad.EnterOperator("Equals");
        }

        [Then(@"I close the calculator")]
        public void ThenICloseTheCalculator()
        {
            testInitialise.CloseCalculator();
        }
    }
}
