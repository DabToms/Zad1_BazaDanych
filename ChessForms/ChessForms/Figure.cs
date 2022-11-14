using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChessForms;
public class Figure
{
    public static readonly int TILESIZE = 32;
    private static readonly Image image = Image.FromFile("/img/pieces4.png");
    private int index, x, y;

    public Figure(int idx, int xx, int yy)
    {
        index = idx;
        x = xx;
        y = yy;
    }
    public void draw(Graphics g)
    {
        g.DrawImage(image, new Point(this.x, this.y));
    }
    public int GetX()
    {
        return x;
    }

    public int getY()
    {
        return y;
    }

    public void moveTo(int xx, int yy)
    {
        x = xx;
        y = yy;
    }
}
