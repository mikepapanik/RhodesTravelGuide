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

namespace RhodesTravelGuide
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.google.com/search?q=+%CF%81%CF%8C%CE%B4%CE%BF%CF%82&rlz=1C1NDCM_elGR811GR811&biw=1536&bih=696&tbm=lcl&sxsrf=ALeKk01CkBh9aDg27s_J_6Q8VXpYXCh-8Q%3A1627391649532&ei=oQYAYd3-H_mHjLsPuYyL4AU&oq=+%CF%81%CF%8C%CE%B4%CE%BF%CF%82&gs_l=psy-ab.3..38l5.11065.13600.0.13935.9.8.1.0.0.0.158.518.0j4.5.0....0...1c.1.64.psy-ab..3.6.673.10..0j35i362i39k1j35i39k1j0i433i131k1j0i433k1j0i3k1.152.dpe9tZxoPiU");
        }

        private void Map_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Αποθηκεύστε το παραπάνω κείμενο σε εξωτερικό αρχείο", button1);
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε το κουμπί για να συνδεθείτε με τους χάρτες του Google Maps", linkLabel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Savee newfile = new Savee("Map.txt");
            newfile.WriteTxt(richTextBox1);
            newfile.SuccessWriteTxt();
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
    }
}
