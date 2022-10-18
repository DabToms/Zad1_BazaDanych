using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Core;
public class TableHeader
{
    /// <summary>
    /// Nazwa typu.
    /// </summary>
    private string type;

    public TableHeader(string type)
    {
        this.type = type;
    }

    /// <summary>
    /// Pobranie nazwy typu.
    /// </summary>
    /// <returns>Nazwa typu.</returns>
    public override string ToString() => type;
}
