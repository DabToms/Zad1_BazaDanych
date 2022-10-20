namespace Factory.Core.TableDatas;

/// <summary>
/// Obiekt tableli przechowujący dane typu BOOL.
/// </summary>
public class TableDataBool : AbstractTableData
{
    /// <summary>
    /// Dane.
    /// </summary>
    private bool data;

    /// <summary>
    /// Konstruktor inicjalizujący dane.
    /// </summary>
    public TableDataBool()
    {
        data = rnd.Next(0, 100) % 2 == 0;
    }

    /// <inheritdoc />
    public override ITableData CreateData()
    {
        return this;
    }

    /// <inheritdoc />
    public override string GetDataType()
    {
        return typeof(bool).ToString().Split('.')[1].ToUpper();
    }

    /// <summary>
    /// Pobranie danych.
    /// </summary>
    /// <returns>Dane intiger.</returns>
    public override string ToString() => data.ToString();
}
