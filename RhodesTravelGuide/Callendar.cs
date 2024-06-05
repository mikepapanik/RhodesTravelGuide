using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace RhodesTravelGuide
{
    public partial class Callendar : Form
    {
        public Callendar()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void Callendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void Callendar_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2021, 08, 09);
            even.find_event(dateTimePicker1.Value, dt, label4);

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime dt = new DateTime(2021, 08, 09);
            even.find_event(dateTimePicker1.Value, dt, label4);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.rhodes.gr/ekdilosis/");

        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailForm mailform = new MailForm();
            mailform.Show(this);
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο συγκεκριμένος τουριστικός οδηγός της Ρόδου δημιουργήθηκε για να βοηθάει τους επισκέπτες του νησιού ");

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "_tmphhp/RhodesTravelGuideHelp.chm", HelpNavigator.Topic);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατώντας στο συγκεκριμένο σύνδεσμο μεταφέρεστε στην Ιστοσελίδα εκδηλώσεων της Ρόδου", linkLabel1);

        }

        private void dateTimePicker1_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Ημερολόγιο Εκδηλώσεων Ρόδου", dateTimePicker1);

        }
    }
}
