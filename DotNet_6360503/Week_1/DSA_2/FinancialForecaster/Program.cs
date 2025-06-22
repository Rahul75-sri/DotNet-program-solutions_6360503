using System;

class Program
{
    static void Main()
    {
        var forecaster = new FinancialForecaster();
        double initialValue = 1000;
        double[] growthRates = { 0.05, 0.07, 0.03 };

        double recursiveResult = forecaster.CalculateFutureValue(initialValue, growthRates);
        Console.WriteLine($"Recursive forecast: {recursiveResult:F2}");

        double iterativeResult = forecaster.CalculateFutureValueIterative(initialValue, growthRates);
        Console.WriteLine($"Iterative forecast: {iterativeResult:F2}");
    }
}
