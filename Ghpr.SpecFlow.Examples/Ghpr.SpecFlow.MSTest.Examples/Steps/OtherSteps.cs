using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Ghpr.SpecFlow.MSTest.Examples.Steps
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

        [Then(@"scenario fails by assert")]
        public void ThenScenarioFailsByAssert()
        {
            Assert.Fail("Some failure");
        }

        [Then(@"scenario fails with exception")]
        public void ThenScenarioFailsWithException()
        {
            throw new Exception("Some exception");
        }

        [When(@"this scenario fails by assert")]
        public void WhenScenarioFailsByAssert()
        {
            Assert.Fail("Some failure");
        }

        [When(@"this scenario fails with exception")]
        public void WhenScenarioFailsWithException()
        {
            throw new Exception("Some exception");
        }

        [Then(@"this step should be skipped")]
        public void Skipped()
        {
            Console.WriteLine("Console: skipped step");
        }
    }
}
