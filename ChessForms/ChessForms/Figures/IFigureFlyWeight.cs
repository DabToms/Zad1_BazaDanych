using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessForms.Figures;
public interface IFigureFlyWeight
{
    void draw(Graphics g, Point coorginates);
    IFigureFlyWeight Unbox();
}
