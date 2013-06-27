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
            IWebElement tableFounded = WebBrowser.Current.FindElement(By.Id("Score"));
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


    }
}
