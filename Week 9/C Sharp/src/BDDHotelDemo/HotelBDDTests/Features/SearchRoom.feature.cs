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
    public partial class CheckRoomAvailabilityFeature : object, Xunit.IClassFixture<CheckRoomAvailabilityFeature.FixtureData>, Xunit.IAsyncLifetime
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Check room availability", "A simple set of scenarios for searching for an available hotel room on specified " +
                "dates", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SearchRoom.feature"
#line hidden
        
        public CheckRoomAvailabilityFeature(CheckRoomAvailabilityFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
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
        
        [Xunit.SkippableFactAttribute(DisplayName="User enters valid dates")]
        [Xunit.TraitAttribute("FeatureTitle", "Check room availability")]
        [Xunit.TraitAttribute("Description", "User enters valid dates")]
        public async System.Threading.Tasks.Task UserEntersValidDates()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("User enters valid dates", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                global::Reqnroll.Table table1 = new global::Reqnroll.Table(new string[] {
                            "RoomNo",
                            "Type",
                            "MaxOccupancy",
                            "PricePerNight"});
                table1.AddRow(new string[] {
                            "101",
                            "Single",
                            "1",
                            "€140"});
                table1.AddRow(new string[] {
                            "102",
                            "Single",
                            "1",
                            "€140"});
                table1.AddRow(new string[] {
                            "103",
                            "Double",
                            "2",
                            "€180"});
                table1.AddRow(new string[] {
                            "104",
                            "Double",
                            "3",
                            "€180"});
                table1.AddRow(new string[] {
                            "105",
                            "Double",
                            "3",
                            "€180"});
                table1.AddRow(new string[] {
                            "106",
                            "Suite",
                            "4",
                            "€250"});
#line 18
 await testRunner.GivenAsync("the hotel has the following hotel rooms:", ((string)(null)), table1, "Given ");
#line hidden
                global::Reqnroll.Table table2 = new global::Reqnroll.Table(new string[] {
                            "RoomNo",
                            "GuestNo",
                            "CheckInDate",
                            "CheckOutDate"});
                table2.AddRow(new string[] {
                            "101",
                            "2001",
                            "17/05/2025",
                            "20/05/2025"});
                table2.AddRow(new string[] {
                            "103",
                            "2023",
                            "14/05/2025",
                            "20/05/2025"});
#line 27
 await testRunner.AndAsync("the following bookings already exist:", ((string)(null)), table2, "And ");
#line hidden
#line 32
 await testRunner.AndAsync("the user specifies a checkIn date of \"17/05/2025\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 33
 await testRunner.AndAsync("the user specifies a checkOut date of \"18/05/2025\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 37
 await testRunner.WhenAsync("the user submits the search request", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
                global::Reqnroll.Table table3 = new global::Reqnroll.Table(new string[] {
                            "RoomNo",
                            "Type",
                            "MaxOccupancy",
                            "PricePerNight"});
                table3.AddRow(new string[] {
                            "102",
                            "Single",
                            "1",
                            "€140"});
                table3.AddRow(new string[] {
                            "104",
                            "Double",
                            "3",
                            "€180"});
                table3.AddRow(new string[] {
                            "105",
                            "Double",
                            "3",
                            "€180"});
                table3.AddRow(new string[] {
                            "106",
                            "Suite",
                            "4",
                            "€250"});
#line 40
 await testRunner.ThenAsync("the user should be informed that the available rooms are:", ((string)(null)), table3, "Then ");
#line hidden
                global::Reqnroll.Table table4 = new global::Reqnroll.Table(new string[] {
                            "RoomNo",
                            "Type",
                            "MaxOccupancy",
                            "PricePerNight"});
                table4.AddRow(new string[] {
                            "101",
                            "Single",
                            "1",
                            "€140"});
                table4.AddRow(new string[] {
                            "103",
                            "Double",
                            "2",
                            "€180"});
#line 47
 await testRunner.ButAsync("the user should not be offered the following rooms:", ((string)(null)), table4, "But ");
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
                await CheckRoomAvailabilityFeature.FeatureSetupAsync();
            }
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
            {
                await CheckRoomAvailabilityFeature.FeatureTearDownAsync();
            }
        }
    }
}
#pragma warning restore
#endregion
