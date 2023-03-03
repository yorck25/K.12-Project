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
    public partial class Lieferant : Form
    {
        public Lieferant()
        {
            InitializeComponent();
        }

        private void herfLLöschen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void herfLNeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lDetail.Visible = true;
            butLErstellen.Visible= true;
            butLÄndern.Visible= false;
        }

        private void lBoxLieferant_SelectedIndexChanged(object sender, EventArgs e)
        {
            butLÄndern.Visible = true;
            lDetail.Visible = true;
            butLErstellen.Visible= false;
        }
    }
}
