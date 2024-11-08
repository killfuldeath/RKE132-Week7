
Console.WriteLine("sõna, nüüd.");
string sona = Console.ReadLine();

static void lots(string anyString)
{
    anyString = anyString.ToUpper();

    for (int i = 0; i < 5 ; i++)
    {
        Console.WriteLine(anyString);
    }
}


//btw ma tean et ma saan ka need kutsumised teha funktsioonile seal üleval poolel, aga ei taha

lots(sona);