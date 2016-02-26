﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sfa.Eds.Das.Web.AcceptanceTests.Test.Features.Sprint1
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Search for a Standard by keyword")]
    public partial class SearchForAStandardByKeywordFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StandardSearch.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Search for a Standard by keyword", "In order to find an apprenticeship as per my needs\r\nAs an employer \r\nI want to be" +
                    " able to search from available Standards", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Verify landing page")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public virtual void VerifyLandingPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify landing page", new string[] {
                        "smoke"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
testRunner.When("I am on Search landing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
testRunner.Then("I should be able to see home page with title as \"Home Page - Employer Apprentices" +
                    "hip Search\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search Standard by keyword")]
        [NUnit.Framework.TestCaseAttribute("Actuarial technician", null)]
        [NUnit.Framework.TestCaseAttribute("Financial Adviser", null)]
        [NUnit.Framework.TestCaseAttribute("software engineer", null)]
        [NUnit.Framework.TestCaseAttribute("manufacturing engineer", null)]
        [NUnit.Framework.TestCaseAttribute("Legal Services", null)]
        [NUnit.Framework.TestCaseAttribute("Designer", null)]
        [NUnit.Framework.TestCaseAttribute("dental nurse", null)]
        [NUnit.Framework.TestCaseAttribute("Electrician", null)]
        [NUnit.Framework.TestCaseAttribute("car mechanic", null)]
        [NUnit.Framework.TestCaseAttribute("Manager", null)]
        public virtual void SearchStandardByKeyword(string jOBROLE, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search Standard by keyword", exampleTags);
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("I am on Search landing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.And(string.Format("I enter keyword \'{0}\' in search box", jOBROLE), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("I click on search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then(string.Format("I should see matching \'{0}\' standards on result page", jOBROLE), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify invalid search")]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.TestCaseAttribute("kdjfdkfjdfk", null)]
        [NUnit.Framework.TestCaseAttribute("1232322", null)]
        public virtual void VerifyInvalidSearch(string jOBROLE, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify invalid search", @__tags);
#line 33
this.ScenarioSetup(scenarioInfo);
#line 34
testRunner.Given("I am on Search landing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
testRunner.And(string.Format("I enter keyword \'{0}\' in search box", jOBROLE), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
testRunner.When("I click on search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
testRunner.Then("I should see message \"Total results found: 0\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate result count")]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.TestCaseAttribute("Actuarial Technician", null)]
        [NUnit.Framework.TestCaseAttribute("Financial Adviser", null)]
        [NUnit.Framework.TestCaseAttribute("software engineer", null)]
        public virtual void ValidateResultCount(string jOBROLE, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate result count", @__tags);
#line 44
this.ScenarioSetup(scenarioInfo);
#line 45
 testRunner.Given("I am on Search landing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.And(string.Format("I enter keyword \'{0}\' in search box", jOBROLE), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.When("I click on search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("I should see standards count on result page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search result Page to have best match")]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.TestCaseAttribute("Mechanical Engineer", null)]
        [NUnit.Framework.TestCaseAttribute("Software Engineer", null)]
        public virtual void SearchResultPageToHaveBestMatch(string keyword, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search result Page to have best match", @__tags);
#line 57
this.ScenarioSetup(scenarioInfo);
#line 58
testRunner.Given("I am on Search landing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
testRunner.When(string.Format("I enter keyword \'{0}\'", keyword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
testRunner.And("I click on search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
testRunner.Then("I should result search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
testRunner.And(string.Format("it should list most best match \'{0}\' on top of the search list", keyword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion