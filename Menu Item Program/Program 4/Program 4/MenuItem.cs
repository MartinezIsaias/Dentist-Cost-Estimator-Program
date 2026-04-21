using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class MenuItem
    {
        double defaultPrice = 1; //default values for menu info
        int defaultCalories = 100;
        double defaultPrepTime = 1;
        int defaultSales = 1;
        private string _Name; //private back field values of object info
        private double _Price;
        private int _Calories;
        private double _PrepTime;
        private int _TotalSales;
        private bool _availability;
        public MenuItem(string FoodName, double Price, int Calories, double PrepTime, int TotalSales, bool Availability) 
        {
            _Name = FoodName;               //New variables so we can retrieve values and modify the value without editing the original variable
            _Price = Price;
            _Calories = Calories;
            _PrepTime = PrepTime;
            _TotalSales = TotalSales;
            _availability = Availability;
            if (_availability == true) 
            {
                ForceAvailable();
            }
            else
            {
                ForceUnavailable();
            }
        }
        public string FoodName
        {
            get {  return _Name; }
        }
        public double Price
        {
            get { return _Price; }              //Getters and setters for all menu item info that lets us retrieve and change the value while still maintaining the original menu output
            set {
                if (value >= 0)
                {
                    _Price = value;
                }
                else
                {
                    _Price = defaultPrice;
                }
            }
        }
        public int Calories
        {
            get { return _Calories; }
            set
            {
                if (value >= 0 )
                {
                    _Calories = value;
                }
                else
                {
                    _Calories = defaultCalories;
                }
            }
        }
        public double PrepTime 
        {  
            get { return _PrepTime; }
            set
            {
                if (value >= 0)
                {
                    _PrepTime = value;
                }
                else
                {
                    _PrepTime = defaultPrepTime;
                }
            }
        }
        public int TotalSales 
        { 
            get { return _TotalSales; } 
            set
            {
                if (value >= 0)
                {
                    _TotalSales = value;
                }
                else
                {
                    _TotalSales = defaultSales;
                }
            }
        }
        public bool Availability 
        { 
            get { return _availability; } 
            set 
            {
                if (value = true || false)
                {
                    _availability = value;
                }
                else 
                {
                    ForceUnavailable(); 
                }
            }
        }
        public void ForceAvailable()     //method that forces availability to true
        {
            _availability = true;
        }
        public void ForceUnavailable()   //method that forces availability to false
        {
            _availability = false;
        }
        public bool IsAvailable()       //method that returns the value of the availability bool
        {
            return _availability;
        }
        public override string ToString() //ToString() override so we can get the output we desire. 
        {
            return $"Name: {_Name}{Environment.NewLine}" +
                $"Price: ${_Price}{Environment.NewLine}" +
                $"Calories: {_Calories}{Environment.NewLine}" +
                $"Prep Time: {_PrepTime}{Environment.NewLine}" +
                $"Total Sales: {_TotalSales}{Environment.NewLine}" +
                $"Availability: {_availability}{Environment.NewLine}" +
                $"{Environment.NewLine}";

        }
    }
}
