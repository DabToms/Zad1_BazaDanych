namespace Factory.Core.TableDatas;

/// <summary>
/// Obiekt tableli przechowujący dane typu DOUBLE.
/// </summary>
public class TableDataDouble : AbstractTableData
{
    /// <summary>
    /// Dane.
    /// </summary>
    private double data;

    /// <summary>
    /// Konstruktor inicjalizujący dane.
    /// </summary>
    public TableDataDouble()
    {
        data = rnd.NextDouble();
    }

    /// <inheritdoc />
    public override ITableData CreateData()
    {
        return this;
    }

    /// <inheritdoc />
    public override string GetDataType()
    {
        return typeof(double).ToString().Split('.')[1].ToUpper();
    }

    /// <summary>
    /// Pobranie danych.
    /// </summary>
    /// <returns>Dane intiger.</returns>
    public override string ToString() => data.ToString();
}
