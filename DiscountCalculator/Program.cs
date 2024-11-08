
Console.WriteLine("Provide total:");
int userinput = Int32.Parse(Console.ReadLine());

double discount = discountbelike(userinput);


Console.WriteLine($"Your discount is {discount}%");


double newtotal = calcnewtotal(userinput, discount); //userinput - (userinput * discount) / 100;



Console.WriteLine($"Your updated total with the {discount}% discount is {newtotal}");
static double discountbelike(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10; 
    }

}

static double calcnewtotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}