using Zad3_builder.Core.Segments;
using Zad3_builder.Core;

namespace Zad3_builder;

public class Game
{
    private readonly int TILESIZE = 32;
    private readonly List<Segment> plansza;
    private readonly Sprite sprite;

    public Game(string plik)
    {
        // to załatwią formsy
        setPreferredSize(new Dimension(424, 268));
        setFocusable(true);
        plansza = stworzPlansze(plik);
        sprite = new Sprite(plansza, "mario.png");

       
        new Thread(new SpriteController(sprite, plansza, this)).start();
    });

     // to załatwią formsy
     //@Override
     public void paint(Graphics g)
    {
        base.paint(g);
        foreach (var s in plansza)
        {
            s.draw(g);
        }
        sprite.draw(g);



    }

    private List<Segment> stworzPlansze(string plik)
    {
        try
        {
            var br = File.ReadLines(plik);
            var plansza = new List<Segment>();
            int x;
            int y = 4;
            int liczba;
            int znaki;
            char znak;
            char cyfra1;
            char cyfra2;
            foreach (string linia in br)
            {
                x = 4;
                znaki = 0;
                while ((linia.Length - znaki) >= 3)
                {
                    znak = linia.ElementAt(znaki++);
                    cyfra1 = linia.ElementAt(znaki++);
                    cyfra2 = linia.ElementAt(znaki++);
                    liczba = (cyfra1 - '0') * 10 + (cyfra2 - '0');
                    switch (znak)
                    {
                        case 'X':
                            x += liczba * TILESIZE;
                            break;
                        case 'A':
                            for (int i = 0; i < liczba; ++i)
                            {
                                Segment s = new SegmentBlock(x, y, "block1.png");
                                plansza.Add(s);
                                x += TILESIZE;
                            }
                            break;
                        case 'B':
                            for (int i = 0; i < liczba; ++i)
                            {
                                Segment s = new SegmentBlockV(x, y, "block2.png");
                                plansza.Add(s);
                                x += TILESIZE;
                            }
                            break;
                        case 'C':
                            for (int i = 0; i < liczba; ++i)
                            {
                                Segment s = new Segment(x, y, "block3.png");
                                plansza.Add(s);
                                x += TILESIZE;
                            }
                            break;
                        case 'G':
                            for (int i = 0; i < liczba; ++i)
                            {
                                Segment s = new SegmentAnim(x, y, "bonus.png", new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 3, 3, 2, 2, 1, 1, 1, 0, 0 });
                                plansza.Add(s);
                                x += TILESIZE;
                            }
                            break;
                    }
                }
                y += TILESIZE;
            }

            return plansza;
        }
        catch (IOException e)
        {
            Console.WriteLine("Blad wczytania planszy");
            Console.WriteLine(e.StackTrace);
        }

        return new List<Segment>();
    }
}