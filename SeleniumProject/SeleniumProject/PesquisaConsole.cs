using System;
using Xunit;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumProject
{
	public class PesquisaConsole
	{
		[Fact]
		public void Test1()
		{
			//TODOS OS TIMES FORAM PARA DEIXAR UMA NAVEGAÇÃO MAIS VISÍVEL 
			
			// Criando o drive e indicando onde o arquivo se encontra
			IWebDriver driver = new FirefoxDriver("C:\\Users\\Gideone Jr\\Documents\\Desafio\\SeleniumProject\\SeleniumProject\\Drivers\\Firefox");
			driver.Navigate().GoToUrl("https://www.americanas.com");

			Thread.Sleep(1000);

			// Capturando a área de pesquisa pelo ID
			var inputPesquisa = driver.FindElement(By.Id("h_search-input"));
			// Inserindo o valor desejado
			inputPesquisa.SendKeys("console ps4");
			// Botão de pesquisa
			var btRegistro = driver.FindElement(By.Id("h_search-btn"));
			btRegistro.Click();

			Thread.Sleep(1000);

			//Para retirar a opção de salvar os dados e deixar a tela mais limpa
			var btDados = driver.FindElement(By.Id("lgpd-accept"));
			btDados.Click();			

			//Escolhendo o primeiro console	
			driver.Navigate().GoToUrl("https://www.americanas.com/produto/3292904406?pfm_carac=console-ps4&pfm_page=search&pfm_pos=grid&pfm_type=search_page&offerld=6166ddcc09c351890d7b57a6");

			Thread.Sleep(1000);

			//Área de inserir o CEP
			var inputCEP = driver.FindElement(By.Name("cep"));
			//Inserindo um CEP de São Paulo, pois não entregam para o meu CEP
			inputCEP.SendKeys("01220-010");

			Thread.Sleep(1000);

			// Capturando o botão de pesquisa do CEP
			var btCEP = driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/div[2]/div[2]/div[2]/form/div/div[2]/button"));
			btCEP.Click();

			Thread.Sleep(1000);

			// Botão de compra
			var btCompra01 = driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/div[2]/div[2]/div[3]/a"));
			btCompra01.Click();			

			// Opção da garantia
			var rdGarantia = driver.FindElement(By.XPath("/html/body/div/div/div/main/div[2]/div[1]/div/div[2]/div/div[2]/div/div[2]/div[1]/div[1]/div/div"));
			rdGarantia.Click();

			Thread.Sleep(1000);

			// Compra para entrar na cesta
			var btCompra02 = driver.FindElement(By.XPath("/html/body/div/div/div/main/div[2]/div[2]/div/a"));
			btCompra02.Click();

			Thread.Sleep(1000);

			// Ao continuar é preciso colocar o email e senha cadastrados
			var btContinuar = driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div[2]/button"));
			btContinuar.Click();

			Thread.Sleep(1000);

			//Decidi voltar ao site principal e acessar a cesta
			driver.Navigate().GoToUrl("https://www.americanas.com");

			Thread.Sleep(1000);

			var aCesta = driver.FindElement(By.XPath("/html/body/header/div[2]/div[2]/div[1]/div[6]/a"));
			aCesta.Click();

			Thread.Sleep(1000);

			// Acessando a cesta
			var btMinhaCesta = driver.FindElement(By.XPath("/html/body/header/div[2]/div[2]/div[1]/div[6]/div/div/a"));
			btMinhaCesta.Click();
			



		}  
	}
}
