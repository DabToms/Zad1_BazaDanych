using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_builder.Core.Segments;
public class SegmentBlockV : Segment
{
    public SegmentBlockV(int x, int y, String file)
        : base(x, y, file)
    {
    }

    public override void collisionV(Sprite sprite)
    {
        sprite.stopJump();
    }


    public override void collisionH(Sprite sprite)
    {
        sprite.stopMove();
    }
}
