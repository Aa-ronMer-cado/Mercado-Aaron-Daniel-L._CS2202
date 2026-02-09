using System;

    public class CurrencyConverter
    {
        public double ConvertedCurrency(double USD, double rate)
        {
            return USD * rate;
        }
    }

    public class Program
    {
        static void Main()
        {
            CurrencyConverter converter = new CurrencyConverter();

            Console.Write("Enter amount in USD: ");
            double USD = double.Parse(Console.ReadLine());

            Console.Write("Enter exchange rate from USD to EUR: ");
            double rate = double.Parse(Console.ReadLine());

            double convertedAmount = converter.ConvertedCurrency(USD, rate);
            Console.Write("Amount in EUR: " + convertedAmount);
        }
    }