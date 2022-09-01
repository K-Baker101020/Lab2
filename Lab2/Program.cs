public class Program {
    public static void Main(string[] args) {
        //See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World");

        //#2 Take a user’s input number and input its multiplication table. The user can choose how high to multiply by.
        int num1;

        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        

        Console.WriteLine($"{num1} * {0} = , {num1} * {1} = ");

    
    }

}
