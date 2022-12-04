using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zad_6_Strategy_Template.Strategia;

namespace Zad_6_Strategy_Template;

internal class Mucha
{
    private readonly double k = 0.01;
    public double x, y; // pozycja muchy
    public double vx, vy; // predkosc muchy
    IStrategy strategy;

    public Mucha(IStrategy strategy)
    {
        var rand = new Random();
        x = rand.Next(600);
        y = rand.Next(600);
        vx = rand.Next(8) ;
        vy = rand.Next(8);
        this.strategy = strategy;
    }

    public void draw(Graphics g)
    {
        g.DrawRectangle(new Pen(new SolidBrush(this.strategy.Color)), new Rectangle((int)x, (int)y, 5, 5));
    }

    public void move()
    {
        // push
        this.strategy.move(ref x, ref y, ref vx, ref vy);
    }

    public void ChangeStrategy(IStrategy strategy)
    {
        this.strategy = strategy;
    }
}
