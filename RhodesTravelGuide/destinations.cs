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
    public partial class destinations : Form
    {

        SpeechSynthesizer speech;
        
        public destinations()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }

        private void destinations_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (speech != null)
            {
                speech.Dispose();

            }
            this.Hide();
            Owner.Show();
        }

       
        private void destinations_Load(object sender, EventArgs e)
        {
            speech = new SpeechSynthesizer();
            speech.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
            if (richTextBox2.Text != "")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice("Microsoft Stefanos");
                speech.SpeakAsync(richTextBox2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox3.Text != "")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice("Microsoft Stefanos");
                speech.SpeakAsync(richTextBox3.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
        
        private void button6_Click(object sender, EventArgs e)
                {
            
                if (speech.State == SynthesizerState.Paused)
                {
                    speech.Resume();
                }
            
         }

        private void button7_Click(object sender, EventArgs e)
        {
            if (speech != null)
            {
                speech.Dispose();
                
            }
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