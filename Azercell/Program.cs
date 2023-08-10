namespace Azercell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            SimCard simCard = new("Azercell", "+994(500505050)", 2M, 0.5M);

            Console.WriteLine("Carrier Name: " + simCard.CarrierName);
            Console.WriteLine("Number: " + simCard.Number);
            Console.WriteLine("Balance: " + simCard.Balance + "AZN");
            Console.WriteLine("Tariff: " + simCard.Tariff + "AZN");

            Console.Write("Increase Balance: ");
            decimal increase = Convert.ToDecimal(Console.ReadLine());

            simCard.IncreaseBalance(increase);
            Console.WriteLine(simCard.Balance);

            Console.Write("Who do you want to talk to (Write Name): ");
            string name = Console.ReadLine();

            simCard.Call();
            Console.WriteLine("Last Speech with " + name);
            Console.WriteLine("Last Balance: " + simCard.Balance);

        }

    }
}

public class SimCard
{
    public string? CarrierName { get; set; }
    public string? Number { get; set; }
    public decimal Balance { get; set; }
    public decimal Tariff { get; set; }

    public SimCard(string carrierName, string number, decimal balance, decimal tariff)
    {
        CarrierName = carrierName;
        Number = number;
        Balance = balance;
        Tariff = tariff;
    }
    public void IncreaseBalance(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("The amount you entered is not valid");
            return;
        }
        Balance += amount;
    }
    public void Call()
    {
        if (Tariff > Balance)
        {
            Console.WriteLine("There are not enough funds in the balance");
            return;
        }
        Balance -= Tariff;

    }

}
