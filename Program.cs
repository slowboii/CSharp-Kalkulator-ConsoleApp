class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Calculator!");
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Choose an operation (+, -, *, /):");
        string operation = Console.ReadLine();
        double result = 0;
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Error: Division by zero is not allowed.");
                break;
            default:
                Console.WriteLine("Error: Invalid operation.");
                break;
        }
        if (operation == "+" || operation == "-" || operation == "*" || (operation == "/" && num2 != 0))
            Console.WriteLine($"The result is: {result}");
    }
}