using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProxyAdapterForms.Core.Data;

namespace ProxyAdapterForms.Core;
public class Baza : ICollection<IData>
{
    private List<IData> innerCol = new List<IData>();

    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(IData item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }
    public IData this[int index]
    {
        get { return innerCol[index]; }
        set { innerCol[index] = value; }
    }

    public bool Contains(IData item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(IData[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IData> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public bool Remove(IData item)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int index)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
