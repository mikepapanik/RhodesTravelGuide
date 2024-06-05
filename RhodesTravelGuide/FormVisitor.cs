using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhodesTravelGuide
{
    public partial class FormVisitor : Form
    {
        ArrayList hist = new ArrayList();
        public FormVisitor()
        {
            InitializeComponent();
            hist.Add("destinations1.txt");
            hist.Add("Beach1.txt");
            hist.Add("Map1.txt");
            hist.Add("Restaurants.txt");
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }
            
        }

        private void FormVisitor_Load(object sender, EventArgs e)
        {
            timer1.Start();
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\syrtakigreek.wav";
            sp.PlayLooping();
        }

        private void destinations1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Μπορείτε να δείτε τους καλύτερους προορισμούς του νησιού", destinations1);
        }

        private void Beach1_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Δείτε τις δημοφιλέστερες παραλίες του νησιού", Beach1);
        }

        private void Map1_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Μπορείτε να δείτε τον χάρτη της Ρόδου", Map1);
        }

        private void Restaurants_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Βρείτε τα καλύτερα Εστιατόρια της περιοχής", Restaurants);
        }

        private void Map1_Click(object sender, EventArgs e)
        {
            Map1.ForeColor = Color.Blue;
            Map map = new Map();
            map.Show(this);
            this.Hide();
        }

        private void destinations1_Click(object sender, EventArgs e)
        {
            destinations1.ForeColor = Color.Blue;
            destinations destination = new destinations();
            destination.Show(this);
            this.Hide();
        }

        private void resethistory_Click(object sender, EventArgs e)
        {
            Map1.ForeColor = Color.Black;
            destinations1.ForeColor = Color.Black;
            Beach1.ForeColor = Color.Black;
            Restaurants.ForeColor = Color.Black;
            timer2.Stop();

            Resethist deletehist = new Resethist();

            deletehist.DeleteHis(hist);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Resethist ht = new Resethist();
            ht.PrintHis(Map1, "Map1.txt");
            ht.PrintHis(destinations1, "destinations1.txt");
            ht.PrintHis(Beach1, "Beach1.txt");
            ht.PrintHis(Restaurants, "Restaurants.txt");
        }

        private void resethistory_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Με το πάτημα αυτού του κουμπιού διαγράφεται το ιστορικό", resethistory);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Με το πάτημα αυτού του κουμπιού κάνετε σίγαση στον ήχο", Sound_Off);
        }

        private void Beach1_Click(object sender, EventArgs e)
        {
            Beach1.ForeColor = Color.Blue;
            beach beac = new beach();
            beac.Show(this);
            this.Hide();
        }

        private void Restaurants_Click(object sender, EventArgs e)
        {
            Restaurants.ForeColor = Color.Blue;
            Restaurant ress = new Restaurant();
            ress.Show(this);
            this.Hide();
        }

        private void FormVisitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\syrtakigreek.wav";
            sp.Stop();
            this.Hide();
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\syrtakigreek.wav";
            sp.Stop();
            Sound_Off.Visible = false;
            Sound_on.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\syrtakigreek.wav";
            sp.PlayLooping();

            Sound_on.Visible = false;
            Sound_Off.Visible = true;
        }

        private void Sound_on_MouseHover(object sender, EventArgs e)
        {
            toolTip7.Show("Με το πάτημα αυτού του κουμπιού ενεργοποιείτε τον ήχο", Sound_on);
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

