using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace Zad3_builder.Core.Segments;
public class Segment
{
    protected Image img;
    protected int x;
    protected int y;
    protected int W;
    protected int H;

    public Segment(int x, int y, String file)
    {
        this.x = x;
        this.y = y;
        img = ImgUtils.getImage(file);
        W = img.getWidth(null);
        H = img.getHeight(null);
    }

    public Rectangle getBounds()
    {
        return new Rectangle(x, y, W, H);
    }

    public void draw(Graphics g)
    {
        g.drawImage(img, x, y, null);
    }

    public void tick()
    {
    }

    public virtual void collisionV(Sprite sprite)
    {
    }

    public virtual void collisionH(Sprite sprite)
    {
    }
}
