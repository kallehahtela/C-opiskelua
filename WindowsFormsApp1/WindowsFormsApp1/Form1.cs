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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tekstilaaikko1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int luku1 = 0, luku2 = 0, summa;
            try
            {
                luku1 = int.Parse(Tekstilaaikko1.Text);
            }
            catch
            {
                VastausLabel.Text = "Anna vain numeroina kokonaislukuja";
                Tekstilaaikko1.Focus();

                
            }
            try
            {
                luku2 = int.Parse(Tekstilaatikko2.Text);

                summa = luku1 + luku2;
                VastausLabel.Visible = true;
                VastausLabel.Text = ("" + summa);
            }
            catch
            {

            }
        }
    }
}
