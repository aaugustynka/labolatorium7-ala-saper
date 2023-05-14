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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check, check1;
            int x_, z_;
            check = int.TryParse(x.Text, out x_);
            check1 = int.TryParse(z.Text, out z_);
            if (check && check1)
            {
                Form2 form = new Form2(x_, z_);
                form.ShowDialog();
                this.Close();
            }
            else
            {
                label3.Text = "WPISANO BŁĘDNE DANE, POPRAW! (TYLKO ZMIENNE LICZBOWE)";
            }
        }

        private void z_TextChanged(object sender, EventArgs e)
        {

        }

        private void x_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
