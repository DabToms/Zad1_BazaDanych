using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_builder.Core.Segments;
public class SegmentBlock : Segment
{
    public SegmentBlock(int x, int y, String file)
        : base(x, y, file)
    {
    }

    public override void collisionV(Sprite sprite)
    {
        if (sprite.jumpingDown() && sprite.getBottomY() == y)
        {
            sprite.stopJump();
        }
    }
}
