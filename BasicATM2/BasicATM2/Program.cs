namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 5000;
            int password = -1;
            while (true)
            {
                Console.WriteLine("PLEASE ENTER YOUR PASSWORD...");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    password = result;
                }
                if (password == 1234)
                {
                    Console.WriteLine("Your password is correct. Please select the action you want to do...");
                    break;
                }
                else
                {
                    Console.WriteLine("Your password is wrong! Please try again...");
                }
            }
            Console.WriteLine("WELCOME TO OUR BANK, DEAR CUSTOMER. WE WISH YOU A NICE DAY :)");
            Console.WriteLine("\n **************TRANSACTIONS************* \n");
            Console.WriteLine("Your Balance : " + money);
            Console.WriteLine("1. Withdraw money");
            Console.WriteLine("2. Deposit money");
            Console.WriteLine("3. Ask your balance");
            Console.WriteLine("4. Card return");

            Console.Write("\n PLEASE SELECT THE ACTION YOU WISH TO DO...");
            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    Console.WriteLine("YOUR BALANCE : " + money);
                    Console.Write("ENTER THE AMOUNT YOU WISH TO WITHDRAW : ");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    if (tutar <= money)
                    {
                        Console.WriteLine("Your withdrawal has been successfully completed!");
                        money = money - tutar;
                        Console.WriteLine("Your transaction is complete. Your new balance : " + money);
                    }
                    else
                    {
                        Console.WriteLine("Your balance is not enough...");
                    }
                    break;

                case 2:
                    Console.Write("THE AMOUNT YOU WANT TO DEPOSIT : ");
                    tutar = Convert.ToInt32(Console.ReadLine());
                    money = money + tutar;
                    Console.WriteLine("Your deposit is complete. Your new balance : " + money);
                    break;

                case 3:
                    Console.WriteLine("Your balance : " + money);
                    break;

                case 4:
                    Console.WriteLine("PLEASE DO NOT FORGET YOUR CARD!");
                    break;

                default:
                    Console.WriteLine("This transaction is not available. Please try again...");
                    break;
            }
            Console.ReadLine();
        }
    }
}