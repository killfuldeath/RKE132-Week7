Console.WriteLine("Come or leave? (come/leave)");

string ok = Console.ReadLine();

if(ok == "come")
{
    printhello();
}
else
{
    alligator();
}



static void printhello()
{
    Console.WriteLine("hello word!");
}

printhello();

static void alligator()
{
    Console.WriteLine("imagine saying alligator when you also say goodbye");
}

alligator();