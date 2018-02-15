using System;

namespace Ch4_ProgramLarge6
{
    class Change : Colors
    {
        //variable limiting the maximum allowed change calculated.
        internal const int CHANGE_LIMIT = 100;
        
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)                                        //Error looping
            {
                try
                {
                    TaskShortener.Header();

                    //Asks the amount of change you have
                    decimal totalChange = TaskShortener.AskUserForDecimal("the total change you have");
                    
                    //Limits the amount of change that can be calculated
                    #region Change Limiter
                    while (totalChange > CHANGE_LIMIT)
                        {
                            TaskShortener.ErrorCatch();
                        }
                    #endregion

                    TaskShortener.Loading();
                    TotalChangeCalc(totalChange); //Calc and display of dollars

                    TaskShortener.Footer();
                    break;
                }
                catch (FormatException) //Trying to error it eh?
                {
                    TaskShortener.ErrorCatch();
                }
            }
        }

        public static void TotalChangeCalc(decimal x)
        {
            //Declaring what each is worth
            #region Calculations
            var coinTypes = new[]
            {
                new { type = "Twenty Dollar Bills", coinWorth = 20.00m }, //20$ Bills
                new { type = "Ten Dollar Bills",    coinWorth = 10.0m },  //10$ Bills
                new { type = "Five Dollar Bills",   coinWorth = 5.00m },  //5$ Bills
                new { type = "One Dollar Bills",    coinWorth = 1.00m },  //1$ Bills
                new { type = "Quarters",            coinWorth = 0.25m },  //Quarters
                new { type = "Dimes",               coinWorth = 0.10m },  //Dimes
                new { type = "Nickels",             coinWorth = 0.05m },  //Nickels
                new { type = "Pennies",             coinWorth = 0.01m }   //Pennies
            };
            #endregion

            #region Console Display
            foreach (var coin in coinTypes)
            {
                //Reusing X over and over and getting remainders until the answer is acheived
                int countedChange = (int)(x / coin.coinWorth); 
                x -= countedChange * coin.coinWorth; 
                LimeFont();
                TaskShortener.TypeLineFast($"{countedChange} {coin.type}\n"); //Displays the stuff
            }
            #endregion
        }
    }
}
