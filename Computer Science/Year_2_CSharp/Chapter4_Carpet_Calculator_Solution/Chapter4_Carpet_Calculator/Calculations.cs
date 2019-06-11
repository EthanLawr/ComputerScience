using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Carpet_Calculator
{
    class Calculations
    {
        private double pricePerSqYard, noOfSquareYards;
        public double Price
        {
            get
            {
                return pricePerSqYard;
            }
            set
            {
                pricePerSqYard = value;
            }
        }
        public Calculations()
        {
        }
        public Calculations(double amountNeeded, double price)
        {
            noOfSquareYards = amountNeeded;
            pricePerSqYard = price;
        }
        public Calculations(double price)
        {
            pricePerSqYard = price;
        }
        public double DetermineTotalCost()
        {
            return (pricePerSqYard * noOfSquareYards);
        }
        public void setNoOfSquareYards(double length, double width)
        {
            const int SQ_FT_PER_SQ_YARD = 9;
            noOfSquareYards = length * width / SQ_FT_PER_SQ_YARD;
        }
        public void SetNoOfSquareYards(double squareYards)
        {
            noOfSquareYards = squareYards;
        }
        public double GetNoOfSquareYards()
        {
            return noOfSquareYards;
        }
        public override string ToString()
        {
            return "Price Per Square Yard: " + pricePerSqYard.ToString("C") + "\nTotal Square Yards: " + noOfSquareYards.ToString("F1") + 
                "\nTotal Price: " + DetermineTotalCost().ToString("C");
        }
    }
}
