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

        // ustawienie danych w bazie danych
        connection1.Set(0, 'q');
        connection2.Set(1, 'w');
        connection3.Set(2, 'e');
        connection4.Set(3, 'r');

        Console.WriteLine($"GUID połączenia {nameof(connection1)} : {connection1.GetGuid()}");
        Console.WriteLine($"GUID połączenia {nameof(connection2)} : {connection2.GetGuid()}");
        Console.WriteLine($"GUID połączenia {nameof(connection3)} : {connection3.GetGuid()}");
        Console.WriteLine($"GUID połączenia {nameof(connection4)} : {connection4.GetGuid()}");

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"W połączeniu {nameof(connection1)} na pozycji {i} przechowujemy znak: {connection1.Get(i)}");
            Console.WriteLine($"W połączeniu {nameof(connection2)} na pozycji {i} przechowujemy znak: {connection2.Get(i)}");
            Console.WriteLine($"W połączeniu {nameof(connection3)} na pozycji {i} przechowujemy znak: {connection3.Get(i)}");
            Console.WriteLine($"W połączeniu {nameof(connection4)} na pozycji {i} przechowujemy znak: {connection4.Get(i)}");
        }
    }
}
