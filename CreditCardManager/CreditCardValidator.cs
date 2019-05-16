using System;
using System.Linq;

namespace CreditCardManager
{
    internal static class CreditCardValidator
    {
        internal static bool ValidateCCNumber(string ccNumber, CardType cardType)
        {
            try
            {
                ccNumber = ccNumber.Replace("-", "").Replace(" ", ""); //clean number from dashes and spaces
                ccNumber = string.Join<char>(",", ccNumber); //join a ',' after every number to split it into array
                int[] ccNumbers = ccNumber.Split(',').Select(c => Convert.ToInt32(c)).ToArray(); //split it into string[] then select into num array

                int totalSum = (cardType == CardType.Amex) ? GetTotalSumDoubling(NumberPosition.Odds, ccNumbers) : GetTotalSumDoubling(NumberPosition.Evens, ccNumbers); //get totalSum doubling either odds or evens

                return totalSum % 10 == 0; //if divisible by 10 then valid card number
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private static int GetTotalSumDoubling(NumberPosition position, int[] ccNumbers)
        {
            int totalSum = 0;
            for (int currentIndex = 0; currentIndex < ccNumbers.Length; currentIndex++)
            {
                if (currentIndex % 2 == (int)position)
                {
                    var currentNum = ccNumbers[currentIndex];
                    var doubledNum = currentNum * 2;

                    if (doubledNum > 9)
                    {
                        int firstInt = doubledNum / 10;
                        int secondInt = doubledNum % 10;
                        totalSum += (firstInt + secondInt);
                    }
                    else
                    {
                        totalSum += doubledNum;
                    }
                }
                else
                {
                    totalSum += ccNumbers[currentIndex];
                }
            }
            return totalSum;
        }
    }

    internal enum CardType
    {
        Visa,
        Mastercard,
        Discover,
        Amex
    }

    internal enum NumberPosition
    {
        Evens = 0,
        Odds = 1
    }
}

