using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace RhodesTravelGuide
{
    public partial class MailForm : Form
    {
        sendmails msg;
        public MailForm()
        {
            InitializeComponent();
        }

        private void MailForm_Load(object sender, EventArgs e)
        {

        }

        private void MailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

   

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Στείλτε το μήνυμα σας ", button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sendmails msender = new sendmails();

            msender.Sendmail(textBox1, textBox2);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο συγκεκριμένος τουριστικός οδηγός της Ρόδου δημιουργήθηκε για να βοηθάει τους επισκέπτες του νησιού");

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
