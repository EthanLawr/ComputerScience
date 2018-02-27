using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_ProgramLarge6
{
    class Program : Colors
    {
        //What the coins and dollars are worth
        internal const decimal WORTH_OF_TWENTY_DOLLARS = 20.00M, WORTH_OF_TEN_DOLLARS = 10.00M,
            WORTH_OF_FIVE_DOLLARS = 5.00M, WORTH_OF_A_DOLLAR = 1.00M, WORTH_OF_A_QUARTER = 0.25M,
            WORTH_OF_A_DIME = 0.10M, WORTH_OF_A_NICKEL = 0.05M, WORTH_OF_A_PENNY = 0.01M;
        internal const int CHANGE_LIMIT = 100;
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)                                        //Error looping
            {
                try
                {
                    TaskShortener.Header();
                    decimal totalChange = TaskShortener.AskUserForDecimal("the total change you have");

                    #region Change Limiter
            while (totalChange > CHANGE_LIMIT)
            {
                TaskShortener.ErrorCatch();
            }
            #endregion

                    TotalChangeCalcForDollars(totalChange);
                    TotalChangeCalcForCoins(totalChange);

                    TaskShortener.Footer();
                    break;
                }
                catch (FormatException) //Trying to error it eh?
                {
                    TaskShortener.ErrorCatch();
                }
            }
        }

        public static void TotalChangeCalcForDollars(decimal x)
        {
            #region Calculations                                      
            int amountOfTwentyDollarBills = (int)(x / WORTH_OF_TWENTY_DOLLARS),

                amountOfTenDollarBills = (int)((x % WORTH_OF_TWENTY_DOLLARS)
                   / WORTH_OF_TEN_DOLLARS),

                amountOfFiveDollarBills = (int)(((x % WORTH_OF_TWENTY_DOLLARS)
                   % WORTH_OF_TEN_DOLLARS) / WORTH_OF_FIVE_DOLLARS),

                amountOfOneDollarBills = (int)((((x % WORTH_OF_TWENTY_DOLLARS)
                   % WORTH_OF_TEN_DOLLARS) % WORTH_OF_FIVE_DOLLARS) / WORTH_OF_A_DOLLAR);
            #endregion

            #region Console Display
            MagentaFont();
            //Total Change
            Console.Write("If you have "); YellowFont();
            Console.Write("{0:C2} . . .", x); MagentaFont();
            Console.Write(" then your change for dollars is:\n"); YellowFont();
            //Twenty Dollar Bills
            Console.Write("{0} ", amountOfTwentyDollarBills); MagentaFont();
            Console.Write(" twenty dollars bills, "); YellowFont();
            //Ten Dollar Bills
            Console.Write("{0}", amountOfTenDollarBills); MagentaFont();
            Console.Write(" ten dollars bills,\n"); YellowFont();
            //Five Dollar Bills
            Console.Write("{0}", amountOfFiveDollarBills); MagentaFont();
            Console.Write(" five dollars bills, "); YellowFont();
            //One Dollar Bills
            Console.Write("and {0} ", amountOfOneDollarBills); MagentaFont();
            Console.Write(" one dollar bills.\n");
            TaskShortener.Loading();

            //Color changes to help the user find the value they want!
            #endregion
        }
        public static void TotalChangeCalcForCoins(decimal x)
        {
            #region Calculations
            int dollarModulus = (int)((((x % WORTH_OF_TWENTY_DOLLARS) % WORTH_OF_TEN_DOLLARS)
                % WORTH_OF_FIVE_DOLLARS) % WORTH_OF_A_DOLLAR);

            int amountOfQuarters = (int)(dollarModulus / WORTH_OF_A_QUARTER),

                amountOfDimes = (int)((dollarModulus % WORTH_OF_A_QUARTER) / WORTH_OF_A_DIME),

                amountOfNickels = (int)(((dollarModulus % WORTH_OF_A_QUARTER) % WORTH_OF_A_DIME)
                    / WORTH_OF_A_NICKEL),

                amountOfPennies = (int)((((dollarModulus % WORTH_OF_A_QUARTER) % WORTH_OF_A_DIME)
                    % WORTH_OF_A_NICKEL) / WORTH_OF_A_PENNY);
            #endregion

            #region Console Display
            MagentaFont();
            //Bar amount
            Console.Write("Your change for coins are:\n"); YellowFont();
            //Twenty Dollar Bills
            Console.Write("{0} ", amountOfQuarters); MagentaFont();
            Console.Write(" quarters, "); YellowFont();
            //Ten Dollar Bills
            Console.Write("{0}", amountOfDimes); MagentaFont();
            Console.Write(" dimes,\n"); YellowFont();
            //Five Dollar Bills
            Console.Write("{0}", amountOfNickels); MagentaFont();
            Console.Write(" nickels, "); YellowFont();
            //One Dollar Bills
            Console.Write("and {0} ", amountOfPennies); MagentaFont();
            Console.Write(" pennies.\n");
            //Color changes to help the user find the value they want!
            #endregion
        }
    }
}
