using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jakojäännös
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void laskupainike_Click(object sender, EventArgs e)
        {
            int tulos = 0;
            int luku1 = 0, luku2 = 0;
            try
            {
                luku1 = int.Parse(luku1tekstilaatikko.Text);
            }

            catch
            {
                luku1tekstilaatikko.Text = "Anna vain kokonaislukuja";
                luku1tekstilaatikko.Focus();
            }

            try
            {
                luku2 = int.Parse(luku2tekstilaatikko.Text);

                tulos = luku1 / luku2;
                tuloslabel.Visible = true;
                tuloslabel.Text = ("" + tulos);
            }

            catch
            {

            }
        }
    }
}
