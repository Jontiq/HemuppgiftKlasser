namespace HemuppgiftKlasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee("Jane", "Smith");
            //employee.Salary = 3000;
            //Console.WriteLine($"Annual Salary: {employee.GetAnnualSalary()}");
            //employee.GiveRaise(10);
            //Console.WriteLine($"New Monthly Salary: {employee.Salary}");
            //Console.WriteLine($"New Annual Salary: {employee.GetAnnualSalary()}");

            BankAccount account = new BankAccount("123456789", "John Doe", 0);
            account.Deposit(500);
            account.Withdraw(600);
            account.DisplayBalance();
        }
    }
}
