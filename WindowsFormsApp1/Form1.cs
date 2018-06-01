using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        double H, W, G, Ng, Np, N, Npp, Sg, Sp, Gaba, Sv,Pi;
        int ng,sg,gaba,sv;

        private void Weight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void Height_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Weight.Focus();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(290, 100));
            e.Graphics.DrawString(label3.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));

            e.Graphics.DrawString(textBox2.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(290, 150));
            e.Graphics.DrawString(label4.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 150));

            e.Graphics.DrawString(textBox3.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(290, 200));
            e.Graphics.DrawString(label5.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 200));

            e.Graphics.DrawString(textBox4.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(290, 250));
            e.Graphics.DrawString(label7.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 250));

            e.Graphics.DrawString(textBox7.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(290, 300));
            e.Graphics.DrawString(label9.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 300));

            e.Graphics.DrawString(textBox6.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(290, 350));
            e.Graphics.DrawString(label8.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 350));

            e.Graphics.DrawString(textBox8.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(290, 400));
            e.Graphics.DrawString(label10.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 400));

            e.Graphics.DrawString(textBox10.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(290, 450));
            e.Graphics.DrawString(label12.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 450));

            e.Graphics.DrawString(textBox9.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(290, 500));
            e.Graphics.DrawString(label11.Text, new Font("Times New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 500));
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        public Result res;
        public Main()
        {
            InitializeComponent();
        }

        private void noreal_Click(object sender, EventArgs e)
        {
            textBox3.Text = "" + (ng+1) + "шт.";
            real.Visible = true;
            noreal.Visible = false;
            
        }
        private void real_Click(object sender, EventArgs e)
        {
            textBox3.Text = "" + Ng + " шт.";
            real.Visible = false;
            noreal.Visible = true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            res.A(H.ToString());
            res.B(W.ToString());
            res.C(G.ToString());
            res.Show();
            Visible = false;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            G = double.Parse(comboBox1.Text);
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Розрахунки
            {
                N = (H / 100) * (W / 100);
                Np = ((H / 100) + (W / 100)) * 2;
                Ng = (H * 10 * W * 10) / (1200 * 1000 * G/100);
                ng = (int)Ng;
                Npp = 2 * (H * 10 / 400 * (W / 100));
                Sg = (H / 20) * (W / 20);
                sg = (int)Sg;
                Sp = ((H / 40) * (W / 40)) * 8;
                Gaba = Sp / 8;
                Gaba = (int)Gaba;
                Sv = Gaba * 2;
                sv = (int)Sv;
                Pi = (H / 100) * (W / 100) * 2;
            }
            //Вивід
            {
                textBox1.Text = "" + N + " м2";
                textBox2.Text = "" + Np + " м";
                textBox3.Text = "" + (ng + 1) + " шт.";
                textBox4.Text = "" + Npp + " м";
                textBox5.Text = "" + Math.Ceiling(Ng) + " шт.";
                textBox6.Text = "" + Sp + " шт.";
                textBox7.Text = "" + sg + " шт.";
                textBox8.Text = "" + Gaba + " шт.";
                textBox9.Text = "" + Sv + " шт.";
                textBox10.Text = "" + Pi + " шт.";
            }
        }

        private void Height_TextChanged(object sender, EventArgs e)
        {
            string tString = Height.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    Height.Text = "";
                    return;
                }

            }
            H = double.Parse(Height.Text);

        }  

        private void Weight_TextChanged(object sender, EventArgs e)
        {
            string tString = Weight.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    Weight.Text = "";
                    return;
                }

            }
            W = double.Parse(Weight.Text);
        }
    }
}
