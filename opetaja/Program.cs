Console.WriteLine("Enter the operation (C for Fahrenheit to Celcius, F for Celsius to Fahrenheit):");
char userChoice = Char.Parse(Console.ReadLine().ToUpper());

Console.WriteLine("Enter the temperature value:");
double temp = double.Parse(Console.ReadLine());

switch (userChoice)
{
    case 'C':
        ConvertToCelsius(temp);
        break;
    case 'F':
        ConvertToFahrenheit(temp);
        break;
    default:
        Console.WriteLine("Wrong choice. Use 'C' or 'F'.");
        break;
}


static void ConvertToCelsius(double fahrenheit)
{
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"{fahrenheit}°F is {celsius}°C");
}

static void ConvertToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9) / 5 + 32;
    Console.WriteLine($"{celsius}°C is {fahrenheit}°F");
}