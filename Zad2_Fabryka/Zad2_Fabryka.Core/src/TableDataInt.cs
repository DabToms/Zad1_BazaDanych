using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_Fabryka;
public class TableDataInt : AbstractTableData
{
    /// <summary>
    /// Dane.
    /// </summary>
    private int data;

    /// <summary>
    /// Konstruktor
    /// </summary>
    public TableDataInt()
    {
        data = rnd.Next(0, 100);
    }

    /// <summary>
    /// Pobranie danych.
    /// </summary>
    /// <returns>Dane intiger.</returns>
    public override string ToString() => data.ToString();
}
