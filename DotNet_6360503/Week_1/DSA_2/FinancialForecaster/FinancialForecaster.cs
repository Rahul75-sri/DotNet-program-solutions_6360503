public class FinancialForecaster
{
    public double CalculateFutureValue(double currentValue, double[] growthRates, int currentPeriod = 0)
    {
        if (currentPeriod >= growthRates.Length)
            return currentValue;
        double nextValue = currentValue * (1 + growthRates[currentPeriod]);
        return CalculateFutureValue(nextValue, growthRates, currentPeriod + 1);
    }

    // Iterative version for large datasets
    public double CalculateFutureValueIterative(double initialValue, double[] growthRates)
    {
        double result = initialValue;
        foreach (double rate in growthRates)
            result *= (1 + rate);
        return result;
    }
}
