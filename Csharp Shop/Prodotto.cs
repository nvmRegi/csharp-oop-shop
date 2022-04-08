using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop
{
    internal class Prodotto
    {
        private int codice;
        public string nome;
        public string descrizione;
        public double prezzo;
        public double iva;

        public int codiceNuovoProdotto
        {
            set
            {
                Random r = new Random();
                codice = r.Next();
                Console.WriteLine("Codice: " + codice);
            }
            get
            {
                return codice;
            }
        }

        public void stampaPrezzoBase()
        { 
            Console.WriteLine("Il prezzo di base è: " + prezzo + " euro");
        }

        public void calcoloIva()
        {
            double risultato = Math.Round(prezzo * 0.22 + prezzo, 2);
            Console.WriteLine("Il prezzo con Iva è: " + risultato + " euro");
        }

        

    }
}
