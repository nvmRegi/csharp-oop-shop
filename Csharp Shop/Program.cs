using Csharp_Shop;

Console.WriteLine("BENVENUTI NEL MIO PROGRAMMA!\n");

int maxNumeroProdotti = 5;
int nProdotti = 1;

Prodotto[] arrayProdotti = new Prodotto[maxNumeroProdotti];

Prodotto prodotto1 = new Prodotto("Panino al prosciutto", "Questa è la descrizione del mio primo prodotto" ,10, 22);
arrayProdotti[0] = prodotto1;

Console.WriteLine(prodotto1.getCodice());

prodotto1.stampaPrezzoBase();

prodotto1.calcoloIva();
prodotto1.stampaNomeEsteso();
Console.WriteLine(arrayProdotti[0].nome);
Console.WriteLine("");
while (true)
{
    Console.WriteLine("Scegli un'opzione: ");
    Console.WriteLine("0 - Aggiungi un nuovo prodotto");
    Console.WriteLine("1 - Rimuovi un prodotto");
    Console.WriteLine("2 - Visualizza i prodotti registrati");
    Console.WriteLine("3 - Esci dal programma");

    Console.Write("\nScelta: ");
    int risposta = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    switch (risposta)
    {
        case 0:
            if(nProdotti < maxNumeroProdotti)
            {
                nProdotti++;

                Console.Write("Inserisci il nome: ");
                string nomeProdotto = Console.ReadLine();
                Console.Write("Inserisci una descrizione: ");
                string descrizioneProdotto = Console.ReadLine();
                Console.Write("Inserisci il prezzo: ");
                double prezzoProdotto = Convert.ToDouble(Console.ReadLine());
                Console.Write("Inserisci l'IVA: ");
                double ivaProdotto = Convert.ToDouble(Console.ReadLine());

                Prodotto prodotto = new Prodotto(nomeProdotto, descrizioneProdotto, prezzoProdotto, ivaProdotto);
                arrayProdotti[nProdotti] = prodotto;

                Console.Clear();
                arrayProdotti[nProdotti].stampaProdotto();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Hai raggiunto il numero massimo di prodotti registrati");
                Console.ReadKey();
                Console.Clear();
            }
            break;
        case 1:
            if(nProdotti > 0)
            {
                stampaArray();
                arrayProdotti[nProdotti] = null;

                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Non ci sono più prodotti da rimuovere!");
                Console.ReadKey();
                Console.Clear();
            }

            break;


    }



}

//funzioni

void stampaArray()
{
    Console.WriteLine("Verrà rimosso l'ultimo elemento della lista: ");
    for(int i = 0; i < nProdotti + 1; i++)
    {
        Console.WriteLine(i + " - " + arrayProdotti[i].nome);
    }
}

