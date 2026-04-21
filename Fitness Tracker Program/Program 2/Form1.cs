//Grading ID: S2419
//Program 2
//CIS 199-50
//Description: This program will reward you with Fitpoints based on exercise type and if you smoke and hydrated. 
//Due Date: 03/07/24
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {





        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            const int runningRate = 10;           //Rate of points for running
            const int weightRate = 20;            //Rate of points for weight training
            const int cyclingRate = 5;            //Rate of points for cycling
            const int yogaRate = 2;               //Rate of points for yoga
            const int otherRate = 5;              //Rate of points for other
            const int MAXAGE = 120;               //Max age input
            const int MINAGE = 1;                 //Min age input
            const double smokePenalty = .5;       //Point penalty for smoking
            const double waterIncrease = 1.1;     //Point increase for hydrating
            double totalPointsBeforeAdj = 0;      //Points before adjustment
            double totalAdjPoints = 0;            //Points after adjustment
            int duration;                         //duration variable
            string userName = nameText.Text;      //name input string
            bool validAge;                        //boolean for valid age input
            bool validDuration;                   //boolean for valid duration input
            int userAge;                          //integer for TryParsing string age input to integer
            validDuration = int.TryParse(durationText.Text, out duration) && duration >= 1; //Validating duration input
            validAge = int.TryParse(ageText.Text, out userAge) && (userAge >= MINAGE) && (userAge <= MAXAGE); //Validating age input
            if (validAge ==  true) //if age is not valid
            {
                if (validDuration == true) //if duration is not valid
                {
                    if (exerciseTypeCombo.SelectedIndex >= 0)
                    {
                        if (waterNoBtn.Checked == true || waterYesBtn.Checked == true)
                        {
                            if (smokeNoBtn.Checked == true || smokeYesBtn.Checked == true)
                            {
                                if (exerciseTypeCombo.Text == "Running") //option running
                                {
                                    totalPointsBeforeAdj = (duration * runningRate);
                                    totalAdjPoints = totalPointsBeforeAdj;
                                    if (smokeYesBtn.Checked == true)
                                    {
                                        totalAdjPoints = totalAdjPoints * smokePenalty;
                                    }
                                    if (waterYesBtn.Checked == true)
                                    {
                                        totalAdjPoints = totalAdjPoints * waterIncrease;
                                    }
                                }
                                if (exerciseTypeCombo.Text == "Weight Training") //option weight training
                                {
                                    totalPointsBeforeAdj = duration * weightRate;
                                    totalAdjPoints = totalPointsBeforeAdj;
                                    if (smokeYesBtn.Checked == true)
                                    {
                                        totalAdjPoints = totalAdjPoints * smokePenalty;
                                    }
                                    if (waterYesBtn.Checked == true)
                                    {
                                        totalAdjPoints = totalAdjPoints * waterIncrease;
                                    }
                                }
                                if (exerciseTypeCombo.Text == "Cycling") //option cycling
                                {
                                    totalPointsBeforeAdj = duration * cyclingRate;
                                    totalAdjPoints = totalPointsBeforeAdj;
                                    if (smokeYesBtn.Checked == true)
                                    {
                                        totalAdjPoints = totalAdjPoints * smokePenalty;
                                    }
                                    if (waterYesBtn.Checked == true)
                                    {
                                        totalAdjPoints = totalAdjPoints * waterIncrease;
                                    }
                                }
                                if (exerciseTypeCombo.Text == "Yoga") //option yoga
                                {
                                    totalPointsBeforeAdj = duration * yogaRate;
                                    totalAdjPoints = totalPointsBeforeAdj;
                                    if (smokeYesBtn.Checked == true)
                                    {
                                        totalAdjPoints = totalAdjPoints * smokePenalty;
                                    }
                                    if (waterYesBtn.Checked == true)
                                    {
                                        totalAdjPoints = totalAdjPoints * waterIncrease;
                                    }
                                }
                                if (exerciseTypeCombo.Text == "Other") // option "other"
                                {
                                    totalPointsBeforeAdj = duration * otherRate;
                                    totalAdjPoints = totalPointsBeforeAdj;
                                    if (smokeYesBtn.Checked == true)
                                    {
                                        totalAdjPoints = totalAdjPoints * smokePenalty;
                                    }
                                    if (waterYesBtn.Checked == true)
                                    {
                                        totalAdjPoints = totalAdjPoints * waterIncrease;
                                    }
                                }
                                pointsOutput.Text = totalPointsBeforeAdj.ToString();
                                adjustOutput.Text = totalAdjPoints.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Please choose yes or no if you smoke");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please choose yes or no if you hydrated today");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an option for exercise type");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a valid duration");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid age from 1 to 120");
            }
        }
    }
}
