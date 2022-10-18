using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_Fabryka;
public class Database : AbstractTableModel
{
    /// <summary>
    /// Lista nagłówków.
    /// </summary>
    private List<TableHeader> headers;

    /// <summary>
    /// Wiersz z danymi(mogą być różnego typów).
    /// </summary>
    private List<List<ITableData>> data;

    /// <summary>
    /// Konstruktor klasy Database.
    /// </summary>
    public Database()
    {
        headers = new List<TableHeader>();
        data = new List<List<ITableData>>();
    }

    /// <summary>
    /// Dodanie wiersza.
    /// </summary>
    public void addRow()
    {
        List<ITableData> row = new List<ITableData>();
        foreach (var col in headers)
        {
            row.Add(new TableDataInt()); // wywołanie metody fabrykującej
        }
        data.Add(row);
        //fireTableStructureChanged();
    }

    /// <summary>
    /// Dodanie kolumny.
    /// </summary>
    /// <param name="type">Nagłówke przechowujący typ.</param>
    public void addCol(TableHeader type)
    {
        headers.Add(type);
        foreach (var row in data)
        {
            row.Add(new TableDataInt()); // wywołanie metody fabrykującej
        }
        //fireTableStructureChanged();
    }

    /// <summary>
    /// Pobranie ilości wierszy.
    /// </summary>
    /// <returns>Ilość wierszy.</returns>
    public int getRowCount() => data.Count();

    /// <summary>
    /// Pobranie ilości kolumn.
    /// </summary>
    /// <returns>Ilość kolumn.</returns>
    public int getColumnCount() => headers.Count();

    /// <summary>
    /// Pobierz nazwe kolumny.
    /// </summary>
    /// <param name="column">Index kolumny.</param>
    /// <returns>Nazwa kolumny.</returns>
    public string getColumnName(int column) => headers[column].ToString();

    /// <summary>
    /// Pobranie wartości przecowywanej wartości w kolumnie i wierszu.
    /// </summary>
    /// <param name="row">Indeks wiersza.</param>
    /// <param name="column">Index kolumny.</param>
    /// <returns>Obiekt danych.</returns>
    public object getValueAt(int row, int column) => data[row][column];
}
