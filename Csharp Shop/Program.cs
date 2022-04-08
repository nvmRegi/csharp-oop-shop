using Csharp_Shop;

Console.WriteLine("BENVENUTI NEL MIO PROGRAMMA!\n");

int maxNumeroProdotti = 5;
int nProdotti = 1;

string[] nomeProdotti = new string[maxNumeroProdotti];

Prodotto prodotto1 = new Prodotto("Panino al prosciutto", 10, 22);

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

    Console.WriteLine("\nScelta: ");
    int risposta = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    switch (risposta)
    {
        case 0:
            if(nProdotti < maxNumeroProdotti)
            {
                Console.WriteLine("Inserisci il nome: ");
                string nomeProdotto = Console.ReadLine();
                Console.WriteLine("Inserisci una desceizione: ");
                string descrizioneProdotto = Console.ReadLine();
                Console.WriteLine("Inserisci il prezzo: ");
                double prezzoProdotto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inserisci l'IVA: ");
                double ivaProdotto = Convert.ToDouble(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Hai raggiunto il numero massimo di prodotti registrati");
            }
            break;
        case 1:



    }



}

//funzioni

void aggiungiProdotto ()

