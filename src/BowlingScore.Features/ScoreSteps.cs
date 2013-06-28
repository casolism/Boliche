using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using ImproveIT.Feature;
using NUnit.Framework;

namespace BowlingScore.Features
{
    [Binding]
    public class ScoreSteps
    {
[Given(@"Se inició un nuevo juego")]
        public void GivenSeInicioUnNuevoJuego()
        {
            WebBrowser.Current.Navigate().GoToUrl("http://localhost:4427/"); 
        }

        [When(@"Visito la página Score")]
        public void WhenVisitoLaPaginaScore()
        {
            WebBrowser.Current.Navigate().GoToUrl("http://localhost:4427/Score"); 
        }

        [Then(@"Veo el mensaje ""(.*)""")]
        public void ThenVeoElMensaje(string p0)
        {
            Assert.IsTrue(WebBrowser.Current.PageSource.Contains(p0));
        }

        [Then(@"Veo la tabla ""(.*)"":")]
        public void ThenVeoLaTabla(string p0, Table table)
        {
            IWebElement tableFounded = WebBrowser.Current.FindElement(By.Id("tblScore"));
            IWebElement tableBodyFounded = tableFounded.FindElement(By.TagName("tbody"));
            var tableRowsFounded = tableBodyFounded.FindElements(By.TagName("tr"));
            Assert.AreEqual(tableRowsFounded.Count, table.Rows.Count, "Diferent quantity of rows in tables");

            int rowsCounter = 0;
            foreach (TableRow tableRowsExpected in table.Rows)
            {
                IWebElement tableRowFounded = tableRowsFounded[rowsCounter];
                var dataFounded = tableRowFounded.FindElements(By.TagName("td"));

                int colCounter = 0;
                foreach (string valExpected in tableRowsExpected.Values)
                {
                    string valFounded = dataFounded[colCounter].Text;
                    if (valExpected == "score")
                    {
                        Assert.AreEqual("0", valFounded);
                    }
                    colCounter++;
                }
                rowsCounter++;
            }
        }

        [Then(@"El jugador (.*) realiza su tirada (.*) del primer turno")]
        public void ThenElJugadorRealizaSuTiradaDelPrimerTurno(int p0, int p1)
        {
            Assert.IsTrue(WebBrowser.Current.PageSource.Contains("Turno: Jugador " + p0.ToString()));
            Assert.IsTrue(WebBrowser.Current.PageSource.Contains("Oportunidad: " + p1.ToString()));
        }

        [Then(@"Chavita pulsó el botón chuza")]
        public void ThenChavitaPulsoElBotonChuza()
        {
            IWebElement query = WebBrowser.Current.FindElement(By.Id("btnChuza"));
            query.Click();
        }

        [When(@"Chavita Registra (.*) pines")]
        public void WhenChavitaRegistraPines(int scoreNumber)
        {
            //ScenarioContext.Current.Pending();
            IWebElement textbox = WebBrowser.Current.FindElement(By.Id("txtPinos"));
            textbox.SendKeys(scoreNumber.ToString());            
        }

        [When(@"Chavita pulsó el botón Ok")]
        public void WhenChavitaPulsoElBotonOk()
        {
            IWebElement OkButton = WebBrowser.Current.FindElement(By.Id("btnOk"));
            OkButton.Click();
        }

    }
}
