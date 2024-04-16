namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //creazione array di cibi
            string[] cibiPreferiti = { "Pasta", "Tiramisù", "Sushi", "Pizza", "Fritto misto", "Plimenie", "Torta di mele", "Carciofi", "Aceto", "Carne di porcellino d'India" };

            //stampo lunghezza classifica
            Console.WriteLine("La lunghezza della classifica è: " + cibiPreferiti.Length);

            //elenco classifica
            Console.WriteLine("La tua classifica:");

            //ciclo for per stampare ogni cibo in classifica numerato
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + cibiPreferiti[i]);
            }

            //stampo sia cibo prefe che quello prefe ma non troppo
            Console.WriteLine("Il tuo cibo preferito in assoluto è: " + cibiPreferiti[0]);
            Console.WriteLine("Il tuo cibo preferito ma non troppo è: " + cibiPreferiti[cibiPreferiti.Length - 1]); //ricordiamoci di fare length - 1 perchè altrimenti stamperebbe l'array + 1 non esistente


            //mediana con il MOD e condizione if
            int indiceMedio = cibiPreferiti.Length / 2;
            if (cibiPreferiti.Length % 2 == 0) // Se il numero di elementi è pari
            {
                Console.WriteLine("I due cibi al centro della classifica sono:");
                Console.WriteLine(cibiPreferiti[indiceMedio - 1]);
                Console.WriteLine(cibiPreferiti[indiceMedio]);
            }
            else // Se il numero di elementi è dispari
            {
                Console.WriteLine("Il cibo di mezza classifica è: " + cibiPreferiti[indiceMedio]);
            }
        }
    }
}
