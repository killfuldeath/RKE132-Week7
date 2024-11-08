Console.WriteLine("ütle üks tehe (+ / -):");
char uoperator = Char.Parse(Console.ReadLine()); //väike teade, nimetades seda 'operator' paneb seda tervet koodi rikkuma


Console.WriteLine("ütle esimene number:");
int firstnum = Int32.Parse(Console.ReadLine());
Console.WriteLine("ütle teine number:");
int secondnum = Int32.Parse(Console.ReadLine());


switch (uoperator)
{
    case '+':
        liitmine(firstnum, secondnum);
        break;

    case '-':
        lahutamine(firstnum, secondnum);
        break;
        default:
        Console.WriteLine("palun proovi uuesti, või mitte, vahet ei tee");
        break;
}

static void liitmine(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}


static void lahutamine(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}