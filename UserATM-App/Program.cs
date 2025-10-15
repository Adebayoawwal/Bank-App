
Console.WriteLine("Hello to GTCO ATM App");
Console.WriteLine("Name");
var Name= Console.ReadLine();

Console.WriteLine("Pin");
var Pin= int.Parse(Console.ReadLine());
Console.WriteLine("Balance");
var Balance= int.Parse(Console.ReadLine());

Random rand = new Random();
int debitNum = rand.Next(1, 101); // Random number between 1 and 100
Console.WriteLine(debitNum);
Console.WriteLine("Welcome to GTCO ATM App and This is your debit number" + debitNum);
Console.WriteLine("Please choose an option:");
Console.WriteLine("1 Show Balance"); 
Console.WriteLine("2 Withdraw ");
Console.WriteLine("3 Deposit");
Console.WriteLine("4 Exit Application");
var OptionOfNumber = Console.ReadLine();

if (OptionOfNumber == "1")
{
    Console.WriteLine("Please enter a debit number ");
    int debitNumber = int.Parse(Console.ReadLine());
    if (debitNumber == debitNum)
    {
        Console.WriteLine("Balance is " +Balance);
    }
    else
    {
        Console.WriteLine("Invalid debit number ");
    }
}

if (OptionOfNumber == "2")
{
    Console.WriteLine("Please enter a debit number ");
    int debitNumber = int.Parse(Console.ReadLine());
    if (debitNumber == debitNum)
    {
        Console.WriteLine("please enter the amount of money you would like to withdraw ");
        int withdrawMoney = int.Parse(Console.ReadLine());
        if (withdrawMoney < Balance)
        {
         var  amount = Balance - withdrawMoney;
         Console.WriteLine("Balance remaining is " + Balance);
        }
        else
        {
            Console.WriteLine("You do not have enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid debit number ");
    }
}
if (OptionOfNumber == "3")
{
    Console.WriteLine("Please enter a debit number ");
    int debitNumber = int.Parse(Console.ReadLine());
    if (debitNumber == debitNum)
    {
        Console.WriteLine("please enter the amount of money you would like to deposit ");
        int withdrawMoney = int.Parse(Console.ReadLine());
        if (withdrawMoney < Balance)
        {
            var  amount = Balance - withdrawMoney;
            Console.WriteLine("Balance remaining is " + Balance);
        }
        else
        {
            Console.WriteLine("You do not have enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid debit number ");
    }
}



public class User;