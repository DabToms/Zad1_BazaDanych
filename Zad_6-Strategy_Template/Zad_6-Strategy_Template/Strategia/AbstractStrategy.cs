using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6_Strategy_Template.Strategia;
internal abstract class AbstractStrategy : IStrategy
{
    public AbstractStrategy(Color color)
    {
        this.Color = color;
    }

    public Color Color { get; set; }

    public virtual void move(ref double x, ref double y, ref double vx, ref double vy)
    {
        x += vx;
        y += vy;
        if (x < 0) { x += vx; vx = -vx; }
        if (x > 480) { x -= vx; vx = -vx; }
        if (y < 0) { y += vy; vy = -vy; }
        if (y > 480) { y -= vy; vy = -vy; }
    }
}
