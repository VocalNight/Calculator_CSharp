using Calculator;

double num1 = 0;
double num2 = 0;

bool endApp = false;

Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("-----------------------\n");

while (!endApp) {

    string numInput1 = "";
    string numInput2 = "";
    double result = 0;



    Console.WriteLine("Type a number, and then press Enter");

    num1 = CheckValidity(Console.ReadLine());

    Console.WriteLine("Type another number and then press Enter");
    num2 = CheckValidity(Console.ReadLine());

    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine
    ($@"a - Add
s - Subtract
m - Multiply
d - Divide
Your option?");

    string op = Console.ReadLine();

    try {
        result = Calculator.Calculator.DoOperation(num1, num2, op);
        if (double.IsNaN(result)) {
            Console.WriteLine("This operation will result in error\n");
        } else {
            Console.WriteLine("Your result: {0:0.##}\n", result);
        }
    } catch (Exception ex) {
        Console.WriteLine("An error ocurred");
    }

    Console.WriteLine("--------------\n");

    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
    if (Console.ReadLine() == "n") endApp = true;

    Console.WriteLine("\n");
}
return;


double CheckValidity( string? v ) {

    while (!double.TryParse(v, out _)) {
        Console.WriteLine("Enter a valid number");
        v = Console.ReadLine();
    }

    return Convert.ToDouble(v);
}