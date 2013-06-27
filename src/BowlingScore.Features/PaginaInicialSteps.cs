using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ImproveIT.Feature;
using OpenQA.Selenium;
using NUnit.Framework;

namespace BowlingScore.Features
{
    [Binding]
    public class PaginaInicialSteps
    {
        [Given(@"Abrio la aplicacion boliche")]
        public void GivenAbrioLaAplicacionBoliche()
        {
            WebBrowser.Current.Navigate().GoToUrl("http://localhost:4427/");
        }
        [When(@"Presiono el boton ""(.*)""")]
        public void WhenPresionoElBoton(string p0)
        {
            IWebElement query = WebBrowser.Current.FindElement(By.Id("btnNuevo"));
            query.Click();
        }
        [Then(@"Debo ver pagina Score")]
        public void ThenDeboVerPaginaScore()
        {
            Assert.IsTrue(WebBrowser.Current.Url.Contains("/Score"));
        }
    }
}
