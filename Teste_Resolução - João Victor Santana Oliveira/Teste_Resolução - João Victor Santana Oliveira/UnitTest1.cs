using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Teste_Resolução___João_Victor_Santana_Oliveira
{
    public class UnitTest1
    {
        public IWebDriver driver { get; private set; }
        public IDictionary<String, Object> vars { get; private set; }
        public IJavaScriptExecutor js { get; private set; }

        public UnitTest1()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<String, Object>();
        }

        public void Dispose()
        {
            driver.Quit();
        }
        [Fact]
        public void CT01CAMPO()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.CssSelector("#btn-gravar > span")).Click();

            Dispose();

            var id = 


        }

        [Fact]
        public void CT02FUNDOVERDE()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("idDepartamento")).Click();
            driver.FindElement(By.Id("departamento")).Click();
            driver.FindElement(By.Id("NomeFuncionario")).Click();
            driver.FindElement(By.Id("cargo")).Click();
            driver.FindElement(By.Id("Motivo")).Click();
            driver.FindElement(By.Id("idFuncionario")).Click();
            driver.FindElement(By.Id("categoriaMotivo")).Click();

            Dispose();
        }

        [Fact]
        public void CT03CAMPOID()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("idDepartamento")).Click();
            driver.FindElement(By.Id("idDepartamento")).SendKeys("40");

            Dispose();
        }

        [Fact]
        public void CT04CATEGORIAMOTIVO()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("categoriaMotivo")).Click();
            {
                var dropdown = driver.FindElement(By.Id("categoriaMotivo"));
                dropdown.FindElement(By.XPath("//option[. = 'Gestão']")).Click();
            }

            Dispose();
        }

        [Fact]

        public void CT05MOTIVO()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("categoriaMotivo")).Click();
            {
                var dropdown = driver.FindElement(By.Id("categoriaMotivo"));
                dropdown.FindElement(By.XPath("//option[. = 'Gestão']")).Click();
            }
            driver.FindElement(By.Id("Motivo")).Click();
            {
                var dropdown = driver.FindElement(By.Id("Motivo"));
                dropdown.FindElement(By.XPath("//option[. = 'Planejamento']")).Click();
            }
            driver.FindElement(By.Id("categoriaMotivo")).Click();
            {
                var dropdown = driver.FindElement(By.Id("categoriaMotivo"));
                dropdown.FindElement(By.XPath("//option[. = 'Cliente']")).Click();
            }
            driver.FindElement(By.Id("Motivo")).Click();
            driver.FindElement(By.Id("Motivo")).Click();
            {
                var element = driver.FindElement(By.Id("Motivo"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            driver.FindElement(By.Id("Motivo")).Click();
            {
                var dropdown = driver.FindElement(By.Id("Motivo"));
                dropdown.FindElement(By.XPath("//option[. = 'Quebra de Máquina']")).Click();
            }
            driver.FindElement(By.Id("categoriaMotivo")).Click();
            {
                var dropdown = driver.FindElement(By.Id("categoriaMotivo"));
                dropdown.FindElement(By.XPath("//option[. = 'RP']")).Click();
            }
            driver.FindElement(By.Id("Motivo")).Click();
            {
                var dropdown = driver.FindElement(By.Id("Motivo"));
                dropdown.FindElement(By.XPath("//option[. = 'Financeiro']")).Click();
            }

            Dispose();
        }

        [Fact]
        public void CT06DEPARTAMENTO()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("idDepartamento")).Click();
            driver.FindElement(By.Id("idDepartamento")).SendKeys("40");
            driver.FindElement(By.Id("departamento")).Click();
            driver.FindElement(By.Id("NomeFuncionario")).Click();

            Dispose();
        }

        [Fact]

        public void CT07FUNCIONRIO()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("idFuncionario")).Click();

            Dispose();
        }

        [Fact]
        public void CT08CODPRODUTO()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("CodigoProduto")).Click();
            driver.FindElement(By.Id("CodigoProduto")).SendKeys("1");
            driver.FindElement(By.Id("DescricaoProduto")).Click();
            driver.FindElement(By.Id("CodigoProduto")).Click();
            driver.FindElement(By.Id("CodigoProduto")).SendKeys("10");

            Dispose();
        }

        [Fact]
        public void CT09QUANTIDADE()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("CodigoProduto")).Click();
            driver.FindElement(By.Id("CodigoProduto")).SendKeys("1");
            driver.FindElement(By.Id("Estoque")).Click();

            Dispose();
        }

        [Fact]
        public void CT10CAMPOQUANTIDADE()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("Estoque")).Click();

            Dispose();
        }

        [Fact]
        public void CT11GRAVAR()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("btn-gravar")).Click();

            Dispose();
        }

        [Fact]
        public void CT12NVELPRIORIDADE()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("urgente")).Click();
            driver.FindElement(By.Id("medio")).Click();
            driver.FindElement(By.Id("baixo")).Click();

            Dispose();
        }

        [Fact]
        public void CT13STATUSESTOQUE()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("CodigoProduto")).Click();
            driver.FindElement(By.Id("CodigoProduto")).SendKeys("1");

            Dispose();
        }

        [Fact]

        public void CT14TOOLTIP()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("CodigoProduto")).Click();
            driver.FindElement(By.Id("CodigoProduto")).SendKeys("2");

            Dispose();
        }



    }


}