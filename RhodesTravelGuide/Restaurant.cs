using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhodesTravelGuide
{
    public partial class Restaurant : Form
    {
        public Restaurant()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.tripadvisor.com.gr/Restaurants-g189449-Rhodes_Dodecanese_South_Aegean.html");

        }

        private void Restaurant_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void Restaurant_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox7.Visible = true;
            }
            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }
            else if (pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
            }
            else if (pictureBox9.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox11.Visible = true;
            }
            else if (pictureBox11.Visible == true)
            {
                pictureBox11.Visible = false;
                pictureBox10.Visible = true;
            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox10.Visible = false;
                pictureBox3.Visible = true;
            }        
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox13.Visible = true;
            }
            else if (pictureBox13.Visible == true)
            {
                pictureBox13.Visible = false;
                pictureBox12.Visible = true;
            }
            else if (pictureBox12.Visible == true)
            {
                pictureBox12.Visible = false;
                pictureBox4.Visible = true;
            }
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Με το πάτημα αυτού του κουμπιού μεταφέρεστε στο επίσημο σύνδεσμο που αναφέρει περισσότερα εστιατόρια για το νησί της Ρόδου", linkLabel1);

        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailForm mailform = new MailForm();
            mailform.Show(this);
            this.Hide();
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
