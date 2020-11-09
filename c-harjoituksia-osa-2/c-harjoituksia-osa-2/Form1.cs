using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_harjoituksia_osa_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testausbutton_Click(object sender, EventArgs e)
        {
            int luku1 = 0, luku2 = 0;
            try
            {
                luku1 = int.Parse(Luku1Laatikko.Text);
                VastausLaatikko.Visible = true;

            }
            catch
            {
                VastausLaatikko.Text = "Anna vain numeroina kokonaislukuja";
                Luku1Laatikko.Focus();
            }

            try
            {
                luku2 = int.Parse(Luku2Laatikko.Text);
                VastausLaatikko.Visible = true;

            }
            catch
            {
                VastausLaatikko.Text = "Anna vain numeroina kokonaislukuja";
                Luku2Laatikko.Focus();
            }

            VastausLaatikko.Text = function(luku1, luku2);
        }

        private string function(int x, int y)
        {
           
           if(x == y)
           {
                return "Luku on yhtä suuri";

           } else
           {
                return "Luku ei ole yhtä suuri";
           }
         
        }
    }
}
