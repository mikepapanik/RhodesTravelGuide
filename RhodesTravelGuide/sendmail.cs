using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhodesTravelGuide
{
    public class sendmails
    {
        private MailMessage msg;

        public void Sendmail(TextBox textBox1, TextBox textBox2)
        {

            try
            {
                msg = new MailMessage(textBox1.Text, "rhodestravel12@gmail.com", "RhodesTravelGuide ", textBox2.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.GetType().Name);
            }
            catch (ArgumentException ex1)
            {
                MessageBox.Show(ex1.GetType().Name);
            }


            SmtpClient mail = new SmtpClient();
            mail.Host = "smtp.gmail.com";
            mail.Port = 587;
            mail.Credentials = new NetworkCredential("rhodestravel12@gmail.com", "Mp12345678");
            mail.EnableSsl = true;
            
            try
            {
                mail.Send(msg);
                MessageBox.Show("Message has been sent");
            }
            catch (SmtpException exc)
            {
                MessageBox.Show(exc.GetType().Name);
            }
            catch (ArgumentException e1)
            {
                MessageBox.Show("Argument Exception");
            }
            catch (InvalidOperationException e2)
            {
                MessageBox.Show("Invalid Operation Exception");
            }
        }
    }
}
