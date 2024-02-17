



using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;
using TesisApi.DTOS;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");
var options = new ChromeOptions();
options.AddArgument("--headless=new");

IWebDriver driver = new ChromeDriver();
//var driver = new ChromeDriver(options);

string Origen = "VVI";
string Destino = "CUN";
string fechaIda = "2023-12-12";
string fechaVuelta = "2023-12-20";

// https://www.kiwi.com/es/buscar/results/VVI/CUN/2023-02-01/2023-02-08

driver.Navigate().GoToUrl($"https://www.kiwi.com/es");


var inputSearch = driver.FindElement(By.XPath("//*[@id=\"cookie_consent\"]/div/div/div/div/button/div/div"));

inputSearch.Click();

Thread.Sleep(5000);


//var DivHoras1 = driver.FindElements(By.XPath("//div[@class='ResultCardItinerarystyled__SectorWrapper-sc-1swbl8-12 iKVnNX']"));
//var DivHoras2 = driver.FindElements(By.XPath("//div[@class='p-sm lm:px-md lm:py-sm']"));

var closePicker = driver.FindElement(By.XPath(".//div[@data-test='PlacePickerInputPlace-close']"));

closePicker.Click();

var origenInput = driver.FindElement(By.XPath(".//div[@data-test='PlacePickerInput-origin']/input"));
var destinoInput = driver.FindElement(By.XPath(".//div[@data-test='PlacePickerInput-destination']/input"));

origenInput.SendKeys(Origen);

Thread.Sleep(2000);

var inputSelect = driver.FindElement(By.XPath("//div[@class='w-full']/div/div[1]"));

inputSelect.Click();


destinoInput.SendKeys(Destino);

Thread.Sleep(2000);

inputSelect = driver.FindElement(By.XPath("//div[@class='w-full']/div/div[1]"));

inputSelect.Click();

Thread.Sleep(1000);

var datePicker = driver.FindElement(By.XPath("(.//div[@data-test='SearchDateInput'])[1]"));


datePicker.Click();

Thread.Sleep(2000);

var movePreviusMonth = driver.FindElement(By.XPath(".//div[@data-test='CalendarMovePrevious']/button"));

var moveNextMonth = driver.FindElement(By.XPath(".//div[@data-test='CalendarMoveNext']/button"));

// moveNextMonth.Click();

// moveNextMonth.Click();

WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

wait.PollingInterval = TimeSpan.FromMilliseconds(250);

wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(moveNextMonth)).Click();
wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(moveNextMonth)).Click();
wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(moveNextMonth)).Click();
wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(moveNextMonth)).Click();

Thread.Sleep(4000);

var fechaSalida = driver.FindElement(By.XPath("(.//div[@data-test='DayContentContainer']//div[text()='5'])[1]"));

wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(fechaSalida)).Click();

var fechaLlegada = driver.FindElement(By.XPath("(.//div[@data-test='DayContentContainer']//div[text()='17'])[1]"));

wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(fechaLlegada)).Click();

var setDates = driver.FindElement(By.XPath(".//button[@data-test='SearchFormDoneButton']"));

wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(setDates)).Click();

var searchButton = driver.FindElement(By.XPath("//a[@data-test='LandingSearchButton']"));

string ventanaPrincipal = driver.CurrentWindowHandle;

wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(searchButton)).Click();


// Espera un tiempo suficiente para que la nueva pestaña se abra completamente
//Thread.Sleep(5000); // Ajusta el tiempo de espera según sea necesario

// Encuentra todas las ventanas abiertas por el driver
List<string> ventanas = driver.WindowHandles.ToList();

// Cambia el control del driver a la nueva pestaña
foreach (string ventana in ventanas)
{
    if (ventana != ventanaPrincipal)
    {
        driver.SwitchTo().Window(ventana);
        break;
    }
}

Thread.Sleep(5000);

//TODO DESPUES DE ESTA LINEA AL PARECER SE EJECUTA PERO NO IMPRIME NADA EN CONSOLA

var container = driver.FindElements(By.XPath("//div[@data-test='ResultCardWrapper']"));


List<Pasaje> ListaDePasajes = new List<Pasaje>();

