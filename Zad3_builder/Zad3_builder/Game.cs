using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zad3_builder.Core.Segments;
using Zad3_builder.Core;

namespace Zad3_builder;

public class Game
{
    private readonly int TILESIZE = 32;
    private readonly List<Segment> plansza;
    private readonly Sprite sprite;

    public Game(String plik)
    {
        setPreferredSize(new Dimension(424, 268));
        setFocusable(true);
        plansza = stworzPlansze(plik);
        sprite = new Sprite(plansza, "mario.png");

        addKeyListener(new KeyAdapter()
        {
           // @Override
            public void keyReleased(KeyEvent ev)
        {
            switch (ev.getKeyCode())
            {
                case KeyEvent.VK_LEFT:
                case KeyEvent.VK_RIGHT:
                    sprite.stop();
                    break;
            }
        }

        // @Override
        public void keyPressed(KeyEvent ev)
        {
            switch (ev.getKeyCode())
            {
                case KeyEvent.VK_LEFT:
                    sprite.left();
                    break;
                case KeyEvent.VK_RIGHT:
                    sprite.right();
                    break;
                case KeyEvent.VK_SPACE:
                case KeyEvent.VK_UP:
                    sprite.jump();
                    break;
            }
        }
        new Thread(new SpriteController(sprite, plansza, this)).start();
    });

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

    private List<Segment> stworzPlansze(String plik)
    {
        BufferedReader br = null;
        try
        {
            InputStream pFile = getClass().getResourceAsStream(plik);
            br = new BufferedReader(new InputStreamReader(pFile));
            var plansza = new List<Segment>();
            String linia;
            int x;
            int y = 4;
            int liczba;
            int znaki;
            char znak;
            char cyfra1;
            char cyfra2;
            while ((linia = br.readLine()) != null)
            {
                x = 4;
                znaki = 0;
                while ((linia.Length() - znaki) >= 3)
                {
                    znak = linia.charAt(znaki++);
                    cyfra1 = linia.charAt(znaki++);
                    cyfra2 = linia.charAt(znaki++);
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
            br.close();
            return plansza;
        }
        catch (IOException e)
        {
            Console.WriteLine("Blad wczytania planszy");
            Console.WriteLine(e.StackTrace);
        }
    }
}