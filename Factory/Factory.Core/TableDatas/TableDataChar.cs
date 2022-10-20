namespace Factory.Core.TableDatas;

/// <summary>
/// Obiekt tableli przechowujący dane typu CHAR.
/// </summary>
public class TableDataChar : AbstractTableData
{
    /// <summary>
    /// Dane.
    /// </summary>
    private char data;

    /// <summary>
    /// Konstruktor inicjalizujący dane.
    /// </summary>
    public TableDataChar()
    {
        data = (char)rnd.Next(0, 127);
    }

    /// <inheritdoc />
    public override ITableData CreateData()
    {
        return this;
    }

    /// <inheritdoc />
    public override string GetDataType()
    {
        return typeof(char).ToString().Split('.')[1].ToUpper();
    }

    /// <summary>
    /// Pobranie danych.
    /// </summary>
    /// <returns>Dane intiger.</returns>
    public override string ToString() => data.ToString();
}
