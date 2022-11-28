using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChessForms.Figures;
public class FigureFlyWeight : IFigureFlyWeight
{
    private readonly Image image = Image.FromFile("C:\\Users\\dabto\\Desktop\\Studia\\ZTP\\ChessForms\\ChessForms\\img\\pieces4.png");
    private int index;
    public static Dictionary<int, FigureFlyWeight> map = new Dictionary<int, FigureFlyWeight>();

    public static FigureFlyWeight getFigure(int idx)
    {
        if (!map.ContainsKey(idx))
        {
            map.Add(idx, new FigureFlyWeight(idx));
        }
        return map[idx];
    }

    private FigureFlyWeight(int idx)
    {
        index = idx;
    }
    public void draw(Graphics g, Point point)
    {
        Rectangle sourceRect = new Rectangle(AbstractFigure.TILESIZE * index, 0, AbstractFigure.TILESIZE, AbstractFigure.TILESIZE);
        g.DrawImage(image, point.X * AbstractFigure.TILESIZE, point.Y * AbstractFigure.TILESIZE, sourceRect, GraphicsUnit.Pixel);
    }

    public IFigureFlyWeight Unbox()
    {
        return this;
    }
}
