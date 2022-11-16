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
    private static readonly Image image = Image.FromFile("C:\\Users\\dabto\\Desktop\\Studia\\ZTP\\ChessForms\\ChessForms\\img\\pieces4.png");
    private int index, x, y;

    public Figure(int idx, int xx, int yy)
    {
        index = idx;
        x = xx;
        y = yy;
    }
    public void draw(Graphics g)
    {
        // tutaj pocięcie
        Rectangle sourceRect = new Rectangle(TILESIZE * this.index, 0, TILESIZE, TILESIZE);
        g.DrawImage(image, this.x, this.y, sourceRect, GraphicsUnit.Point);
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
