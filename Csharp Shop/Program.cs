using Csharp_Shop;

Console.WriteLine("BENVENUTI NEL MIO PROGRAMMA!\n");

int maxNumeroProdotti = 5;
int nProdotti = 1;

Prodotto[] arrayProdotti = new Prodotto[maxNumeroProdotti];

Prodotto prodotto1 = new Prodotto("Panino al prosciutto", "Questa è la descrizione del mio primo prodotto" ,10, 22);

Console.WriteLine(prodotto1.getCodice());

prodotto1.stampaPrezzoBase();

prodotto1.calcoloIva();
prodotto1.stampaNomeEsteso();
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
            }
            break;



    }



}

//funzioni

//void aggiungiProdotto ()

