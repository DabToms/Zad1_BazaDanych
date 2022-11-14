using System.Drawing;

namespace Zad3_builder.Core.Segments;
public class Segment
{
    protected Image img;
    protected int x;
    protected int y;
    protected int W;
    protected int H;

    public Segment(int x, int y, string file)
    {
        this.x = x;
        this.y = y;
        img = Image.FromFile(file);
        W = img.Width;
        H = img.Height;
    }

    public Rectangle getBounds()
    {
        return new Rectangle(x, y, W, H);
    }

    public virtual void draw(Graphics g)
    {
        g.DrawImage(img, new Point(this.x, this.y));
    }

    public virtual void tick()
    {
    }

    public virtual void collisionV(Sprite sprite)
    {
    }

    public virtual void collisionH(Sprite sprite)
    {
    }
}
