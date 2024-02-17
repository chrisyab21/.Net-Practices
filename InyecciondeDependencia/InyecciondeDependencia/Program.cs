// See https://aka.ms/new-console-template for more information
using InyecciondeDependencia;



IBebida PiñaColada = new PiñaColada();

IBebida Alfonso13 = new Alfonso13();

Cantinero Bartender = new Cantinero(PiñaColada);

Cantinero Bartender2 = new Cantinero(Alfonso13);

Bartender.PrepararBebida();

Bartender2.PrepararBebida();