Console.Write("plaess Creat password :");
int pin1 = int.Parse(Console.ReadLine());
Console.Write("plaess conferam password :");
int pin2 = int.Parse(Console.ReadLine());
if (pin1 != pin2)
{
    Console.WriteLine("The password is not matching pleass tey agine : ");
    Console.Write("plaess Creat password :");
    pin1 = int.Parse(Console.ReadLine());
    Console.Write("plaess conferam password :");
    pin2 = int.Parse(Console.ReadLine());
}
Console.Write("preass Enter password For accaes your ATM : ");
int pin = int.Parse(Console.ReadLine());
if (pin == pin1)
{
    double balance = 0;
    Console.WriteLine("Sorry your balance is : " + balance + "");
    Console.Write("firs thing you must be Dopesit : ");
    double amount_dopesit = double.Parse(Console.ReadLine());
    balance += amount_dopesit;
    Console.Write("Successfuly the Dopesit: " + amount_dopesit + " your balance is : " + balance + "");
    bool runnig = true;

    while (runnig == true)
    {
        Console.WriteLine();
        Console.WriteLine("plaess chaees Opration you want ");
        Console.WriteLine("preass number 1 to cheek balance ");
        Console.WriteLine("preass number 2 to Withdraw ");
        Console.WriteLine("preass number 3 to Deposit ");
        Console.WriteLine("preass number 4 to Exsit ");
        Console.WriteLine("------------------------------------------- ");

        string opration = Console.ReadLine();

        switch (opration)
        {
            case "1":
                Console.Write("Your balance is :" + balance + " ");
                break;
            case "2":
                if (balance <= 0)
                {
                    Console.Write("Can not Withdraw your balanc is zero ");
                }
                else
                {
                    Console.Write("Plaess Enter Total amount to withdraw ");
                    double total_amount = double.Parse(Console.ReadLine());
                    if (total_amount > balance)
                    {
                        Console.Write("Sory your palanc not alled ");
                    }
                    else
                    {
                        balance -= total_amount;
                        Console.Write("Successfuly the withdeaw: " + total_amount + " your balance is : " + balance + "");
                    }

                }
                break;
            case "3":
                Console.Write("Pleass Enter The amount To Dopesit : ");
                amount_dopesit = double.Parse(Console.ReadLine());
                balance += amount_dopesit;
                Console.Write("Successfuly the Dopesit: " + amount_dopesit + " your balance is : " + balance + "");
                break;
            case "4":
                Console.WriteLine("Tanks for uosing our ATM");
                runnig = false;
                break;
            default:
                Console.Write("Invalid Opration tray agin ");
                break;
        }

    }
}
else
{
    Console.Write("The  password is not matched ");
}
