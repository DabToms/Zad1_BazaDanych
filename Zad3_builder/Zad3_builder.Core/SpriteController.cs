using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zad3_builder.Core.Segments;

namespace Zad3_builder.Core;
public class SpriteController
{
    private readonly Sprite sprite;
    private readonly List<Segment> plansza;
    private readonly JPanel panel;

    public SpriteController(Sprite sp, List<Segment> pl, JPanel pan)
    {
        sprite = sp;
        plansza = pl;
        panel = pan;
    }

    public void run()
    {
        while (true)
        {
            sprite.tick();
            foreach(var s in plansza)
            {
                s.tick();
            }
            panel.repaint();
            Thread.Yield();
            try
            {
                Thread.Sleep(30);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }

}
