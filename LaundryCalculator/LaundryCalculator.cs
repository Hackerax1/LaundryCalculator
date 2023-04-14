using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            endtimeTextbox.Text = endTime.ToString("h:mm tt");

            //int totalHours = (int)totalDuration2.TotalHours;
            //int totalMinutes = totalDuration2.Minutes;
            //totalTimeTextbox.Text = string.Format("{0:D2}:{1:D2}", totalHours, totalMinutes);

            int totalMinutes = (int)totalDuration2.TotalMinutes;
            int totalHours = totalMinutes / 60;
            totalMinutes = totalMinutes % 60;

            string totalDurationStr;
            if (totalHours == 0)
            {
                totalDurationStr = string.Format("{0} minutes", totalMinutes);
            }
            else if (totalMinutes == 0)
            {
                totalDurationStr = string.Format("{0} hours", totalHours);
            }
            else
            {
                totalDurationStr = string.Format("{0} hours and {1} minutes", totalHours, totalMinutes);
            }
            totalTimeTextbox.Text = totalDurationStr;

            if (numLoads > 50)
            {
                MessageBox.Show("Why Gya Why");
            }
        }
    }
}
