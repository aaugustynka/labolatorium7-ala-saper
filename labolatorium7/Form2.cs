using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labolatorium7
{
    public partial class Form2 : Form
    {
        Label[,] labels;
        int[] losowanie;
        bool wygrana = false;
        int czas = 0;
        int x, z;
        int odznalezione = 0;
        public Form2(int x, int z)
        {
            InitializeComponent();
            this.Size = new Size(x * 50 + 130, x * 50 + 130);
            this.x = x;
            this.z = z;
            int a = 50, b = 50;
            Label[,] labels = new Label[x, x];
            losowanie = new int[z];
            int licz = 0;
            int wylosuj;
            Random rand = new Random();
            while (licz < z)
            {
                wylosuj = rand.Next(x * x);
                wylosuj *= 50;
                if (losowanie.Contains(wylosuj) == false)
                {
                    losowanie[licz] = wylosuj;
                    licz++;
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    labels[i, j] = new Label();
                    labels[i, j].Text = string.Empty;
                    labels[i, j].Click += label_Click;
                    labels[i, j].Location = new Point(a, b);
                    labels[i, j].BackColor = Color.Gray;
                    labels[i, j].Size = new Size(50, 50);
                    Controls.Add(labels[i, j]);
                    a += 50;
                }
                a = 50;
                b += 50;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            czas++;
            if (czas == z * 3 && wygrana == false)
            {
                MessageBox.Show("CZAS UPŁYNĄŁ! SPRÓBUJ PONOWNIE!");
                this.Close();
            }
        }
        private void label_Click(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            if (losowanie.Contains(tmp.Top * (x - 1) + tmp.Left - 50))
            {
                tmp.BackColor = Color.BlueViolet;
                odznalezione++;
            }
            else
                tmp.BackColor = Color.Black;

            if (odznalezione == z)
            {
                wygrana = true;
                MessageBox.Show("BRAWO, ODNALEZIONO WSZYSTKIE ELEMENTY. WYGRAŁEŚ!");
                this.Close();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
