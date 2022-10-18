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
    /// Instancja bazy danych.
    /// </summary>
    private static DataBase Baza = new DataBase();

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
        return Connection2.GetInstance();
    }

    public static DataBase GetInstance()
    {
        return Baza;
    }

    /// <summary>
    /// Klasa udostępniająca połączenie do bazy danych.
    /// </summary>
    private class Connection2 : IConnection
    {
        /// <summary>
        /// Baza danych powiązana z połączeniem.
        /// </summary>
        private DataBase Baza;

        /// <summary>
        /// Lista połączeń połączenie.
        /// </summary>
        private static IConnection[] Connections = new IConnection[] { new Connection2(1), new Connection2(2), new Connection2(3) };

        /// <summary>
        /// Identyfikator identyfikujący połączenie;
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Licznik połączenia.
        /// </summary>
        private static int counter = Connections.Length - 1;

        /// <summary>
        /// Konstruktor inicjalizujący identyfikator połączenia.
        /// </summary>
        private Connection2(int id)
        {
            Baza = DataBase.GetInstance();
            Id = id;
        }

        /// <inheritdoc />
        public static IConnection GetInstance()
        {
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

            Baza.Table[indeks] = (char)(c + 10);
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
    /// <summary>
    /// Klasa udostępniająca połączenie do bazy danych.
    /// </summary>
    private class Connection : IConnection
    {
        /// <summary>
        /// Baza danych powiązana z połączeniem.
        /// </summary>
        private DataBase Baza;

        /// <summary>
        /// Lista połączeń połączenie.
        /// </summary>
        private static IConnection[] Connections = new IConnection[] { new Connection(1), new Connection(2), new Connection(3) };

        /// <summary>
        /// Identyfikator identyfikujący połączenie;
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Licznik połączenia.
        /// </summary>
        private static int counter = Connections.Length - 1;

        /// <summary>
        /// Konstruktor inicjalizujący identyfikator połączenia.
        /// </summary>
        private Connection(int id)
        {
            Baza = DataBase.GetInstance();
            Id = id;
        }

        /// <inheritdoc />
        public static IConnection GetInstance()
        {
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
