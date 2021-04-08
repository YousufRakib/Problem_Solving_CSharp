using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace CargoProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        int carTotalUnit = 0;
        int truckTotalUnit = 0;
        int motorCycleTotalUnit = 0;
        int trainCarTotalUnit = 0;
        int totalLoaded = 0;

        private void newBoatButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void motorCycleBar_Scroll(object sender, EventArgs e)
        {
            noOfMotorCycle.Text = motorCycleBar.Value.ToString();
            motorCycleTotalUnit = motorCycleBar.Value*3;
            totalLoaded = carTotalUnit + truckTotalUnit + motorCycleTotalUnit + trainCarTotalUnit;
            loaded.Text = totalLoaded.ToString();
            if (totalLoaded > 239)
            {
                reactionColor.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                reactionColor.BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        private void truckBar_Scroll(object sender, EventArgs e)
        {
            noOfTruck.Text = truckBar.Value.ToString();
            truckTotalUnit = truckBar.Value*11;
            totalLoaded = carTotalUnit + truckTotalUnit + motorCycleTotalUnit + trainCarTotalUnit;
            loaded.Text = totalLoaded.ToString();
            if (totalLoaded > 239)
            {
                reactionColor.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                reactionColor.BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        private void carBar_Scroll(object sender, EventArgs e)
        {
            noOfCar.Text = carBar.Value.ToString();
            carTotalUnit = carBar.Value*5;
            totalLoaded = carTotalUnit + truckTotalUnit + motorCycleTotalUnit + trainCarTotalUnit;
            loaded.Text = totalLoaded.ToString();
            if (totalLoaded > 239)
            {
                reactionColor.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                reactionColor.BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        private void trainCarBar_Scroll(object sender, EventArgs e)
        {
            noOfTrainCar.Text = trainCarBar.Value.ToString();
            trainCarTotalUnit = trainCarBar.Value*17;
            totalLoaded = carTotalUnit + truckTotalUnit + motorCycleTotalUnit + trainCarTotalUnit;
            loaded.Text = totalLoaded.ToString();
            if (totalLoaded > 239)
            {
                reactionColor.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                reactionColor.BackColor = System.Drawing.Color.LimeGreen;
            }
        }
    }
}
