using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6_Strategy_Template.Strategia;
internal class CircleStrategy : AbstractStrategy
{
    public CircleStrategy(Color color) : base(color)
    {
    }
    int angle = 0;
    public override void move(ref double x, ref double y, ref double vx, ref double vy)
    {
        vx = 0;
        vy = 0;
        x += 15 * Math.Sin(angle * Math.PI / 180);
        y += 15 * Math.Cos(angle * Math.PI / 180);
        angle += 1;
        if (angle == 360)
        {
            angle = 0;
        }
        base.move(ref x, ref y, ref vx, ref vy);
    }
}
