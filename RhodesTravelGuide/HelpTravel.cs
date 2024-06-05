using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhodesTravelGuide
{
    public partial class HelpTravel : Form
    {
        SoundPlayer soundtrack = new SoundPlayer();
        ArrayList hist = new ArrayList();
        public HelpTravel()
        {
            InitializeComponent();

            hist.Add("destinations1.txt");
            hist.Add("Beach1.txt");
            hist.Add("Map1.txt");
            hist.Add("Restaurants.txt");
            hist.Add("HistoryRhodes.txt");
            hist.Add("Callendar1.txt");
            hist.Add("Activities1.txt");
            hist.Add("Hotels.txt");
       
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\syrtakigreek.wav";
            sp.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Visible == true)
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
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox1.Visible = true;
            }
        


        }

        private void Callendar1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Βρείτε ποιές ημερομηνίες υπάρχουν εκδηλώσεις", Callendar1);
        }

        private void Map1_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Μπορείτε να δείτε τον χάρτη της Ρόδου", Map1);
        }

        private void Beach1_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Δείτε τις δημοφιλέστερες παραλίες του νησιού", Beach1);
        }

        private void Restaurants_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Βρείτε τα καλύτερα Εστιατόρια της περιοχής", Restaurants);
        }

        private void destinations1_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Μπορείτε να δείτε τους καλύτερους προορισμούς του νησιού", destinations1);
        }

        private void Activities1_MouseHover(object sender, EventArgs e)
        {
            toolTip6.Show("Διάφορες δραστηριότητες διασκέδασης", Activities1);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            toolTip7.Show("Εικόνες της Ρόδου", pictureBox6);
        }

        private void resethistory_MouseHover(object sender, EventArgs e)
        {
            toolTip8.Show("Επαναφορά Ιστορικού Επίσκεψης", resethistory);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void destinations1_Click(object sender, EventArgs e)
        {
            destinations1.ForeColor = Color.Blue;
            destinations destination = new destinations();
            destination.Show(this);
            this.Hide();
        }   

        private void Map1_Click(object sender, EventArgs e)
        {
            Map1.ForeColor = Color.Blue;
            Map map = new Map();
            map.Show(this);
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Resethist ht = new Resethist();
            ht.PrintHis(Map1, "Map1.txt");
            ht.PrintHis(destinations1, "destinations1.txt");
            ht.PrintHis(Beach1, "Beach1.txt");
            ht.PrintHis(Restaurants, "Restaurants.txt");
            ht.PrintHis(Callendar1, "Callendar1.txt");
            ht.PrintHis(HistoryRhodes, "HistoryRhodes.txt");
            ht.PrintHis(Activities1, "Activities1.txt");
            ht.PrintHis(Hotels, "Hotels.txt");
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

        private void resethistory_Click_1(object sender, EventArgs e)
        {
            Map1.ForeColor = Color.Black;
            destinations1.ForeColor = Color.Black;
            Beach1.ForeColor = Color.Black;
            Restaurants.ForeColor = Color.Black;
            HistoryRhodes.ForeColor = Color.Black;
            Callendar1.ForeColor = Color.Black;
            Hotels.ForeColor = Color.Black;
            Activities1.ForeColor = Color.Black;
            timer2.Stop();

            Resethist deletehist = new Resethist();

            deletehist.DeleteHis(hist);
        }


        private void HistoryRhodes_Click(object sender, EventArgs e)
        {
            HistoryRhodes.ForeColor = Color.Blue;
            HistOfRhodes HistoryR = new HistOfRhodes();
            HistoryR.Show(this);
            this.Hide();
        }

        private void Activities1_Click(object sender, EventArgs e)
        {
            Activities1.ForeColor = Color.Blue;
            Activitie Activit = new Activitie();
            Activit.Show(this);
            this.Hide();
        }

        private void Sound_on_Click(object sender, EventArgs e)
        {
            
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\syrtakigreek.wav";
            sp.PlayLooping();

            Sound_on.Visible = false;
            Sound_Off.Visible = true;
        }

        private void Sound_Off_Click(object sender, EventArgs e)
        {
            
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\syrtakigreek.wav";
            sp.Stop();
            Sound_Off.Visible = false;
            Sound_on.Visible = true;
        }

        private void HelpTravel_FormClosing(object sender, FormClosingEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\syrtakigreek.wav";
            sp.Stop();
            
        }

        private void Callendar1_Click(object sender, EventArgs e)
        {
            Callendar1.ForeColor = Color.Blue;
            Callendar calend = new Callendar();
            calend.Show(this);
            this.Hide();
        }

        private void Hotels_Click(object sender, EventArgs e)
        {
            Hotels.ForeColor = Color.Blue;
            Hotel Ho = new Hotel();
            Ho.Show(this);
            this.Hide();
        }

        private void Hotels_MouseHover(object sender, EventArgs e)
        {
            toolTip9.Show("Δείτε τα προτεινόμενα Ξενοδοχεία της εφαρμογής", Hotels);
        }

        private void HistoryRhodes_MouseHover(object sender, EventArgs e)
        {
            toolTip10.Show("Λίγα πράγματα για την Ιστορία της Ρόδου", HistoryRhodes);
        }

        private void Sound_Off_MouseHover(object sender, EventArgs e)
        {
            toolTip11.Show("Απενεργοποίηση Ήχου Εισαγωγής", Sound_Off);
        }

        private void Sound_on_MouseHover(object sender, EventArgs e)
        {
            toolTip12.Show("Ενεργοποίηση Ήχου Εισαγωγής", Sound_on);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "_tmphhp/RhodesTravelGuideHelp.chm", HelpNavigator.Topic);

        }
    }
}
