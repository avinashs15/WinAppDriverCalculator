using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WinAppDriver.Hooks;
using WinAppDriver.PageObjects;

namespace WinAppDriver.StepDefinations
{
    [Binding]
    public class CalculatorAdditionSteps
    {
        private static TestInitialise testInitialise;
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
            NumberPad numberPad = new NumberPad();
            numberPad.PressNumber(p0.ToString());
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            OperatorsPad operatorsPad = new OperatorsPad();
            operatorsPad.EnterOperator("Plus");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            CommonObjects commonObjects = new CommonObjects();
            string result = commonObjects.GetResult();
            Assert.IsTrue(result.Contains(p0.ToString()));
        }

        [Given(@"I press add")]
        public void GivenIPressAdd()
        {
            OperatorsPad operatorsPad = new OperatorsPad();
            operatorsPad.EnterOperator("Plus");
        }

        [Given(@"I click Equals")]
        public void GivenIClickEquals()
        {
            OperatorsPad operatorsPad = new OperatorsPad();
            operatorsPad.EnterOperator("Equals");
        }

        [Then(@"I close the calculator")]
        public void ThenICloseTheCalculator()
        {
            testInitialise.CloseCalculator();
        }
    }
}
