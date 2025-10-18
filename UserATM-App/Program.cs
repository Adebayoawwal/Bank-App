Console.WriteLine("Hello to GTCO ATM App");
Console.WriteLine("Name");
var Name= Console.ReadLine();
Console.WriteLine("Pin");
var Pin= int.Parse(Console.ReadLine());
Console.WriteLine("Balance");
var Balance= int.Parse(Console.ReadLine());
Random rand = new Random();
int debitNum = rand.Next(100000000, 900000000); // Random number between 1 and 100
// Console.WriteLine(debitNum);
Console.WriteLine("Welcome to GTCO ATM App and This is your Account number " + debitNum);
 choose:
Console.WriteLine("Please choose an option:");
Console.WriteLine("1 Show Balance"); 
Console.WriteLine("2 Withdraw ");
Console.WriteLine("3 Deposit");
Console.WriteLine("4 Exit Application");
var OptionOfNumber = int.Parse(Console.ReadLine());
x
if (OptionOfNumber == 1)
{
    Console.WriteLine("Please enter a Account number ");
      Start:
    bool debitNumber = int.TryParse(Console.ReadLine(), out var realNumber);
    if (debitNumber == true)
    {
        if (realNumber == debitNum)
        {
            Console.WriteLine("Balance is " +Balance);
            goto choose;
        }
    }
    else if (realNumber == null)
    {
        Console.WriteLine("Invalid Account number");
    }
    else
    {
        Console.WriteLine("Invalid Account number \n Enter a valid number.");
        goto Start;
    }
}

else if (OptionOfNumber == 2 )
{ 
    Console.WriteLine("Please enter a Account number ");
     Start:
    bool debitNumber = int.TryParse(Console.ReadLine(), out var realNumber);
    if (debitNumber==true)
    {
        if (realNumber == debitNum)
        {
            Console.WriteLine("please enter the amount of money you would like to withdraw ");
            int withdrawMoney = int.Parse(Console.ReadLine());
            if (withdrawMoney < Balance)
            {
                var  amount = Balance - withdrawMoney;
                Console.WriteLine("Balance remaining is " + amount);
                goto choose;
            }
        }
        else if (realNumber == null)
        {
            Console.WriteLine("Invalid Account number");
            goto Start;
        }
        else
        {
            Console.WriteLine("Invaild Account number");
            goto Start;
        }
    }
}
else if (OptionOfNumber == 3)
{
    Console.WriteLine("Please enter a Account number ");
    Start:
    bool debitNumber = int.TryParse(Console.ReadLine(), out var realNumber);
    if (debitNumber == true)
    {
        if (realNumber == debitNum)
        {
            Console.WriteLine("please enter the amount of money you would like to deposit ");
            int depositMoney = int.Parse(Console.ReadLine());
            if (depositMoney < Balance && depositMoney > 0 || Balance == depositMoney)
            {
                var  amount = Balance + depositMoney;
                Console.WriteLine("Balance remainig is " + amount);
                goto choose;
            }
        }   
    }
    else if (realNumber == null)
    {
        Console.WriteLine("Invalid Pho number");
        goto Start;
    }
    else
    {
        Console.WriteLine("Invaild debit number");
        goto Start;
    }
}

else if (OptionOfNumber == 4)
{
    Environment.Exit(0);   
}
else
{
    Console.WriteLine("Invaild Input");
    goto choose;
}



