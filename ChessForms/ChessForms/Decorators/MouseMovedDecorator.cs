using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessForms.Figures;

namespace ChessForms.Decorators;
public class MouseMovedDecorator : AbstractDecorator
{
    public MouseMovedDecorator(IFigure fig) : base(fig)
    {
    }
    public override void draw(Graphics g)
    {
        g.TranslateTransform(ChessboardForms.ZEROX, ChessboardForms.ZEROY);
        g.ScaleTransform(AbstractFigure.TILESIZE, AbstractFigure.TILESIZE);
        base.draw(g);
        g.TranslateTransform(0, 0);
        g.ScaleTransform(1, 1);
    }
}
