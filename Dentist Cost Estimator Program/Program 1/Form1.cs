using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Name: Isaiah Martinez
// Due Date: 2/13/2024
// Grading ID: S2419
// Program 1
// Week 6
// Description: This program will generate a quote for dental work based on dental care needs.

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CitTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void StaffTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void MatTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void DuraTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProcTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientTxtBx_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void NameOutput_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameOutput.Text=NameTxtBx.Text;
            ProOutput.Text = ProcTxtBx.Text;
            DurOutput.Text = DuraTxtBx.Text;
            const double ConsultFee = 100;
            const double BiggRate = 50;
            const double StaffRate = 25;
            const double MaterialCost = .10;
            const double SeniorCtznDiscnt = .10;
            double totalcost;
            double WithDiscount;
            double duration = Double.Parse(DuraTxtBx.Text);
            double MaterialNdd = Double.Parse(MatTxtBx.Text);
            double StaffNdd = Int32.Parse(StaffTxtBx.Text);
            double SeniorCtzn = Int32.Parse(CitTxtBx.Text);
            totalcost = ConsultFee + (BiggRate * duration) + (StaffNdd * StaffRate * duration) + (MaterialCost * MaterialNdd);
            WithDiscount = totalcost - (totalcost * SeniorCtznDiscnt * SeniorCtzn);
            TotalOutput.Text = $"{WithDiscount:c}";



        }
    }
}
