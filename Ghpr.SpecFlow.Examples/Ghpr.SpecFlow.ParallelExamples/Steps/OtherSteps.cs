using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Ghpr.SpecFlow.ParallelExamples.Steps
{
    [Binding]
    public class OtherSteps
    {
        private int _first;
        private int _abs;

        [Given(@"I take number (.*)")]
        public void GivenITakeNumber(int p0)
        {
            Thread.Sleep(100);
            _first = p0;
        }
        
        [When(@"I calculate number's absolute value")]
        public void WhenICalculateNumberSAbsoluteValue()
        {
            Thread.Sleep(100);
            Console.WriteLine("Calculating abs...");
            _abs = Math.Abs(_first);
            Console.WriteLine("Done.");
        }
        
        [Then(@"the result value should be (.*)")]
        public void ThenTheResultValueShouldBe(int p0)
        {
            Thread.Sleep(100);
            Assert.AreEqual(p0, _abs);
        }

        [Then(@"scenario fails by assert")]
        public void ThenScenarioFailsByAssert()
        {
            Thread.Sleep(100);
            Assert.Fail("Some failure");
        }

        [Then(@"scenario fails with exception")]
        public void ThenScenarioFailsWithException()
        {
            Thread.Sleep(100);
            throw new Exception("Some exception");
        }

        [When(@"this scenario fails by assert")]
        public void WhenScenarioFailsByAssert()
        {
            Thread.Sleep(100);
            Assert.Fail("Some failure");
        }

        [When(@"this scenario fails with exception")]
        public void WhenScenarioFailsWithException()
        {
            Thread.Sleep(100);
            throw new Exception("Some exception");
        }

        [Then(@"this step should be skipped")]
        public void Skipped()
        {
            Thread.Sleep(100);
            Console.WriteLine("Console: skipped step");
        }
    }
}
