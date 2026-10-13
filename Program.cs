class Program
{
    static void Main()
    {
        /*{
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 50) Console.WriteLine("Fail");
            else if (n >=50 && n < 60) Console.WriteLine('E');
            else if (n >=60 && n < 70) Console.WriteLine('D');
            else if (n >=70 && n < 80) Console.WriteLine('C');
            else if (n >=80 && n < 90) Console.WriteLine('B');
            else if (n >=90 && n < 100) Console.WriteLine('A');
            else Console.WriteLine('S');
        }

        {
            Console.WriteLine("Placement Eligible Criteria Check");
            Console.WriteLine("Enter Year of Study (1-4): ");
            String yearInput = Console.ReadLine().ToLower();
            if (yearInput == "4")
            {
                Console.WriteLine("Enter backlogs if any : ");
                int backlogsInput = Convert.ToInt32(Console.ReadLine());
                if (backlogsInput == 0)
                {

                    Console.WriteLine("Enter CGPA (0.0-10.0): ");
                    float cgpaInput = float.Parse(Console.ReadLine());
                    if (cgpaInput >= 8.5)
                    {
                        Console.Write("Placement Eligible");
                    }
                    else
                    {
                        Console.WriteLine("Placement Not Eligible");
                    }

                }
                else
                {
                    Console.WriteLine("Placement Not Eligible");
                }
            }

            else
            {
                Console.WriteLine("Placement Not Eligible");
            }
        }
    }


    // string name double amount 1st cond check acc name and pin 2nd cond check amount and balance
            

        /*    Fiboo:(
        Console.WriteLine("Loops in C#");
            long a = 0;
            long b = 1;
            Console.Write("Enter the number of terms : ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
            Console.WriteLine("Fibonacci number of " + i + " is : " + a);
            long c = a + b;
            a = b;
            b = c;
        } 
      )
    Fibooo using while:
        int a = 0;
        int b = 1;
        int count = 0;

        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fibonacci Series:");
        while (count < n)
        {
            Console.WriteLine(a);
            int c = a;
            a = b;
            b = c + b;
            count++;
        }

        Console.WriteLine();
        */

        int choice;
        do
        {

            Console.WriteLine("Simple Calculator Menu");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition selected");
                    Console.Write("Enter 1st numbers: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter 2nd numbers: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Result: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Subtraction selected");
                    Console.Write("Enter 1st numbers: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter 2nd numbers: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Result: " + (x - y));
                    break;
                case 3:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        } while (choice != 3);

    }
}