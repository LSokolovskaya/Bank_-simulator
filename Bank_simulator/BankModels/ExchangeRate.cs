namespace Bank_simulator.BankModels;
// Из какой валюты переводим
// В какую валюту переводим
// обменный курс

public class ExchangeRate
{
    public int CurrencyFrom { get; set; }
    public int CurrencyTo { get; set; }
    public double Rate { get; set; }

    public ExchangeRate()
    {

    }

    public ExchangeRate(int currencyFrom, int currencyTo, double rate)
    {
        CurrencyFrom = currencyFrom;
        CurrencyTo = currencyTo;
        Rate = rate;
    }

    public override string ToString()
    {
        return $"{Rate}";
    }
}