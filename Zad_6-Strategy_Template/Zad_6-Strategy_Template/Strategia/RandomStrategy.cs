using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6_Strategy_Template.Strategia;
internal class RandomStrategy : AbstractStrategy
{
    public RandomStrategy(Color color) : base(color)
    {
    }
    public override void move(ref double x, ref double y, ref double vx, ref double vy)
    {
        var rnd = new Random();

        double vLenght = Math.Sqrt(vx * vx + vy * vy);

        vx = rnd.Next((int)Math.Floor(vLenght));
        vy = Math.Sqrt(vLenght * vLenght - vx * vx);

        vx *= rnd.Next() % 2 == 0 ? 1 : -1;
        vy *= rnd.Next() % 2 == 0 ? 1 : -1;
        base.move(ref x, ref y, ref vx, ref vy);
    }
}
