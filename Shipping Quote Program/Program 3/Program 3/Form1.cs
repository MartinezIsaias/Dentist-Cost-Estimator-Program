//Grading ID: S2419
//Program 3
//CIS-199-50
//Due Date: 03/28/2024
//This program will calculate a final price for a shipping contract based on contract length, business, and shipping company
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Globalization;

namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBttn_Click(object sender, EventArgs e)
        {
            //Arrays for shipping Companies and their discount rates 
            string[] shippingCompanies = { "USPS", "DHL", "FedEx", "UPS" };
            double[] shipCompDiscountRates = { .25, .20, .17, .15 };
            //Arrays for businesses and their initial contract prices
            string[] BusName = { "John's Books", "Office Supplies", "J.B. Car Parts", "Gevalia Coffee", "Ceylon Tea", "My Footwear" };
            int[] InitContPrice = { 55000, 87880, 65000, 90000, 75500, 40550 };
            //Arrays for contract length and discounts
            double[] contractYearsLowerLimit = { 0, 2, 5, 8 };
            double[] addDiscount = { 0, 5000, 10000, 15000 };
            //declared boolean values for validating user input and variables used for the program and output 
            int contractLngthInt;
            int limit = contractYearsLowerLimit.Length - 1;
            double providerDiscount = 0;
            int initialContractPrice = 0;
            double additionalDiscount = 0;
            double totalProDiscount;
            double finalPrice;
            bool validContractLngth;
            bool providerFound = false;
            bool busFound = false;
            bool yearLngthFound = false;
            //Validating and TryParsing contract length input
            validContractLngth = int.TryParse(ContractLngthTxtBox.Text, out contractLngthInt) && contractLngthInt <= 10;
            if (ProviderCmboBox.SelectedIndex >= 0) //Validating combo box input
            {
                if (BusCmboBox.SelectedIndex >= 0) //Validating combo box input
                {
                    if (validContractLngth = true) 
                    {
                        for (int i = 0; i < shippingCompanies.Length; i++) //sequential search for provider and shipping discount
                        {
                            if (ProviderCmboBox.Text == shippingCompanies[i])
                            {
                                providerFound = true;
                                providerDiscount = shipCompDiscountRates[i];
                            }
                        }
                        for (int x = 0; x < BusName.Length; x++) //sequential search for business and initial contract price
                        {
                            if (BusCmboBox.Text == BusName[x])
                            {
                                busFound = false;
                                initialContractPrice = InitContPrice[x];
                            }
                        }
                        while (limit >= 0 && contractLngthInt < contractYearsLowerLimit[limit]) //Range match for contract length
                        {
                            --limit;
                        }
                        //
                        additionalDiscount = addDiscount[limit];
                        ProviderOutputLbl.Text = ProviderCmboBox.Text;
                        InContPriceOutput.Text = initialContractPrice.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                        totalProDiscount = initialContractPrice * providerDiscount;
                        CompDiscOutput.Text = totalProDiscount.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                        LngthDiscOutput.Text = additionalDiscount.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                        finalPrice = initialContractPrice - (initialContractPrice * providerDiscount) - additionalDiscount;
                        FinalPriceOutput.Text = finalPrice.ToString("C", CultureInfo.GetCultureInfo("en-US"));
                        //Calculating and outputing all fields at the bottom of the form ^^
                    }
                    else
                    {
                        MessageBox.Show("You Must Provide Valid Contract Years [0,10]"); //Error message if input is invalid
                    }
                }
                else
                {
                    MessageBox.Show("You Must Select a Business");//Error message if no selection
                }
            }
            else
            {
                MessageBox.Show("You Must Select a Provider");//Error message if no selection
            }
        }
    }
}
