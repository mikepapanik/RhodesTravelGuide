using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RhodesTravelGuide
{
    public partial class RegisterForm : Form
    {
        
        public RegisterForm()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Userap.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "" || textBox5.Text=="" || textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Some fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBox3.Text == textBox6.Text)
            {   using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Userap.accdb"))
                {

               
                    con.Open();
                    bool exists = false;
                    {
                        using (OleDbCommand cmd = new OleDbCommand("select count(*) from [Userapp] where Username = @Userame", con))
                        {
                            cmd.Parameters.AddWithValue("Username", textBox1.Text);
                            exists = (int)cmd.ExecuteScalar() > 0;
                        }
                        if (exists)
                            MessageBox.Show("This Username is Already Exist", "Registrationed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {


                            string register = "INSERT INTO Userapp VALUES ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox4.Text + "')";


                            cmd = new OleDbCommand(register, con);

                            cmd.ExecuteNonQuery();
                            con.Close();

                            textBox1.Text = "";
                            textBox3.Text = "";
                            textBox2.Text = "";
                            textBox5.Text = "";
                            textBox4.Text = "";
                            textBox6.Text = "";
                            MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                   }
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "";
                textBox6.Text = "";
                textBox3.Focus();
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
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
