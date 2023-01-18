namespace Bank_simulator.BankModels;

public class User
{
    public int Id { get; }
    public string Name { get; set; } = "noname";

    public User(int id)
    {
        Id = id;
    }

    public User(int id, string name) : this(id)
    {
        Name = name;
    }

    public override bool Equals(Object? obj)
    {
        if (base.Equals(obj))
        {
            System.Console.WriteLine("Links are equals");
            return true;
        }
        if (obj == null || obj is not User)
        {
            return false;
        }

        User user = (User)obj;
        return Id == user.Id && Name == user.Name;
    }

    public override int GetHashCode()
    {
        return Id * 1000 + Name.Length;
    }
}