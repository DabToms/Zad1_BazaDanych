using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zad_6_Strategy_Template.Strategia;

namespace Zad_6_Strategy_Template;

internal class Mucha2
{
    private readonly double k = 0.01;
    public double x, y; // pozycja muchy
    public double vx, vy; // predkosc muchy

    public Mucha2(Color color)
    {
        var rand = new Random();
        x = rand.Next(600);
        y = rand.Next(600);
        vx = rand.Next(8) ;
        vy = rand.Next(8);
        Strategy.Color = color;
    }

    public void draw(Graphics g)
    {
        g.DrawRectangle(new Pen(new SolidBrush(Strategy.Color)), new Rectangle((int)x, (int)y, 5, 5));
    }

    public void move()
    {
        // push
        Strategy.move(this);
    }

    private static class Strategy
    {
        public static Color Color { get; set; }

        public static void move(Mucha2 m)
        {
            var rnd = new Random();

            double vLenght = Math.Sqrt(m.vx * m.vx + m.vy * m.vy);

            m.vx = rnd.Next((int)Math.Floor(vLenght));
            m.vy = Math.Sqrt(vLenght * vLenght - m.vx * m.vx);

            m.vx *= rnd.Next() % 2 == 0 ? 1 : -1;
            m.vy *= rnd.Next() % 2 == 0 ? 1 : -1;
        }
    }
}
