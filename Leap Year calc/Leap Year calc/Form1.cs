using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leap_Year_calc
{
    //My Leap Year Calculator, there are many like it, but this is mine
    public partial class Frm_leapCalc : Form
    {
        public Frm_leapCalc()
        {
            InitializeComponent();
        }
        private void btn_Calc_Click(object sender, EventArgs e)
        {
            try
            {
                //variables to use during loop (all numerical)
                int startyear = Convert.ToInt32(Txt_startYr.Text);
                int endyear = Convert.ToInt32(Txt_Endyr.Text);
                int count = 0;
                //loop runs for all possible years
                while (startyear <= endyear)
                {
                    if (startyear % 4 == 0 && startyear % 100 != 0 || startyear % 4 == 0 && startyear % 400 == 0 && startyear % 100 == 0)
                    {
                        //if yeatr is a leap year, count it
                        count = count + 1;
                    }
                    //increment using start year
                    startyear = startyear + 1;
                }
                //tell user the information
                MessageBox.Show("There are " + count + " Leap Years between " + Txt_startYr.Text + " and " + Txt_Endyr.Text, Txt_startYr.Text + " to " + Txt_Endyr.Text + " Leap Year Calculator");
            }
            catch
            {
                Console.Write("something broke");
            }
        }
    }
}
