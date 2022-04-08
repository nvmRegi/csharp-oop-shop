using Csharp_Shop;

Console.WriteLine("BENVENUTI NEL MIO PROGRAMMA!\n");

int maxNumeroProdotti = 5;
int nProdotti = 0;

Prodotto[] arrayProdotti = new Prodotto[maxNumeroProdotti];

Prodotto prodotto1 = new Prodotto("Panino al prosciutto", "Questa è la descrizione del mio primo prodotto" ,10, 22);
arrayProdotti[0] = prodotto1;

Console.WriteLine("");

bool esecuzione = true;
while (esecuzione)
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
        case 2:
            stampaArray();

            Console.Write("\nVuoi visualizzare i dettagli di un prodotto?[s/n]");
            string scelta = Console.ReadLine();

            if(scelta == "s")
            {
                Console.Write("\nInserire il prodotto da visualizzare: ");
                int n = Convert.ToInt32(Console.ReadLine());

                arrayProdotti[n].stampaProdotto();                    
            }else if(scelta != "n")
            {
                Console.WriteLine("Opzione non valida!");
            }
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            Console.WriteLine("ARRIVEDERCI!");

            Console.ReadKey();
            esecuzione = false;
            break;
        default:
            Console.WriteLine("Scelta non valida!");
            Console.ReadKey();
            Console.Clear();
            break;



    }



}

//funzioni

void stampaArray()
{
    for(int i = 0; i < nProdotti + 1; i++)
    {
        Console.WriteLine(i + " - " + arrayProdotti[i].nome);
    }
}

