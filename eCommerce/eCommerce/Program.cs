
using eCommerce;
using static System.Runtime.InteropServices.JavaScript.JSType;

Prodotto P1 = new Prodotto("Philips", "A1", "13579"); //Creo l'oggetto P1 di tipo Prodotto
Prodotto P2 = new Prodotto("Philips", "A2", "13579"); //Creo l'oggetto P2 di tipo Prodotto
Prodotto P3 = new Prodotto("Philips", "A3", "13579"); //Creo l'oggetto P3 di tipo Prodotto
Prodotto P4 = new Prodotto("Philips", "A4", "13579"); //Creo l'oggetto P4 di tipo Prodotto
Prodotto P5 = new Prodotto("Philips", "A5", "13579"); //Creo l'oggetto P5 di tipo Prodotto
Prodotto P6 = new Prodotto("Philips", "A6", "13579"); //Creo l'oggetto P6 di tipo Prodotto

Carrello C = new Carrello("00001"); //Creo l'oggetto C di tipo Carrello

C.aggiungiProdotto(P2); //Aggiungo P2 alla lista
C.aggiungiProdotto(P5); //Aggiungo P5 alla lista
C.aggiungiProdotto(P6); //Aggiungo P6 alla lista

foreach (Prodotto numero in C.ProdottiCarrello)//Stamperà una lista con P2, P5 e P5
{
    Console.WriteLine(numero.Modello);
}

C.rimuoviProdotto(P2); //Rimuovo P2 dalla lista

C.rimuoviProdotto(P5); //Rimuovo P5 dalla lista

foreach (Prodotto numero in C.ProdottiCarrello)//Stamperà una lista con solo l'oggetto P6
{
    Console.WriteLine(numero.Modello);
}

C.svuotaCarrello(); //Svuoto il carrello

foreach (Prodotto numero in C.ProdottiCarrello) //Stamperà una lista vuota
{
    Console.WriteLine(numero.Modello);
}
