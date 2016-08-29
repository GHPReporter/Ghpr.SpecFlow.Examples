using System;
using System.Diagnostics;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Ghpr.SpecFlow.Examples.Steps
{
    [Binding]
    public class BasicsSteps
    {
        private int _firstNumber;
        private int _sum;

        [Given(@"I have number (.*)")]
        public void GivenIHaveNumber(int p0)
        {
            Trace.WriteLine("TRACE: I have some number...");
            Console.WriteLine("CONSOLE: I have some number...");
            Debug.WriteLine("DEBUG: I have some number...");
            _firstNumber = p0;
            _sum = p0;
        }

        [When(@"I add (.*)")]
        public void WhenIAdd(int p0)
        {
            _sum += p0;
        }

        [Then(@"the result sum should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.AreEqual(p0, _sum);
        }
    }
}
