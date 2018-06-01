using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Result : Form
    {
        string b,c,a;
        Graphics graph;
        public Result()
        {
            InitializeComponent();
            graph = CreateGraphics();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ResultForm2.Text = b + " cм";

            ResultForm3.Text = c + " cм";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main openForm1 = new Main();
            openForm1.Show();
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        
        public void A(string H)
        {
            b = H.ToString();          
        }
        public void B(string W)
        {
            c = W.ToString();
        }
        public void C(string G)
        {
            a = G.ToString();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int i, h, h1, W, HH;
            float m, n, X1, X2, Y1, Y2;
            int w = int.Parse(c);
            int hh = int.Parse(b);
            int h2 = int.Parse(a);
            {
                W = w;
                HH = hh;
                n = 1.0F;
                m = 1.0F;
                if (W>400||HH>400)
                {
                    n = 1.5F;
                    m = 1.5F;                   
                }
                if (W > 1000 || HH > 1000)
                {
                    n = 2.5F;
                    m = 2.5F;
                }
                if (W > 2000 || HH > 2000)
                {
                    n = 6.0F;
                    m = n;
                }
                textBox1.Text = "" + n + "X";
                h = 40;
                X1 = 50;
                Y1 = 100;
                X2 = 50;
                //Y2 = 350;

            }
            Pen pen = SystemPens.ControlText;
            //graph.DrawLine(pen, Позиція Х1,Позиція У1,Позиція Х2,Позиція У2);
            {
                //left
                graph.DrawLine(pen, X1, Y1, X2, W / n + 100);
                //top
                //graph.DrawLine(pen, X1, Y1, (X2+300)/m, (Y2-250)/n);
                graph.DrawLine(pen, X1, Y1, (HH + 50) / m, (W - (W - 100)));
                //right
                graph.DrawLine(pen, (HH / m + 50), Y1, (HH / m + 50), W / n + 100);
                //down
                graph.DrawLine(pen, X1, (W / n + 100), (HH / m + 50), (W / n + 100));
                //vertikal
                for (X1 = 50, X2 = 50; X1 < HH / m + 50; X1 = X1 + h / m, X2 = X2 + h / m)
                {
                    graph.DrawLine(pen, X1, Y1, X2, W / n + 100);
                }
                //horisontal
                for (Y1 = 100, Y2 = 100; Y1 < W / n + 100; Y1 = Y1 + (h+10) / n, Y2 = Y2 + (h+10) / n)
                {
                    X1 = 50;
                    X2 = 50;
                    graph.DrawLine(pen, X1, Y1, (HH / m + 50), Y2);
                }

            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, h,h1, W, HH;
            float m, n, X1, X2, Y1, Y2;
            int w = int.Parse(c);
            int hh = int.Parse(b);
            int h2 = int.Parse(a);
            {
                W = w;
                HH = hh;
                n = 1.0F;
                m = 1.0F;
                if (W > 400 || HH > 400)
                {
                    n = 1.5F;
                    m = 1.5F;
                }
                if (W > 1000 || HH > 1000)
                {
                    n = 2.5F;
                    m = 2.5F;
                }
                textBox1.Text = "" + n + "X";
                h = 120;
                X1 = 50;
                Y1 = 100;
                X2 = 50;
                Y2 = 350;
                h1 = h2;

            }
            Pen pen = SystemPens.ControlText;
            //graph.DrawLine(pen, Позиція Х1,Позиція У1,Позиція Х2,Позиція У2);
            {
                //left
                graph.DrawLine(pen, X1, Y1 , X2, W / n+100 );
                //top
                //graph.DrawLine(pen, X1, Y1, (X2+300)/m, (Y2-250)/n);
                graph.DrawLine(pen, X1, Y1, (HH + 50) / m, (W - (W - 100)));
                //right
                graph.DrawLine(pen, (HH / m + 50), Y1, (HH / m + 50), W / n + 100);
                //down
                graph.DrawLine(pen, X1, (W / n + 100), (HH / m + 50), (W / n + 100));
                //vertikal
                for (X1 = 50, X2 = 50; X1 < HH / m + 50; X1 = X1 + (h) / m, X2 = X2 + (h) / m)
                {
                    graph.DrawLine(pen, X1, Y1, X2, W / n + 100);
                }
                //horisontal
                for (Y1 = 100, Y2 = 100; Y1 < W / n + 100; Y1 = Y1 + (h1) / n, Y2 = Y2 + (h1) / n)
                {
                    X1 = 50;
                    X2 = 50;
                    graph.DrawLine(pen, X1, Y1, (HH / m + 50), Y2);
                }
            }
        }
    }
}
