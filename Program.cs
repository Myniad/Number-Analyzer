// See https://aka.ms/new-console-template for more information

internal class Program
{


    static void Main(string[] args)
    {
        Frontdoor();
    }

    public static void Frontdoor()
    {
        Console.WriteLine("Please enter your name: ");
        string inputName = Console.ReadLine().Trim();
        string name = inputName.Substring(0,1).ToUpper() + inputName.Substring(1);

        Console.WriteLine("Enter a positive number between 1 and 100: ");
        double inputNum = double.Parse(Console.ReadLine());
        double modNum = inputNum % 2;



        if (inputNum < 1 || inputNum > 100)
        {
            Console.WriteLine("That's an invalid number" +name+ ", please enter a number between 1 and 100");
        }
        
        if (inputNum < 60 && modNum == 1)
        {
            Console.WriteLine(name +", your value of "+ inputNum + " is odd and less than 60");
        }
        
        if (inputNum >= 2 && inputNum <= 25 && modNum == 0)
        {
            Console.WriteLine(name + ", your value of " + inputNum + " is even and less than 25");
       
        }
        if (inputNum >= 26 && inputNum <= 60 && modNum == 0)
        {
            Console.WriteLine(name + ", your value of " + inputNum + " is even and between 26 and 60 inclusive");
        }
        
        if (inputNum > 60 && modNum == 0)
        {
            Console.WriteLine(name + ", your value of " + inputNum + " is even and greater than 60");
        }
        
        if (inputNum > 60 && modNum == 1)
        {
            Console.WriteLine(name + ", your value of " + inputNum + " is odd and greater than 60");
        }


        Console.WriteLine("\nStart over? y/n");
        string doOver = Console.ReadLine().ToLower();
        if (doOver == "y")
        {
            Frontdoor();
        }
        else
        {
            Console.WriteLine("\nGoodbye");
        }
    }
}