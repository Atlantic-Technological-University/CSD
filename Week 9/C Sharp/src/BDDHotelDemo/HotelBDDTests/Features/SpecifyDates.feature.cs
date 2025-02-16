﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HotelBDDTests.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SpecifyDatesFeature : object, Xunit.IClassFixture<SpecifyDatesFeature.FixtureData>, Xunit.IAsyncLifetime
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Specify dates", "A simple set of scenarios for specifying dates for a stay at a hotel.", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SpecifyDates.feature"
#line hidden
        
        public SpecifyDatesFeature(SpecifyDatesFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
        }
        
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
        {
            await this.TestInitializeAsync();
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
        {
            await this.TestTearDownAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User enters a checkout date that is before a valid checkin date")]
        [Xunit.TraitAttribute("FeatureTitle", "Specify dates")]
        [Xunit.TraitAttribute("Description", "User enters a checkout date that is before a valid checkin date")]
        public async System.Threading.Tasks.Task UserEntersACheckoutDateThatIsBeforeAValidCheckinDate()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("User enters a checkout date that is before a valid checkin date", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 19
 await testRunner.GivenAsync("the user is on the hotel booking page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 23
 await testRunner.WhenAsync("the user specifies a checkIn date of \"17/05/2025\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 24
 await testRunner.AndAsync("the user specifies a checkOut date of \"16/05/2025\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 30
 await testRunner.ThenAsync("generate the error message \"Check-out date must be after check-in date.\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 31
 await testRunner.AndAsync("disable the search", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="User enters a checkout date that is after a valid checkin date")]
        [Xunit.TraitAttribute("FeatureTitle", "Specify dates")]
        [Xunit.TraitAttribute("Description", "User enters a checkout date that is after a valid checkin date")]
        public async System.Threading.Tasks.Task UserEntersACheckoutDateThatIsAfterAValidCheckinDate()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("User enters a checkout date that is after a valid checkin date", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 34
await testRunner.GivenAsync("the user is on the hotel booking page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 35
await testRunner.WhenAsync("the user specifies a checkIn date of \"17/05/2025\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 36
await testRunner.AndAsync("the user specifies a checkOut date of \"18/05/2025\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 38
await testRunner.ThenAsync("enable the search", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="User enters various dates")]
        [Xunit.TraitAttribute("FeatureTitle", "Specify dates")]
        [Xunit.TraitAttribute("Description", "User enters various dates")]
        [Xunit.InlineDataAttribute("12/12/2025", "13/12/2025", "true", new string[0])]
        [Xunit.InlineDataAttribute("12/12/2025", "12/12/2025", "false", new string[0])]
        [Xunit.InlineDataAttribute("13/06/2025", "12/06/2025", "false", new string[0])]
        public async System.Threading.Tasks.Task UserEntersVariousDates(string checkIn, string checkOut, string enableSearch, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("checkIn", checkIn);
            argumentsOfScenario.Add("checkOut", checkOut);
            argumentsOfScenario.Add("enableSearch", enableSearch);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("User enters various dates", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 43
  await testRunner.GivenAsync("the user is on the hotel booking page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 44
  await testRunner.WhenAsync(string.Format("the user specifies a checkIn date of \'{0}\'", checkIn), ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 45
  await testRunner.AndAsync(string.Format("the user specifies a checkOut date of \'{0}\'", checkOut), ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 47
  await testRunner.ThenAsync(string.Format("the IsEnabled state search should be \'{0}\'", enableSearch), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : object, Xunit.IAsyncLifetime
        {
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
            {
                await SpecifyDatesFeature.FeatureSetupAsync();
            }
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
            {
                await SpecifyDatesFeature.FeatureTearDownAsync();
            }
        }
    }
}
#pragma warning restore
#endregion
