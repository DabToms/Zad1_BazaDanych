using Factory.Core.TableDatas;

namespace Factory.Core.TableHeaders;

/// <summary>
/// Klasa nagłówka kolumny implementującej prototyp.
/// </summary>
public class TableHeaderPrototype : ITableHeader
{
    /// <summary>
    /// Obiekt typu danych.
    /// </summary>
    protected ITableData tableData;

    /// <summary>
    /// Konstruktor kolumny implementującej prototyp.
    /// </summary>
    /// <param name="prototype">Obiekt który będzie klonowany.</param>
    public TableHeaderPrototype(ITableData prototype)
    {
        tableData = prototype;
    }

    /// <inheritdoc />
    public ITableData Clone()
    {
        return (ITableData)tableData.Clone();
    }

    /// <inheritdoc />
    public ITableData CreateData()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Pobranie nazwy typu z tagiem prototypu.
    /// </summary>
    /// <returns>Nazwa typu.</returns>
    public override string ToString() => tableData.GetDataType() + "(P)";
}
