using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6_Strategy_Template.Strategia;
internal interface IStrategy
{
    void move(ref double x, ref double y, ref double vx, ref double vy);
    Color Color { get; set; }
}
