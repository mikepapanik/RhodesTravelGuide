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
    public partial class beach : Form
    {
        SpeechSynthesizer speech;
        public beach()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.tripadvisor.com.gr/Search?q=%CE%A1%CF%8C%CE%B4%CE%BF%CF%82%20%CF%80%CE%B1%CF%81%CE%B1%CE%BB%CE%AF%CE%B5%CF%82&searchSessionId=B8CDDBF3EFDF2D902193F29D0D1C34151627476486362ssid&searchNearby=false&sid=5DA56EFCFCB55AA50699C14F18B76FC51627476492496&blockRedirect=true&ssrc=A&rf=1");
        }

        private void beach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (speech != null)
            {
                speech.Dispose();

            }
            this.Hide();
            Owner.Show();
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατώντας στο συγκεκριμένο σύνδεσμο μεταφέρεστε στην Ιστοσελίδα του Trip Advisor", linkLabel1);
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

        private void beach_Load(object sender, EventArgs e)
        {
            speech = new SpeechSynthesizer();
            speech.Dispose();
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (speech != null)
            {
                speech.Dispose();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Speaking)
            {
                speech.Pause();
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
            toolTip2.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να ακούσετε το κείμενο που αναγράφεται παραπάνω για την Παραλία Τσαμπίκα", button4);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να ακούσετε το κείμενο που αναγράφεται παραπάνω για την Παραλία Antony Queen", button1);

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να ακούσετε το κείμενο που αναγράφεται παραπάνω για την Παραλία Φαληράκι", button2);

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να ακούσετε το κείμενο που αναγράφεται παραπάνω για την Παραλία Αγίου Παύλου", button3);

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να σταματήσετε την ακρόαση", button7);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {

            toolTip7.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να κάνετε παύση την ακρόαση", button5);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolTip8.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να συνεχίσετε την ακρόαση", button6);
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
