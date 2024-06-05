using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RhodesTravelGuide
{
    public class Savee
    {
        private String file;

        public Savee(String file)
        {
            this.file = file;
        }


        public void WriteTxt(RichTextBox richtbox)
        {
            try
            {
                string t = richtbox.Text;

                using (StreamWriter sw1 = new StreamWriter(file, false))
                {
                    try
                    {
                        sw1.Write(t);
                    }
                    catch (ObjectDisposedException e1)
                    {
                        MessageBox.Show("Object Disposed Exception");
                    }
                    catch (NotSupportedException e2)
                    {
                        MessageBox.Show("Not Supported Exception");
                    }
                    catch (IOException e3)
                    {
                        MessageBox.Show(e3.GetType().Name);
                    }

                }
            }
            catch (IOException ex)
            {

                MessageBox.Show(ex.GetType().Name);
            }
            catch (UnauthorizedAccessException e1)
            {
                MessageBox.Show("Unauthorized Access Exception");
            }
            catch (ArgumentException e2)
            {
                MessageBox.Show("Argument Exception");
            }

        }
        public void SuccessWriteTxt()
        {
            if (File.Exists(file))
            {
                MessageBox.Show("H αποθήκευση ολοκληρώθηκε επιτυχώς!! Ελέγξτε τον φάκελο Debug στο αρχείο RhodesTravelGuide Follow this path:RhodesTravelGuide / RhodesTravelGuide/ bin/ Debug ");
            }
            else
            {
                MessageBox.Show("Η αποθήκευση απέτυχε");
            }
        }
    }
}

