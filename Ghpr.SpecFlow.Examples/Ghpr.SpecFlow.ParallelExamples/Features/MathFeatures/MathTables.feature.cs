﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Ghpr.SpecFlow.ParallelExamples.Features.MathFeatures
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("MathTables")]
    public partial class MathTablesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MathTables.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MathTables", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add two numbers from table")]
        [NUnit.Framework.CategoryAttribute("Table")]
        [NUnit.Framework.TestCaseAttribute("1", "2", "3", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "1", "3", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "2", "4", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "3", "5", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "4", "6", new string[0])]
        [NUnit.Framework.TestCaseAttribute("3", "2", "5", new string[0])]
        [NUnit.Framework.TestCaseAttribute("4", "2", "6", new string[0])]
        [NUnit.Framework.TestCaseAttribute("5", "2", "7", new string[0])]
        [NUnit.Framework.TestCaseAttribute("6", "2", "8", new string[0])]
        [NUnit.Framework.TestCaseAttribute("22", "20", "42", new string[0])]
        [NUnit.Framework.TestCaseAttribute("23", "10", "48", new string[0])]
        [NUnit.Framework.TestCaseAttribute("22", "20", "43", new string[0])]
        [NUnit.Framework.TestCaseAttribute("23", "10", "44", new string[0])]
        public virtual void AddTwoNumbersFromTable(string number1, string number2, string sum, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Table"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two numbers from table", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given(string.Format("I have number \'{0}\'", number1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When(string.Format("I add \'{0}\'", number2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("the result sum should be \'{0}\'", sum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
