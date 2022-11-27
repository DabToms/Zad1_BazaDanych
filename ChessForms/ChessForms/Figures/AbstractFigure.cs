using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessForms.Figures;
public abstract class AbstractFigure : IFigure
{
    public static readonly int TILESIZE = 32;

    public AbstractFigure(int idx)
    {
        Index = idx;
    }
    public virtual int Index { get; set; }
    public abstract void draw(Graphics g);


    public IFigure Unbox()
    {
        return this;
    }
}
