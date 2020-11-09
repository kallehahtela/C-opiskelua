using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikäTahansaNimi
{
    public partial class TekstiLaatikko : Form
    {
        public TekstiLaatikko()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Tekstitahan_Click(object sender, EventArgs e)
        {

        }

        private void keskipainike_Click(object sender, EventArgs e)
        {
            string etunimi = TekstiLattikko.Text;
            ViestiLabel.Visible = true;
            ViestiLabel.Text = "Hei " + etunimi + ", oikein hyvää viikoa sinulle !";
        }
    }
}
