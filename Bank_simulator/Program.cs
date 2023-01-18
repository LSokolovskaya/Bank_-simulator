using Bank_simulator.BankModels;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ExchangeRate> rates = new List<ExchangeRate>();   // ExchangeRate[] rates = { ex1, ex2 };  
            Currency currency = new Currency((int)CurrencyCodes.USD, "Доллар США", "$", CurrencyCodes.USD.ToString());
            System.Console.WriteLine((CurrencyCodes)currency.Code == CurrencyCodes.USD);
            rates.Add(new ExchangeRate((int)CurrencyCodes.BYN, (int)CurrencyCodes.USD, 2.67));
            rates.Add(new ExchangeRate((int)CurrencyCodes.BYN, (int)CurrencyCodes.EURO, 2.83));
            rates.Add(new ExchangeRate((int)CurrencyCodes.BYN, (int)CurrencyCodes.GBP, 2.91));
            rates.Add(new ExchangeRate((int)CurrencyCodes.USD, (int)CurrencyCodes.EURO, 0.97));
            rates.Add(new ExchangeRate((int)CurrencyCodes.USD, (int)CurrencyCodes.GBP, 0.9));
            rates.Add(new ExchangeRate((int)CurrencyCodes.USD, (int)CurrencyCodes.PLN, 5));
            rates.Add(new ExchangeRate((int)CurrencyCodes.BYN, (int)CurrencyCodes.PLN, 0.4));
            System.Console.WriteLine(rates.Count);
            System.Console.WriteLine(rates.FirstOrDefault(x => x.CurrencyFrom == (int)CurrencyCodes.PLN && x.CurrencyTo == (int)CurrencyCodes.USD));
        }
    }
}
