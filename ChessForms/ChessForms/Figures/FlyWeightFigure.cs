using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessForms.Figures;
public class FlyWeightFigure : IFigureFlyWeight
{
    private static Dictionary<int, FlyWeightFigure> figures = new Dictionary<int, FlyWeightFigure>();

    private int index;
    private readonly Image image = Image.FromFile("C:\\Users\\dabto\\Desktop\\Studia\\ZTP\\Zad1_BAzaDanych\\ChessForms\\ChessForms\\img\\pieces4.png");
    private FlyWeightFigure(int index)
    {
        this.index =index;
    }

    public static FlyWeightFigure GetFigure(int index)
    {
        if (!figures.ContainsKey(index))
        {
            figures.Add(index, new FlyWeightFigure(index));
        }
        return figures[index];
    }

    public void draw(Graphics g, Point coordinates)
    {
        Rectangle sourceRect = new Rectangle(AbstractFigure.TILESIZE * this.index, 0, AbstractFigure.TILESIZE, AbstractFigure.TILESIZE);
        g.DrawImage(this.image, coordinates.X * AbstractFigure.TILESIZE, coordinates.Y*AbstractFigure.TILESIZE, sourceRect, GraphicsUnit.Pixel);
    }

    public IFigureFlyWeight Unbox()
    {
        return this;
    }
}
