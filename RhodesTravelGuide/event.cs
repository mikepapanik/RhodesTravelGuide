using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhodesTravelGuide
{
    public class even
    {
        public static void find_event(DateTime dt, DateTime dateuse, Label anewlabel)
        {

            if (dt.Equals(dateuse))
            {
                anewlabel.Text = "Συναυλία του Συγκροτήματος Πυξ Λαξ";

            }
            else
            {
                anewlabel.Text = "Δεν υπάρχει σήμερα κάποια εκδήλωση!";
            }

        }
   

        }
    }
   

    




