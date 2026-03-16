namespace Core.Models;

public struct Price
{
    private decimal _amount = 200;
    private string _currency = "EURO";

    public decimal Amount
    {
        get => _amount;
        set => _amount = value < 0 ? 0 : value;
    }

    public string Currency
    {
        get => _currency;
        set => _currency = value;
    }
    public Price() { }

    public Price(decimal amount, string currency)
    {
        _amount = amount;
        _currency = currency;
    }

    public override string ToString()
    {
        return $"Price: {Amount} {Currency}";
    }
}