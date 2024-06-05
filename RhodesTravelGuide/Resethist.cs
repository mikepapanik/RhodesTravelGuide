using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhodesTravelGuide
{
    class Resethist : res
    {
        public void PrintHis(Button btn, String text)
        {

            if (btn.ForeColor == Color.Red)
            {
                try
                {
                    using (StreamWriter sw1 = new StreamWriter(text, false))
                    {
                        try
                        {
                            sw1.Write("Ο χρήστης είδε την καρτέλα " + btn.Text);
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
                catch (SecurityException e3)
                {
                    MessageBox.Show("Security Exception");
                }


            }
            else
            {
                try
                {


                    using (StreamWriter sw1 = new StreamWriter(text, false))
                    {
                        try
                        {
                            sw1.Write("Ο χρήστης δεν είδε την καρτέλα " + btn.Text);
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
                catch (SecurityException e3)
                {
                    MessageBox.Show("Security Exception");
                }
            }
        }

        public void DeleteHis(ArrayList arr)
        {
            foreach (String t in arr)
            {
                if (File.Exists(t))
                {
                    try
                    {
                        File.Delete(t);
                    }
                    catch (ArgumentException e1)
                    {
                        MessageBox.Show("Argument Exception");
                    }
                    catch (IOException e2)
                    {
                        MessageBox.Show(e2.GetType().Name);
                    }
                    catch (NotSupportedException e3)
                    {
                        MessageBox.Show("Not Supported Exception");
                    }
                    catch (UnauthorizedAccessException e4)
                    {
                        MessageBox.Show("Unauthorized Access Exception");
                    }


                }
            }
        }
    }
}

