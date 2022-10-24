using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_builder.Core.Segments;

public class SegmentAnim : Segment
{
    private readonly int[] anim;

    public SegmentAnim(int x, int y, String file, int[] sequence)
        : base(x, y, file)
    {
        anim = sequence;
    }
    public int frame = 0;


    public override void tick()
    {
        frame++;
        while (frame >= anim.Length)
        {
            frame -= anim.Length;
        }
    }


    public override void draw(Graphics g)
    {
        g.drawImage(img, x, y, x + W, y + H / 4, 0, anim[frame] * H / 4, W, anim[frame] * H / 4 + H / 4, null);
    }

}