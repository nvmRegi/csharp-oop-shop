using Csharp_Shop;

Prodotto nuovoProdotto = new Prodotto();

nuovoProdotto.prezzo = 10;
nuovoProdotto.nome = "Panino al prosciutto";
nuovoProdotto.stampaPrezzoBase();

nuovoProdotto.calcoloIva();
Console.WriteLine(nuovoProdotto.codiceNuovoProdotto);
//nuovoProdotto.stampaNomeEsteso();
