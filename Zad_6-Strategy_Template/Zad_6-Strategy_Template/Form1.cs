using Zad_6_Strategy_Template.Strategia;

namespace Zad_6_Strategy_Template;


public partial class Form1 : Form
{
    private Mucha2[] ar = new Mucha2[30];

    public Form1()
    {
        InitializeComponent();
        this.Size = new Size(640, 480);
        this.Muchy();
    }

    public void Muchy()
    {
        var strategy1 = new RandomStrategy(Color.Red);
        var strategy2 = new CircleStrategy(Color.Blue);
        ar = new Mucha2[30];
        for (int i = 0; i < ar.Length; ++i)
        {
            //ar[i] = new Mucha(new Random().Next(2) == 0? strategy2 : strategy1);
            ar[i] = new Mucha2(Color.Red);
        }
    }

    public void paintComponent(Graphics g)
    {
        for (int i = 0; i < ar.Length; ++i)
            ar[i].draw(g);
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        while (true)
        {
            for (int i = 0; i < ar.Length; ++i)
            {
                ar[i].move();
            }
            for (int i = 0; i < ar.Length; ++i)
                ar[i].draw(e.Graphics);
            try
            {
                Thread.Sleep(20);
            }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
            finally
            {
                e.Graphics.Clear(Color.White);
            }
        }
    }
}
