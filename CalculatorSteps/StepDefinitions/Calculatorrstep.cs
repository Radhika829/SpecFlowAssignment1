using SpecAss1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSteps;
using Xunit;

namespace CalculatorSteps.StepDefinitions
{
    [Binding]
    public class CalculatorSteps
    {
        private CalculatorOp calculator;
        private int result;

        [Given(@"I have entered (\d+) into the calculator", "unique_tag")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator = new CalculatorOp();
            calculator.EnterNumber(number);
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            result = calculator.Multiply();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            result = calculator.Subtract();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            result = calculator.Divide();
        }

        [Then(@"the result should be (\d+) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.Equal(expectedResult, result);
        }
    }
}
