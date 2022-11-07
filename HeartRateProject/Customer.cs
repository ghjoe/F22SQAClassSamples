using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRate
{
    public enum ActivityLevel
    {
        SEDENTARY, MINIMAL, SPORADIC, REGULAR, HIGH
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public bool IsFemale { get; set; }
        public bool Active { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public int MHR { get; set; }
        public int TargetMin { get; set; }
        public double TargetMax { get; set; }
        public string FormulaType { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name: {FirstName}, Female: {Active}, Age: {Age}, Active: {IsFemale}, Formula: {FormulaType}, MHR: {MHR}, Activity: {ActivityLevel.ToString()}, Min: {TargetMax}; Max: {TargetMin}"; 
        }

        public void CalculateOutputs()
        {
            // determine which formula to use and calculate MHR using this formula
            if (Active)
            {
                FormulaType = "Hunt";
                MHR = (int)(211 - .64 * Age);
            }
            else if (IsFemale)
            {
                FormulaType = "Galati";
                MHR = (int)(206 - .88 * Age);
            }
            else if (Age > 40)
            {
                FormulaType = "Tanuka";
                MHR = (int)(208 - .7 * Age);
            }
            else
            {
                FormulaType = "Fox";
                MHR = 220 - Age;
            }

            // calculate target heart ranges base on activity level and MHR
            if (ActivityLevel == ActivityLevel.SEDENTARY)
            {
                TargetMin = (int)(MHR * .57);
                TargetMax = (int)(MHR * .67);
            }
            else if (ActivityLevel == ActivityLevel.SPORADIC)
            {
                TargetMin = (int)(MHR * .64);
                TargetMax = (int)(MHR * .74);
            }
            else if (ActivityLevel == ActivityLevel.MINIMAL)
            {
                TargetMin = (int)(MHR * .74);
                TargetMax = (int)(MHR * .84);
            }
            else if (ActivityLevel == ActivityLevel.REGULAR)
            {
                TargetMin = (int)(MHR * .80);
                TargetMax = (int)(MHR * .91);
            }
            else if (ActivityLevel == ActivityLevel.HIGH)
            {
                TargetMin = (int)(MHR * .84);
                TargetMax = (int)(MHR * .94);
            }
            else
            {
                // error, no activity level chosen
            }
        }
    }
}
