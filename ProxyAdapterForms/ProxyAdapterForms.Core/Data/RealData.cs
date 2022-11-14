using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAdapterForms.Core.Data;
public class RealData: IData
{
    public RealData(int size)
    {
    }

    public int Get(int idx)
    {
        throw new NotImplementedException();
    }

    public void Set(int idx, int value)
    {
        throw new NotImplementedException();
    }

    public int Size()
    {
        throw new NotImplementedException();
    }
}
