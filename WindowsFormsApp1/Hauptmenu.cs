﻿using System;
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
    public partial class Hauptmenu : Form
    {
        public Hauptmenu()
        {
            InitializeComponent();
        }

        private void hauptmenuÖffnenSidebar_Click(object sender, EventArgs e)
        {
            hmenuNavElemente.Visible =! hmenuNavElemente.Visible; 
            Login login = new Login();
            login.Show();
        }

        private void button1hauptmenuÖffnenAcc_Click(object sender, EventArgs e)
        {
            hmenuAccElemente.Visible = ! hmenuAccElemente.Visible;
        }

        private void butHauptmenuÖffnenNachrichten_Click(object sender, EventArgs e)
        {
            hmenuBenachrichtigungList.Visible = ! hmenuBenachrichtigungList.Visible;
        }

        private void lBoxBenachrichtigung_SelectedIndexChanged(object sender, EventArgs e)
        {
            hmenuDetailBenachrichtigung.Visible = ! hmenuDetailBenachrichtigung.Visible;
        }

        private void lBoxHmenuBestand_SelectedIndexChanged(object sender, EventArgs e)
        {
            hmenuDetailABestand.Visible = !hmenuDetailABestand.Visible;
        }

        private void butHmenuBestätigen_Click(object sender, EventArgs e)
        {
            hmenuDetailABestand.Visible = false;
        }
    }
}
