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
            var resultadoesperado = "background-color: red";
        
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.CssSelector("#btn-gravar > span")).Click();

            
            var id = driver.FindElement(By.Id("idDepartamento")).GetAttribute("style");
            Assert.Contains(resultadoesperado, id);

            var departamento = driver.FindElement(By.Id("departamento")).GetAttribute("style");
            Assert.Contains(resultadoesperado, departamento);

            var data = driver.FindElement(By.Id("dataRequisicao")).GetAttribute("style");
            Assert.Contains(resultadoesperado, data);

            var idfuncionario = driver.FindElement(By.Id("idFuncionario")).GetAttribute("style");
            Assert.Contains(" ", idfuncionario);

            var nomefuncionario = driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("style");
            Assert.Contains(resultadoesperado, nomefuncionario);

            var cargo = driver.FindElement(By.Id("cargo")).GetAttribute("style");
            Assert.Contains(resultadoesperado, cargo);

            var categoriamotivo = driver.FindElement(By.Id("categoriaMotivo")).GetAttribute("style");
            Assert.Contains(resultadoesperado, categoriamotivo);

            var motivo = driver.FindElement(By.Id("Motivo")).GetAttribute("style");
            Assert.Contains(resultadoesperado, motivo);

            var codproduto = driver.FindElement(By.Id("CodigoProduto")).GetAttribute("style");
            Assert.Contains(resultadoesperado, codproduto);

            var descricao = driver.FindElement(By.Id("DescricaoProduto")).GetAttribute("style");
            Assert.Contains(resultadoesperado, descricao);

            var quantidade = driver.FindElement(By.Id("Estoque")).GetAttribute("style");
            

            Dispose(); 
           


        }

        [Fact]
        public void CT02FUNDOVERDE()

        {
            var resultadoesperado = "outline-color: rgb(144, 238, 144)";

            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("idDepartamento")).Click();
            driver.FindElement(By.Id("departamento")).Click();
            driver.FindElement(By.Id("NomeFuncionario")).Click();
            driver.FindElement(By.Id("cargo")).Click();
            driver.FindElement(By.Id("Motivo")).Click();
            driver.FindElement(By.Id("idFuncionario")).Click();
            driver.FindElement(By.Id("categoriaMotivo")).Click();

            
            driver.FindElement(By.Id("departamento")).Click();
            var departamento = driver.FindElement(By.Id("departamento")).GetAttribute("style");
            Assert.Contains(resultadoesperado,departamento);
            
            Dispose();
        }

        [Fact]
        public void CT03CAMPOID()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("idDepartamento")).Click();
            driver.FindElement(By.Id("idDepartamento")).SendKeys("40");

            var valor1 = driver.FindElement(By.Id("idDepartamento")).GetAttribute("value");
            Assert.IsType<int>(Convert.ToInt32(valor1));

            Dispose();
        }

        [Fact]
        public void CT04CATEGORIAMOTIVO()
        {

            var categoriamotivo = "Gestão";
            var categoriamotivo2 = "Cliente";
            var categoriamotivo3 = "RP";

            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("categoriaMotivo")).Click();
            {
                var dropdown = driver.FindElement(By.Id("categoriaMotivo"));
                dropdown.FindElement(By.XPath("//option[. = 'Gestão']")).Click();
                var valor1 = driver.FindElement(By.XPath("//option[. = 'Cliente']")).GetProperty("value");
                Assert.Equal(valor1, "Cliente");
            }




            Dispose();
        }

        [Fact]

        public void CT05MOTIVO()
        {
            var categoriamotivo = "Gestão";
            var categoriamotivo2 = "Cliente";
            var categoriamotivo3 = "RP";

            var motivo = "Planejamento , Financeiro";
            var motivo2 = "Quebra de Máquina";
            var motivo3 = "Financeiro";

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

            var resultadoesperado = driver.FindElement(By.Id("departamento")).GetAttribute("value");
            Assert.Contains("NAT", resultadoesperado);
            Dispose();
        }

        [Fact]

        public void CT07FUNCIONRIO()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("idFuncionario")).Click();
            driver.FindElement(By.Id("idFuncionario")).SendKeys("10");

            var resultadoesperado = driver.FindElement(By.Id("NomeFuncionario")).GetAttribute("value");
            Assert.Contains("Jose", resultadoesperado);

            Dispose();
        }

        [Fact]
        public void CT08CODPRODUTO()
        {

            

            driver.Navigate().GoToUrl("http://127.0.0.1:5500/");
            driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
            driver.FindElement(By.Id("CodigoProduto")).Click();
            driver.FindElement(By.Id("CodigoProduto")).SendKeys("1");

            var resultadoesperado = driver.FindElement(By.Id("DescricaoProduto")).GetAttribute("value");
            Assert.Contains("Monitor", resultadoesperado);

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