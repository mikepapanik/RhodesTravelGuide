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
    public partial class Activitie : Form
    {
        SpeechSynthesizer speech;
        public Activitie()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }

        private void Activitie_Load(object sender, EventArgs e)
        {
            speech = new SpeechSynthesizer();
            speech.Dispose();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
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
                pictureBox15.Visible = true;
            }
            else if (pictureBox15.Visible == true)
            {
                pictureBox15.Visible = false;
                pictureBox1.Visible = true;
            }
        }

     

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox11.Visible = true;
            }
            else if (pictureBox11.Visible == true)
            {
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
            }
            else if (pictureBox12.Visible == true)
            {
                pictureBox12.Visible = false;
                pictureBox2.Visible = true;
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
                pictureBox14.Visible = true;
            }
            else if (pictureBox14.Visible == true)
            {
                pictureBox14.Visible = false;
                pictureBox4.Visible = true;
            }
        }

        private void Activitie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (speech != null)
            {
                speech.Dispose();

            }
            this.Hide();
            Owner.Show();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
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
                pictureBox10.Visible = true;
            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox10.Visible = false;
                pictureBox3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text != "")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice("Microsoft Stefanos");
                speech.SpeakAsync(richTextBox2.Text);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox3.Text != "")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice("Microsoft Stefanos");
                speech.SpeakAsync(richTextBox3.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox4.Text != "")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice("Microsoft Stefanos");
                speech.SpeakAsync(richTextBox4.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Speaking)
            {
                speech.Pause();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (speech != null)
            {
                speech.Dispose();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (speech.State == SynthesizerState.Paused)
            {
                speech.Resume();
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να ακούσετε το κείμενο που αναγράφεται παραπάνω για την Φάρμα Ρόδου", button4);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να ακούσετε το κείμενο που αναγράφεται παραπάνω για την Κοιλάδα Πεταλούδων", button1);

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να ακούσετε το κείμενο που αναγράφεται παραπάνω για τις Καταδύσεις", button2);

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να ακούσετε το κείμενο που αναγράφεται παραπάνω για το γήπεδο του Γκολφ", button3);

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να σταματήσετε την ακρόαση", button7);

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να κάνετε παύση την ακρόαση", button5);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolTip7.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να συνεχίσετε την ακρόαση", button6);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο συγκεκριμένος τουριστικός οδηγός της Ρόδου δημιουργήθηκε για να βοηθάει τους επισκέπτες του νησιού");

        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailForm mailform = new MailForm();
            mailform.Show(this);
            this.Hide();
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
