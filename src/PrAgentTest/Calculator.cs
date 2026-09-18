namespace PrAgentTest;

public sealed class Calculator
{
    public decimal Add(decimal first, decimal second)
        => first + second;

    public decimal Divide(decimal dividend, decimal divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException("The divisor cannot be zero.");
        }

        return dividend / divisor;
    }

    public async Task<decimal> CalculateTotalAsync(
        IEnumerable<decimal> values,
        CancellationToken cancellationToken = default)
    {
        await Task.Delay(10, cancellationToken);

        return values.Sum();
    }
}
