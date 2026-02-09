using System;
    public class InterestCalculator
    {
        public double CalculateInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
    }

    class Program
    {
        static void Main()
    {
        InterestCalculator calculator = new InterestCalculator();

        Console.Write("Enter principal amount: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter time in years: ");
        double time = double.Parse(Console.ReadLine());

        double interest = calculator.CalculateInterest(principal, rate, time);
        Console.Write("Simple Interest: " + interest);
    }
}


