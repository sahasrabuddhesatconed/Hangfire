﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HangFire.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class Re_QueueingOfTimedOutJobsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DequeuedJobsWatcher.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Re-queueing of timed out jobs", "", ProgrammingLanguage.CSharp, new string[] {
                        "redis"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Re-queueing of timed out jobs")))
            {
                HangFire.Tests.Re_QueueingOfTimedOutJobsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A job in the implicit \'Dequeued\' state moved to the \'Checked\' state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Re-queueing of timed out jobs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("checkpoint-1-1")]
        public virtual void AJobInTheImplicitDequeuedStateMovedToTheCheckedState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A job in the implicit \'Dequeued\' state moved to the \'Checked\' state", new string[] {
                        "checkpoint-1-1"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
    testRunner.Given("a dequeued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
     testRunner.When("the watcher runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
     testRunner.Then("it marks the job as \'checked\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Non-timed out job in the \'Checked\' state should not be requeued")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Re-queueing of timed out jobs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("checkpoint-1-2")]
        public virtual void Non_TimedOutJobInTheCheckedStateShouldNotBeRequeued()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Non-timed out job in the \'Checked\' state should not be requeued", new string[] {
                        "checkpoint-1-2"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
    testRunner.Given("a dequeued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
      testRunner.And("it was checked a millisecond ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
     testRunner.When("the watcher runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
     testRunner.Then("the dequeued jobs list still contains the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
      testRunner.And("the queue does not contain the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
      testRunner.And("the job has the \'checked\' flag set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Timed job in the \'Checked\' state should be requeued")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Re-queueing of timed out jobs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("checkpoint-1-2")]
        public virtual void TimedJobInTheCheckedStateShouldBeRequeued()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Timed job in the \'Checked\' state should be requeued", new string[] {
                        "checkpoint-1-2"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
   testRunner.Given("a dequeued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
      testRunner.And("it was checked a day ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
     testRunner.When("the watcher runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
     testRunner.Then("the queue contains the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
      testRunner.And("the dequeued jobs list does not contain the job anymore", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
      testRunner.And("the job does not have the \'checked\' flag set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Timed out job by the \'checked\' flag in the \'Fetched\' state should not be re-queue" +
            "d")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Re-queueing of timed out jobs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("checkpoint-2")]
        public virtual void TimedOutJobByTheCheckedFlagInTheFetchedStateShouldNotBeRe_Queued()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Timed out job by the \'checked\' flag in the \'Fetched\' state should not be re-queue" +
                    "d", new string[] {
                        "checkpoint-2"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
    testRunner.Given("a dequeued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
      testRunner.And("it was checked a day ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
      testRunner.And("it was fetched a millisecond ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
     testRunner.When("the watcher runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
     testRunner.Then("the dequeued jobs list still contains the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
      testRunner.And("the queue does not contain the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
      testRunner.And("the job has the \'checked\' flag set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
      testRunner.And("the job has the \'fetched\' flag set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Timed out jobs in the \'Fetched\' state should be re-queued")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Re-queueing of timed out jobs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("checkpoint-2")]
        public virtual void TimedOutJobsInTheFetchedStateShouldBeRe_Queued()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Timed out jobs in the \'Fetched\' state should be re-queued", new string[] {
                        "checkpoint-2"});
#line 40
this.ScenarioSetup(scenarioInfo);
#line 41
    testRunner.Given("a dequeued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
      testRunner.And("it was fetched a day ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
     testRunner.When("the watcher runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
     testRunner.Then("the queue contains the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
      testRunner.And("the dequeued jobs list does not contain the job anymore", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
      testRunner.And("the job does not have the \'checked\' flag set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
      testRunner.And("the job does not have the \'fetched\' flag set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Job\'s state is changed to the Enqueued when the job is being timed out after proc" +
            "eeding to the Processing state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Re-queueing of timed out jobs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("checkpoint-3")]
        public virtual void JobSStateIsChangedToTheEnqueuedWhenTheJobIsBeingTimedOutAfterProceedingToTheProcessingState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Job\'s state is changed to the Enqueued when the job is being timed out after proc" +
                    "eeding to the Processing state", new string[] {
                        "checkpoint-3"});
#line 50
this.ScenarioSetup(scenarioInfo);
#line 51
    testRunner.Given("a dequeued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
      testRunner.And("it\'s state is Processing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
      testRunner.And("it was fetched a day ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
     testRunner.When("the watcher runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
     testRunner.Then("the job moved to the Enqueued state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
      testRunner.And("the dequeued jobs list does not contain the job anymore", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Timed out job in the Succeeded state does not move to the Enqueued state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Re-queueing of timed out jobs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("checkpoint-4")]
        public virtual void TimedOutJobInTheSucceededStateDoesNotMoveToTheEnqueuedState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Timed out job in the Succeeded state does not move to the Enqueued state", new string[] {
                        "checkpoint-4"});
#line 59
this.ScenarioSetup(scenarioInfo);
#line 60
    testRunner.Given("a dequeued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
      testRunner.And("it\'s state is Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
      testRunner.And("it was fetched a day ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
     testRunner.When("the watcher runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
     testRunner.Then("the job remains to be in the Succeeded state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
      testRunner.But("the dequeued jobs list does not contain the job anymore", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Job is being enqueued on it\'s actual queue after timing out")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Re-queueing of timed out jobs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void JobIsBeingEnqueuedOnItSActualQueueAfterTimingOut()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Job is being enqueued on it\'s actual queue after timing out", ((string[])(null)));
#line 67
this.ScenarioSetup(scenarioInfo);
#line 68
      testRunner.And("a dequeued job from the \'test\' queue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
      testRunner.And("it was fetched a day ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
     testRunner.When("the watcher runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
     testRunner.Then("the queue contains the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When the server could not find the job\'s type, the job is moved to the Failed sta" +
            "te")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Re-queueing of timed out jobs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void WhenTheServerCouldNotFindTheJobSTypeTheJobIsMovedToTheFailedState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When the server could not find the job\'s type, the job is moved to the Failed sta" +
                    "te", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 74
    testRunner.Given("a dequeued job of the \'NonExisting\' type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
      testRunner.And("it was fetched a day ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
     testRunner.When("the watcher runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
     testRunner.Then("the job moved to the Failed state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
      testRunner.And("the dequeued jobs list does not contain the job anymore", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Succeeded job of non-existing type will not be moved to the failed state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Re-queueing of timed out jobs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void SucceededJobOfNon_ExistingTypeWillNotBeMovedToTheFailedState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Succeeded job of non-existing type will not be moved to the failed state", ((string[])(null)));
#line 80
this.ScenarioSetup(scenarioInfo);
#line 81
    testRunner.Given("a dequeued job of the \'NonExisting\' type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 82
      testRunner.And("it\'s state is Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
      testRunner.And("it was fetched a day ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
     testRunner.When("the watcher runs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
     testRunner.Then("the job remains to be in the Succeeded state", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
      testRunner.But("the dequeued jobs list does not contain the job anymore", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
