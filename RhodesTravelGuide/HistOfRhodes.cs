using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace RhodesTravelGuide
{
    public partial class HistOfRhodes : Form
    {
        string _url;
        public string VideoID
        {
            get
            {
                var yMatch = new System.Text.RegularExpressions.Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(_url);
                return yMatch.Success ? yMatch.Groups[1].Value : String.Empty;
            }
        }
        public HistOfRhodes()
        {
            InitializeComponent();
        }

   
        private void HistOfRhodes_Load(object sender, EventArgs e)
        {
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _url = "https://www.youtube.com/watch?v=fe272fE0WRc&ab_channel=MunicipalityOfRhodes";
            webBrowser1.DocumentText = String.Format("<html><head>" +
                    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                    "</head><body>" +
                    "<iframe width=\"100%\" height=\"315\" src=\"https://www.youtube.com/embed/{0}?autoplay=1\"" +
                    "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                    "</body></html>", VideoID);
        }

        private void HistOfRhodes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Πατήστε για να δείτε το βίντεο που δημιουργήθηκε το 2021 σχετικά με την Ρόδο", button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Savee newfile1 = new Savee("HistoryRhode.txt");
            newfile1.WriteTxt(richTextBox1);
            newfile1.SuccessWriteTxt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Savee newfile2 = new Savee("ItalyPeriod.txt");
            newfile2.WriteTxt(richTextBox2);
            newfile2.SuccessWriteTxt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Savee newfile3 = new Savee("IpotikiPeriodos.txt");
            newfile3.WriteTxt(richTextBox3);
            newfile3.SuccessWriteTxt();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Savee newfile4 = new Savee("SygxroniPeriodos.txt");
            newfile4.WriteTxt(richTextBox4);
            newfile4.SuccessWriteTxt();
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

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Πατήστε για να Αποθηκεύσετε το περιεχόμενο του παραπάνω κειμένου", button3);

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Πατήστε για να Αποθηκεύσετε το περιεχόμενο του παραπάνω κειμένου", button5);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Πατήστε για να Αποθηκεύσετε το περιεχόμενο του παραπάνω κειμένου", button4);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Πατήστε για να Αποθηκεύσετε το περιεχόμενο του παραπάνω κειμένου", button2);
        }
    }
}
