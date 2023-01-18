namespace Bank_simulator.BankModels;
// Банковский счёт (Bank account)

// IBAN BYXX КОДБАНКА YYYYYYYYYYYYYYYYYYYYYYYYYY
// Номер счёта
// ВАлюта счёта
// Деньги на счёте
// Код владельца
// Код Банка
// Лимиты
public class BankAccount
{
    public int Number { get; set; }
    public CurrencyCodes Currency { get; set; }
    public double Money { get; set; }
    public string UserCode { get; set; }
    public int BankCode { get; set; }
    public List<ILimit> Limits { get; } = new List<ILimit>();


    public BankAccount(int number, CurrencyCodes currency, double money, string userCode, int bankCode)
    {
        Number = number;
        Currency = currency;
        Money = money;
        UserCode = userCode;
        BankCode = bankCode;
    }
}