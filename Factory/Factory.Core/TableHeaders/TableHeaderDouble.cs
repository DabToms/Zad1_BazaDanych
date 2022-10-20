using Factory.Core.TableDatas;

namespace Factory.Core.TableHeaders;
public class TableHeaderDouble : TableHeader
{
    public TableHeaderDouble()
    {
        this.type = typeof(double).ToString();
    }

    /// <inheritdoc />
    public override ITableData CreateData()
    {
        return new TableDataDouble();
    }
}
