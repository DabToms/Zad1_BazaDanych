using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAdapterForms.Core.Data;
public interface IData
{
    public int Get(int idx);
    public void Set(int idx, int value);
    public int Size();
}
