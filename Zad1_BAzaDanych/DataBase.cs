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
    /// <returns></returns>
    public static IConnection GetConnection()
    {
        return Connection.GetInstance();
    }

    private class Connection : IConnection // klasa nie może by statyczna bo CS0714 https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs0714?f1url=%3FappId%3Droslyn%26k%3Dk(CS0714)
    {
        /// <summary>
        /// Baza danych powiązana z połączeniem.
        /// </summary>
        private static DataBase? Baza;

        /// <summary>
        /// Pierwsze połączenie.
        /// </summary>
        private static IConnection? Connection1 { get; set; }

        /// <summary>
        /// Drugie połączenie.
        /// </summary>
        private static IConnection? Connection2 { get; set; }

        /// <summary>
        /// Trzecie połączenie.
        /// </summary>
        private static IConnection? Connection3 { get; set; }

        /// <summary>
        /// Identyfikator identyfikujący połączenie;
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Licznik połączenia;
        /// </summary>
        private static int counter = 0;

        private Connection()
        {
            Id = Guid.NewGuid();
        }

        /// <inheritdoc />
        public static IConnection GetInstance()
        {
            if (Baza == null)
            {
                Baza = new DataBase();
            }

            counter = ++counter % 3;

            switch (counter%3)
            {
                case 0:
                    if (Connection1 == null)
                    {
                        Connection1 = new Connection();
                    }
                    return Connection1;
                case 1:
                    if (Connection2 == null)
                    {
                        Connection2 = new Connection();
                    }
                    return Connection2;
                case 2:
                    if (Connection3 == null)
                    {
                        Connection3 = new Connection();
                    }
                    return Connection3;
                default:
                    return new Connection();
            }

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
        public Guid GetGuid() => this.Id;
    }

}