foreach (var element in container)
{
    var DivHoras3 = element.FindElements(By.XPath(".//div[@class='flex flex-grow flex-col justify-center']"));

    Pasaje pasaje = new Pasaje();

    List<VueloCreacionDTO> ListaDeVuelos = new List<VueloCreacionDTO>();

    for (int i = 0; i < DivHoras3.Count; i++)
    {

        var horaDeSalida = DivHoras3[i].FindElement(By.XPath(".//div[@data-test='ResultCardSectorRow'][1]//time"));

        var horaDeLlegada = DivHoras3[i].FindElement(By.XPath(".//div[@data-test='ResultCardSectorRow'][2]//time"));


        var LugarDeOrigen = DivHoras3[i].FindElement(By.XPath(".//div[@data-test='ResultCardSectorRow'][1]/div[2]/div[1]/div[1]"));

        var LugarDeDestino = DivHoras3[i].FindElement(By.XPath(".//div[@data-test='ResultCardSectorRow'][2]/div[2]/div[1]/div[1]"));


        var horaSalida = horaDeSalida.Text;
        var horaLlegada = horaDeLlegada.Text;

        var SalidaDesde = LugarDeOrigen.Text;
        var LugarDeLlegada = LugarDeDestino.Text;


        VueloCreacionDTO Vuelo = new VueloCreacionDTO();

        Vuelo.NroVuelo = "";
        Vuelo.Aerolinea = "";
        Vuelo.FechaDeSalida = DateTime.Parse($"{fechaIda} {horaSalida}");
        Vuelo.FechaDeLlegada = DateTime.Parse($"{fechaVuelta} {horaLlegada}");
        Vuelo.AeropuertoOrigen = SalidaDesde;
        Vuelo.AeropuertoDestino = LugarDeLlegada;


        ListaDeVuelos.Add(Vuelo);

        Console.WriteLine($"Salida desde:{Vuelo.AeropuertoOrigen} a las {Vuelo.FechaDeSalida}");
        Console.WriteLine($"Llegada a: {Vuelo.AeropuertoDestino} a las {Vuelo.FechaDeLlegada}");

    }

    pasaje.Vuelos = ListaDeVuelos;
    ListaDePasajes.Add(pasaje);

    Console.WriteLine($"Ver si funciona");

    
}

//return ListaDeVuelos;








//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;


//Console.WriteLine("Hello, World!");
//var options = new ChromeOptions();
//options.AddArgument("--headless=new");

//IWebDriver driver = new ChromeDriver();
////var driver = new ChromeDriver(options);

//string Origen = "VVI";
//string Destino = "CUN";
//string fechaIda = "2023-12-12";
//string fechaVuelta = "2023-12-20";

//// https://www.kiwi.com/es/buscar/results/VVI/CUN/2023-02-01/2023-02-08

//driver.Navigate().GoToUrl($"https://www.kiwi.com/es/buscar/results/{Origen}/{Destino}/{fechaIda}/{fechaVuelta}");

//var inputSearch =  driver.FindElement(By.XPath("//*[@id=\"cookie_consent\"]/div/div/div/div/button/div/div"));

//inputSearch.Click();

//List<dynamic> Lista1 = new List<dynamic>();

//Thread.Sleep(5000);


////var DivHoras1 = driver.FindElements(By.XPath("//div[@class='ResultCardItinerarystyled__SectorWrapper-sc-1swbl8-12 iKVnNX']"));
////var DivHoras2 = driver.FindElements(By.XPath("//div[@class='p-sm lm:px-md lm:py-sm']"));


//var DivHoras3 = driver.FindElements(By.XPath("//div[@class='flex flex-grow flex-col justify-center']"));




//int b = 0;

//foreach (var item in DivHoras3)
//{

//    //var horas2 = item.FindElements(By.XPath($".//time[contains(@datetime, '2023-09-12') or contains(@datetime, '2023-09-16') or contains(@datetime, '2023-09-17')]"));
//    var horas2 = item.FindElements(By.XPath(".//div[@data-test='ResultCardSectorRow']//time"));

//    var Lugares2 = item.FindElements(By.XPath(".//div[contains(@class, 'overflow-hidden text-ellipsis whitespace-nowrap font-medium text-ink-dark flex-grow')]"));





//    var SalidaDesde = Lugares2[0].Text;
//    var LugarDeLlegada = Lugares2[1].Text;
//    var horaSalida = horas2[0].Text;
//    var horaLlegada = horas2[1].Text;



//    if (b == 0)
//        {
//        Console.WriteLine("Itinerario de Ida");
//        Console.WriteLine($"Salida desde:{SalidaDesde}  a las: {horaSalida}");
//        Console.WriteLine($"Llegada a: {LugarDeLlegada} a las: {horaLlegada}");
//        b= 1;

//        }
//    else
//        {
//        Console.WriteLine("Itinerario de vuelta");
//        Console.WriteLine($"Salida desde: {SalidaDesde} a las: {horaSalida}");
//        Console.WriteLine($"Llegada a: {LugarDeLlegada}  a las: {horaLlegada}");
//        b = 0;


//    }


//}




