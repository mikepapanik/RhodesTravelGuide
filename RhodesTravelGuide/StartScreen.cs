using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RhodesTravelGuide
{
   
    public partial class StartScreen : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public StartScreen()
        {
            InitializeComponent();
            
            menuStrip1.BackColor = Color.Transparent;

          
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            FormVisitor formvisitor = new FormVisitor();
            formvisitor.Show(this);
            this.Hide();
        }

        private void loginButtonPanel_Click(object sender, EventArgs e)
        {
            string usr = userNameTextBox.Text;
            string psw = PasswordTextBox.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Userap.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Userapp where Username='" + userNameTextBox.Text + "' AND Password='" + PasswordTextBox.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                HelpTravel Helptrave = new HelpTravel();
                Helptrave.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }

            con.Close();

        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailForm mailform = new MailForm();
            mailform.Show(this);
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.rhodes.gr/touristikos-odigos/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Height != 100)
            {
                panel1.Height += 5;
                if (panel1.Height == 100)
                {
                    timer1.Stop();
                }
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm regist = new RegisterForm();
            regist.Show(this);
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {//Το τρίτο είναι το keyword 
            Help.ShowHelp(this, "_tmphhp/RhodesTravelGuideHelp.chm", HelpNavigator.Topic);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ο συγκεκριμένος τουριστικός οδηγός της Ρόδου δημιουργήθηκε για να βοηθάει τους επισκέπτες του νησιού");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Με το πάτημα αυτού του κουμπιού μπορείτε να κάνετε εγγραφή στην εφαρμογή, έχωντας παραπάνω δικαιώματα και περισσότερες ενέργειες στη διάθεση σας.", Register);
        }

        private void loginButtonPanel_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Συμπληρώστε τα σωστά στοιχεία εισόδου και εισέλθετε στην εφαρμογή πατώντας το κουμπί Login", loginButtonPanel);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Πατώντας αυτό το κουμπί μπορείτε να εισέλθετε στην εφαρμογή ως Επισκέπτης με λιγότερα δικαιώματα", button1);

        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Πατώντας το συγκεκριμένο σύνδεσμο θα βρεθείτε στην επίσημη Ιστοσελίδα του Νησιού της Ρόδου", linkLabel1);

        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("Are you sure want exit from application?", "Rhodes Travel Guide Exit", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes)
            {
                e.Cancel = false;


            }
            else if (dialogResult1 == DialogResult.No)
            {

                e.Cancel = true;
            }
            
        }
    }
}
