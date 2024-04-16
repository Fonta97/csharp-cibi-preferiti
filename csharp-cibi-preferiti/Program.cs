namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array con cibi preferiti
            string[] cibiPreferiti = { "Pasta", "Tiramisù", "Sushi", "Pizza", "Fritto misto", "Plimenie", "Torta di mele", "Carciofi", "Aceto", "Carne di porcellino d'India" };

            // Creazione di un oggetto Random per generare il numero di elementi casuali
            Random rnd = new Random();

            // Numero casuale di elementi tra 5 e 10
            int numeroElementi = rnd.Next(5, 11);

            // Array casuale di cibi preferiti
            string[] listaCibiPreferitiRandom = new string[numeroElementi];

            // Riempimento dell'array casuale con cibi presi casualmente dalla lista originale
            for (int i = 0; i < numeroElementi; i++)
            {
                int index = rnd.Next(cibiPreferiti.Length);
                listaCibiPreferitiRandom[i] = cibiPreferiti[index];
            }

            // Stampa lunghezza classifica
            Console.WriteLine("La lunghezza della classifica è: " + listaCibiPreferitiRandom.Length);

            // Elenco classifica
            Console.WriteLine("La tua classifica:");

            // Ciclo for per stampare ogni cibo in classifica numerato
            for (int i = 0; i < listaCibiPreferitiRandom.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + listaCibiPreferitiRandom[i]);
            }

            // Stampo sia cibo preferito che quello preferito ma non troppo
            Console.WriteLine("Il tuo cibo preferito in assoluto è: " + listaCibiPreferitiRandom[0]);
            Console.WriteLine("Il tuo cibo preferito ma non troppo è: " + listaCibiPreferitiRandom[listaCibiPreferitiRandom.Length - 1]);

            // Mediana con il MOD e condizione if
            int indiceMedio = listaCibiPreferitiRandom.Length / 2;
            if (listaCibiPreferitiRandom.Length % 2 == 0) // Se il numero di elementi è pari
            {
                Console.WriteLine("I due cibi al centro della classifica sono:");
                Console.WriteLine(listaCibiPreferitiRandom[indiceMedio - 1]);
                Console.WriteLine(listaCibiPreferitiRandom[indiceMedio]);
            }
            else // Se il numero di elementi è dispari
            {
                Console.WriteLine("Il cibo di mezza classifica è: " + listaCibiPreferitiRandom[indiceMedio]);
            }

        }
    }
}
