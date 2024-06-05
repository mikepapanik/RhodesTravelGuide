using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace RhodesTravelGuide
{
    public partial class Hotel : Form
    {
        SpeechSynthesizer speech;
        public Hotel()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }

        private void Hotel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (speech != null)
            {
                speech.Dispose();

            }
            this.Hide();
            Owner.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.atlanticahotels.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.rodos-palace.gr/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.calypsohotel.gr/home/en");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }
            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox9.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox10.Visible = false;
                pictureBox8.Visible = true;
            }
            else if (pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
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
                pictureBox11.Visible = true;
            }
            else if (pictureBox11.Visible == true)
            {
                pictureBox11.Visible = false;
                pictureBox3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Savee newfile6 = new Savee("AtlanticaHotel.txt");
            newfile6.WriteTxt(richTextBox1);
            newfile6.SuccessWriteTxt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Savee newfile7 = new Savee("RhodesPalaceHotel.txt");
            newfile7.WriteTxt(richTextBox2);
            newfile7.SuccessWriteTxt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Savee newfile8 = new Savee("CalypsoHotel.txt");
            newfile8.WriteTxt(richTextBox3);
            newfile8.SuccessWriteTxt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice("Microsoft Stefanos");
                speech.SpeakAsync(richTextBox1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            speech = new SpeechSynthesizer();
            speech.SelectVoice("Microsoft Stefanos");
            speech.SpeakAsync(richTextBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            speech = new SpeechSynthesizer();
            speech.SelectVoice("Microsoft Stefanos");
            speech.SpeakAsync(richTextBox3.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (speech != null)
            {
                speech.Dispose();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Speaking)
            {
                speech.Pause();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Paused)
            {
                speech.Resume();
            }
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
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
            toolTip1.Show("Με το πάτημα αυτού του κουμπιού μεταφέρεστε στην αρχική σελίδα του ξενοδοχείου", linkLabel1);

        }

        private void linkLabel2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Με το πάτημα αυτού του κουμπιού μεταφέρεστε στην αρχική σελίδα του ξενοδοχείου", linkLabel2);

        }

        private void linkLabel3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Με το πάτημα αυτού του κουμπιού μεταφέρεστε στην αρχική σελίδα του ξενοδοχείου", linkLabel3);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Πατήστε αυτό το κουμπί για να αποθηκεύσετε τις πληροφορίες του συγκεκριμένου ξενοδοχείου σε εξωτερικό αρχείο .txt", button1);

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Πατήστε αυτό το κουμπί για να αποθηκεύσετε τις πληροφορίες του συγκεκριμένου ξενοδοχείου σε εξωτερικό αρχείο .txt", button2);

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Πατήστε αυτό το κουμπί για να αποθηκεύσετε τις πληροφορίες του συγκεκριμένου ξενοδοχείου σε εξωτερικό αρχείο .txt", button3);

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip7.Show("Πατήστε αυτό το κουμπί για να ακούσετε τις πληροφορίες του συγκεκριμένου ξενοδοχείου μέσω του Microsoft Stefanos", button4);

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip8.Show("Πατήστε αυτό το κουμπί για να ακούσετε τις πληροφορίες του συγκεκριμένου ξενοδοχείου μέσω του Microsoft Stefanos", button5);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolTip9.Show("Πατήστε αυτό το κουμπί για να ακούσετε τις πληροφορίες του συγκεκριμένου ξενοδοχείου μέσω του Microsoft Stefanos", button6);
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolTip10.Show("Πατήστε αυτό το κουμπί για να σταματήσετε την ακρόαση", button7);
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            toolTip11.Show("Πατήστε αυτό το κουμπί για να κάνετε παύση την ακρόαση", button8);
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            toolTip12.Show("Πατήστε αυτό το κουμπί για να συνεχίσετε την ακρόαση απο εκεί που την σταματήσατε", button9);
        }
    }
}
