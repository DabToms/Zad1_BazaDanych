using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_BAzaDanych;

/// <summary>
/// Klasa bazy danych.
/// </summary>
public class DataBase
{
    /// <summary>
    /// Tablica znaków, będąca bazą danych.
    /// </summary>
    public char[] Table = new char[100];

    /// <summary>
    /// Pobranie połączenia do bazy danych.
    /// </summary>
    /// <returns>Połączenia do bazy danych.</returns>
    public static IConnection GetConnection()
    {
        return Connection.GetInstance();
    }

    /// <summary>
    /// Klasa udostępniająca połączenie do bazy danych.
    /// </summary>
    private class Connection : IConnection // klasa nie może by statyczna bo CS0714 https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs0714?f1url=%3FappId%3Droslyn%26k%3Dk(CS0714)
    {
        /// <summary>
        /// Baza danych powiązana z połączeniem.
        /// </summary>
        private static DataBase? Baza;

        /// <summary>
        /// Lista połączeń połączenie.
        /// </summary>
        private static IConnection[] Connections = new IConnection[] { new Connection(1), new Connection(2), new Connection(3) };

        /// <summary>
        /// Identyfikator identyfikujący połączenie;
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Licznik połączenia;
        /// </summary>
        private static int counter = Connections.Length - 1;

        /// <summary>
        /// Konstruktor inicjalizujący identyfikator połączenia.
        /// </summary>
        private Connection(int id)
        {
            Id = id;
        }

        /// <inheritdoc />
        public static IConnection GetInstance()
        {
            if (Baza == null)
            {
                Baza = new DataBase();
            }

            counter = ++counter % Connections.Length;
            return Connections[counter];

        }

        /// <inheritdoc />
        public char Get(int indeks)
        {
            if (Baza == null)
            {
                throw new ArgumentNullException(nameof(Baza));
            }

            return Baza.Table[indeks];
        }

        /// <inheritdoc />
        public void Set(int indeks, char c)
        {
            if (Baza == null)
            {
                throw new ArgumentNullException(nameof(Baza));
            }

            Baza.Table[indeks] = c;
        }

        /// <inheritdoc />
        public int Length()
        {
            if (Baza == null)
            {
                throw new ArgumentNullException(nameof(Baza));
            }

            return Baza.Table.Length;
        }

        /// <inheritdoc />
        public int GetGuid() => this.Id;
    }

}
