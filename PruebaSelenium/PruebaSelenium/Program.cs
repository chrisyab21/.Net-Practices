// See https://aka.ms/new-console-template for more information

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;




IWebDriver driver = new ChromeDriver();

string Origen = "VVI";
string Destino = "CUN";
string fechaIda = "2024-09-01";
string fechaVuelta = "2024-09-08";

driver.Navigate().GoToUrl($"https://www.kiwi.com/es/buscar/results/{Origen}/{Destino}/{fechaIda}/{fechaVuelta}");

var inputSearch = driver.FindElement(By.XPath("//*[@id=\"cookie_consent\"]/div/div/div/div/button/div/div"));

inputSearch.Click();


var DivHoras = driver.FindElements(By.XPath("//div[@class='ResultCardItinerarystyled__SectorWrapper-sc-iwhyue-11 ieGHmf']"));

foreach (var item in DivHoras)
{
    var horaSalida2 = item.FindElement(By.XPath("//strong[@class='ResultCardItineraryPlacestyled__SemiBold-sc-1ekdizc-2 cVhCfK']/time[1]"));

    string hora = horaSalida2.Text;
    Console.WriteLine(hora);

}

driver.Close();





List<string> Lista1 = new List<string>();

Lista1.Add("Hola");
Lista1.Add("Hola2");
Lista1.Add("Hola3");

int[,] multiDimensionalArray2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

List<string> Lista2 = new List<string>();

Lista2.Add("Bye");
Lista2.Add("Bye2");
Lista2.Add("Bye3");

int i = 0;

foreach (var item in multiDimensionalArray2)
{

    Console.WriteLine(item);
    i = i + 1;

}


driver.Quit();

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



IWebDriver driver2 = new ChromeDriver();

string Origen2 = "VVI";
string Destino2 = "CUN";
string fechaIda2 = "2023-02-01";
string fechaVuelta2 = "2023-02-08";

driver2.Navigate().GoToUrl($"https://stackoverflow.com/questions");



var DivHoras2 = driver2.FindElements(By.XPath("//div[@class='s-post-summary    js-post-summary']")); ;



foreach (var item in DivHoras2)
{
    var TituloPregunta = item.FindElement(By.XPath(".//a[@class='s-link']"));
    Console.WriteLine(TituloPregunta.Text);

}

driver2.Quit();







