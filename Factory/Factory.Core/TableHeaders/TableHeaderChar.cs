using Factory.Core.TableDatas;

namespace Factory.Core.TableHeaders;
public class TableHeaderChar : AbstractTableHeader
{
    public TableHeaderChar()
    {
        this.type = typeof(char).ToString();
    }

    /// <inheritdoc />
    public override ITableData CreateData()
    {
        return new TableDataChar();
    }
}
