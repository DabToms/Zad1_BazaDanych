namespace Zad1_BAzaDanych;

internal class Program
{
    static void Main(string[] args)
    {
        // nawiązanie połączeń
        var connection1 = DataBase.GetConnection();
        var connection2 = DataBase.GetConnection();
        var connection3 = DataBase.GetConnection();
        var connection4 = DataBase.GetConnection();

        // Wypisanie identyfikatorów połączeń
        Console.WriteLine($"Id połączenia {nameof(connection1)} : {connection1.GetGuid()}");
        Console.WriteLine($"Id połączenia {nameof(connection2)} : {connection2.GetGuid()}");
        Console.WriteLine($"Id połączenia {nameof(connection3)} : {connection3.GetGuid()}");
        Console.WriteLine($"Id połączenia {nameof(connection4)} : {connection4.GetGuid()}\n");

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Na pozycji {i} przechowujemy:");
            Console.WriteLine($"W {nameof(connection1)} znak: {connection1.Get(i)}");
            Console.WriteLine($"W {nameof(connection2)} znak: {connection2.Get(i)}");
            Console.WriteLine($"W {nameof(connection3)} znak: {connection3.Get(i)}");
            Console.WriteLine($"W {nameof(connection4)} znak: {connection4.Get(i)}");
        }

        // ustawienie danych w bazie danych
        connection1.Set(0, 'q');
        Console.WriteLine($"\nUstawienie w {nameof(connection1)} na pozycji {0} znaku {'q'}");
        connection2.Set(1, 'w');
        Console.WriteLine($"Ustawienie w {nameof(connection2)} na pozycji {1} znaku {'w'}");
        connection3.Set(2, 'e');
        Console.WriteLine($"Ustawienie w {nameof(connection3)} na pozycji {2} znaku {'e'}");
        connection4.Set(3, 'r');
        Console.WriteLine($"Ustawienie w {nameof(connection4)} na pozycji {3} znaku {'r'}\n");


        // Wypisanie wpisanych danych z każdego połączenia w celu pokazania, że mamy tylko 1 bazę i tylko 3 połączenia
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Na pozycji {i} przechowujemy:");
            Console.WriteLine($"W {nameof(connection1)} znak: {connection1.Get(i)}");
            Console.WriteLine($"W {nameof(connection2)} znak: {connection2.Get(i)}");
            Console.WriteLine($"W {nameof(connection3)} znak: {connection3.Get(i)}");
            Console.WriteLine($"W {nameof(connection4)} znak: {connection4.Get(i)}");
        }

        int index = 2;
        char insertedChar = 'g';
        Console.WriteLine($"\nOdczytanie w połączeniach {nameof(connection3)} i {nameof(connection1)} pozycji {index}");
        Console.WriteLine($"W połączeniu {nameof(connection3)} na pozycji {index} przechowujemy znak: {connection3.Get(index)}");
        Console.WriteLine($"W połączeniu {nameof(connection1)} na pozycji {index} przechowujemy znak: {connection1.Get(index)}");
        Console.WriteLine($"Ustawienie w połączeniu {nameof(connection3)} na pozycji {index} znaku {insertedChar}");
        connection3.Set(2, insertedChar);
        Console.WriteLine($"W połączeniu {nameof(connection3)} na pozycji {index} przechowujemy znak: {connection3.Get(index)}");
        Console.WriteLine($"W połączeniu {nameof(connection1)} na pozycji {index} przechowujemy znak: {connection1.Get(index)}");

        // dowód na posiadanie tej samej referencji
        Console.WriteLine($"\nCzy {nameof(connection1)} i {nameof(connection4)} nają tę samą referencję: {Object.ReferenceEquals(connection1, connection4)}");
        Console.WriteLine($"Czy {nameof(connection1)} i {nameof(connection3)} nają tę samą referencję: {Object.ReferenceEquals(connection1, connection3)}");
    }
}
