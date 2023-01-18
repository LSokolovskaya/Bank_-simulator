namespace Bank_simulator.BankModels;

public interface ILimit
{
    int MaxOperations { get; }
    int MaxSum { get; }

}