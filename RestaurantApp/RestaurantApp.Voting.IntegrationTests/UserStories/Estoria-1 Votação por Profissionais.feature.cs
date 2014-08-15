﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RestaurantApp.Voting.IntegrationTests.UserStories
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class Estoria1_UmProfessionalSoPodeVotarEmUmRestaurantePorDia_Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Estoria-1 Votação por Profissionais.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Estória 1 - Um professional só pode votar em um restaurante por dia.", "  Eu como profissional faminto\r\n  Quero votar no meu restaurante favorito\r\n  Para" +
                    " que eu consiga democraticamente levar meus colegas a comer onde eu gusto.", ProgrammingLanguage.CSharp, new string[] {
                        "requires_database"});
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Estória 1 - Um professional só pode votar em um restaurante por dia.")))
            {
                RestaurantApp.Voting.IntegrationTests.UserStories.Estoria1_UmProfessionalSoPodeVotarEmUmRestaurantePorDia_Feature.FeatureSetup(null);
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
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
        testRunner.Given("os seguintes profissionais: Bruno, Kauã, Ahmed, Maicon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dados ");
#line 9
        testRunner.And("os seguintes restaurantes: Piazza, Colegiais, Banquette", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Um professional só poderia votar em um restaurante por dia.")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Estória 1 - Um professional só pode votar em um restaurante por dia.")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("requires_database")]
        public virtual void UmProfessionalSoPoderiaVotarEmUmRestaurantePorDia_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Um professional só poderia votar em um restaurante por dia.", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 12
        testRunner.Given("que o \'Ahmed\' votou no restaurante \'Piazza\' \'hoje\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 13
        testRunner.Then("o \'Ahmed\' não deveria poder votar no restaurante \'Piazza\' \'hoje\' novamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 14
        testRunner.And("o \'Ahmed\' não deveria poder votar no restaurante \'Colegiais\' \'hoje\' novamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
        testRunner.But("\'Kauã, Maicon\' deveriam poder votar no restaurante \'Piazza\' \'hoje\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Mas ");
#line 16
        testRunner.And("o \'Bruno\' deveria poder votar no restaurante \'Colegiais\' \'hoje\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
