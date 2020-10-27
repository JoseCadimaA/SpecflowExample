﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.4.0.0
//      SpecFlow Generator Version:3.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BookShop.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Desplegar libros en la pantalla", new string[] {
            "automated",
            "WI7"}, Description="\tComo pontencial cliente\r\n\tQuiero ver los libros con el mejor precio\r\n\tPara ahorr" +
        "a dinero comprando libros con descuentos\t", SourceFile="Features\\Home Screen.feature", SourceLine=2)]
    public partial class DesplegarLibrosEnLaPantallaFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "automated",
                "WI7"};
        
#line 1 "Home Screen.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en"), "Features", "Desplegar libros en la pantalla", "\tComo pontencial cliente\r\n\tQuiero ver los libros con el mejor precio\r\n\tPara ahorr" +
                    "a dinero comprando libros con descuentos\t", ProgrammingLanguage.CSharp, new string[] {
                        "automated",
                        "WI7"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 8
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Price"});
            table5.AddRow(new string[] {
                        "100 a�os de soledad",
                        "50.20"});
            table5.AddRow(new string[] {
                        "Programacion en Java",
                        "46.34"});
            table5.AddRow(new string[] {
                        "La metamorfosis",
                        "31.49"});
            table5.AddRow(new string[] {
                        "La tolla del mojado",
                        "24.75"});
#line 9
 testRunner.Given("the following books", ((string)(null)), table5, "Given ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Los 3 libros mas baratos se deberian mostrar en l apantalla de inicio", new string[] {
                "WI8"}, SourceLine=16)]
        public virtual void Los3LibrosMasBaratosSeDeberianMostrarEnLApantallaDeInicio()
        {
            string[] tagsOfScenario = new string[] {
                    "WI8"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Los 3 libros mas baratos se deberian mostrar en l apantalla de inicio", null, tagsOfScenario, argumentsOfScenario);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
this.FeatureBackground();
#line hidden
#line 18
 testRunner.When("Ingreso a la tienda virtual", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("La pantalla de inicio deberia mostrar el libro \'La tolla del mojado\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.And("La pantalla de inicio deberia mostrar el libro \'La metamorfosis AAASDFD\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("La pantalla de inicio deberia mostrar el libro \'Programacion en Java\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Los 3 libros mas baratos se deberian mostrar en l apantalla de inicio (list synta" +
            "x)", new string[] {
                "alternative_syntax",
                "WI8"}, SourceLine=24)]
        public virtual void Los3LibrosMasBaratosSeDeberianMostrarEnLApantallaDeInicioListSyntax()
        {
            string[] tagsOfScenario = new string[] {
                    "alternative_syntax",
                    "WI8"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Los 3 libros mas baratos se deberian mostrar en l apantalla de inicio (list synta" +
                    "x)", null, tagsOfScenario, argumentsOfScenario);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
this.FeatureBackground();
#line hidden
#line 26
 testRunner.When("Ingreso a la tienda virtual", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("La pantalla de inicio deberia mostrar los libros \'La tolla del mojado\', \'La metam" +
                        "orfosis\', \'Programacion en Java\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Los 3 libros mas baratos se deberian mostrar en l apantalla de inicio (table synt" +
            "ax)", new string[] {
                "alternative_syntax",
                "WI8"}, SourceLine=30)]
        public virtual void Los3LibrosMasBaratosSeDeberianMostrarEnLApantallaDeInicioTableSyntax()
        {
            string[] tagsOfScenario = new string[] {
                    "alternative_syntax",
                    "WI8"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Los 3 libros mas baratos se deberian mostrar en l apantalla de inicio (table synt" +
                    "ax)", null, tagsOfScenario, argumentsOfScenario);
#line 31
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
this.FeatureBackground();
#line hidden
#line 32
 testRunner.When("Ingreso a la tienda virtual", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title"});
                table6.AddRow(new string[] {
                            "La tolla del mojado"});
                table6.AddRow(new string[] {
                            "La metamorfosisFGFGFDFG"});
                table6.AddRow(new string[] {
                            "Programacion en Java"});
#line 33
 testRunner.Then("La pantalla de inicio deberia mostrar los libros", ((string)(null)), table6, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
