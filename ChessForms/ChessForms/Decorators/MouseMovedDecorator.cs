using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessForms.Figures;

namespace ChessForms.Decorators;
public class MouseMovedDecorator : AbstractDecorator
{
    public MouseMovedDecorator(IFigureFlyWeight fig) : base(fig)
    {
    }
    public override void draw(Graphics g,Point coordinates)
    {
        g.TranslateTransform(ChessboardForms.ZEROX, ChessboardForms.ZEROY);
        g.ScaleTransform(AbstractFigure.TILESIZE, AbstractFigure.TILESIZE);
        base.draw(g, coordinates);
        g.TranslateTransform(0, 0);
        g.ScaleTransform(1, 1);
    }
}
