using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Ghpr.SpecFlow.Examples.Steps
{
    [Binding]
    public class OtherSteps
    {
        private int _first;
        private int _abs;

        [Given(@"I take number (.*)")]
        public void GivenITakeNumber(int p0)
        {
            _first = p0;
        }
        
        [When(@"I calculate number's absolute value")]
        public void WhenICalculateNumberSAbsoluteValue()
        {
            Console.WriteLine("Calculating abs...");
            _abs = Math.Abs(_first);
            Console.WriteLine("Done.");
        }
        
        [Then(@"the result value should be (.*)")]
        public void ThenTheResultValueShouldBe(int p0)
        {
            Assert.AreEqual(p0, _abs);
        }
    }
}
