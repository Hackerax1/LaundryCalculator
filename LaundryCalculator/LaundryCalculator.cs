using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaundryCalculator
{
    public partial class LaundryCalculator : Form
    {
        public LaundryCalculator()
        {
            InitializeComponent();
        }

        private void LaundryCalculator_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int washDuration, dryDuration, numWashers, numDryers, numLoads;
            TimeSpan totalDuration2;
            DateTime startTime2, endTime;
            double totalLoadTime, totalLoadTimePerMachine, numLoadsPerMachine;
            
            washDuration = int.Parse(washTime.Text);
            dryDuration = int.Parse(dryTime.Text);
            numWashers = int.Parse(washerCount.Text);
            numDryers = int.Parse(dryerCount.Text);
            numLoads = int.Parse(loadCount.Text);

            int numMachines = Math.Min(numWashers, numDryers);
            if (numWashers != numDryers)
            {
                numMachines = Math.Min(numWashers, numDryers);
            }

            totalLoadTimePerMachine = (washDuration + dryDuration);
            numLoadsPerMachine = Math.Ceiling((double)numLoads / numMachines);
            totalLoadTime = totalLoadTimePerMachine * numLoadsPerMachine;
           
            startTime2 = startTime.Value;
            totalDuration2 = TimeSpan.FromMinutes(totalLoadTime);
            endTime = startTime2.Add(totalDuration2);

            string endTimeStr;
            if (totalDuration2.TotalHours >= 24)
            {
                endTimeStr = endTime.ToString();
            }
            else
            {
                endTimeStr = endTime.ToString("h:mm tt");
            }

            endtimeTextbox.Text = endTimeStr;

            //int totalHours = (int)totalDuration2.TotalHours;
            //int totalMinutes = totalDuration2.Minutes;
            //totalTimeTextbox.Text = string.Format("{0:D2}:{1:D2}", totalHours, totalMinutes);
            // Calculate and display the total duration in hours and minutes format
            int totalMinutes = (int)totalDuration2.TotalMinutes;
            int totalHours = totalMinutes / 60;
            int totalDays = totalHours / 24;
            totalHours = totalHours % 24;
            totalMinutes = totalMinutes % 60;

            string totalDurationStr;
            if (totalDays > 0)
            {
                if (totalHours == 0 && totalMinutes == 0)
                {
                    totalDurationStr = string.Format("{0} day{1}", totalDays, totalDays > 1 ? "s" : "");
                }
                else if (totalHours == 0)
                {
                    totalDurationStr = string.Format("{0} day{1} and {2} minute{3}", totalDays, totalDays > 1 ? "s" : "", totalMinutes, totalMinutes > 1 ? "s" : "");
                }
                else if (totalMinutes == 0)
                {
                    totalDurationStr = string.Format("{0} day{1} and {2} hour{3}", totalDays, totalDays > 1 ? "s" : "", totalHours, totalHours > 1 ? "s" : "");
                }
                else
                {
                    totalDurationStr = string.Format("{0} day{1}, {2} hour{3}, and {4} minute{5}", totalDays, totalDays > 1 ? "s" : "", totalHours, totalHours > 1 ? "s" : "", totalMinutes, totalMinutes > 1 ? "s" : "");
                }
            }
            else if (totalHours == 0)
            {
                totalDurationStr = string.Format("{0} minute{1}", totalMinutes, totalMinutes > 1 ? "s" : "");
            }
            else if (totalMinutes == 0)
            {
                totalDurationStr = string.Format("{0} hour{1}", totalHours, totalHours > 1 ? "s" : "");
            }
            else
            {
                totalDurationStr = string.Format("{0} hour{1} and {2} minute{3}", totalHours, totalHours > 1 ? "s" : "", totalMinutes, totalMinutes > 1 ? "s" : "");
            }

            totalTimeTextbox.Text = totalDurationStr;


            if (numLoads > 50)
            {
                MessageBox.Show("Why Gya Why");
            }
        }
    }
}
