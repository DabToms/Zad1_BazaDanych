using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Core;
public abstract class AbstractTableData: ITableData
{
    public Random rnd = new Random();
}
