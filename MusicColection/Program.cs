

using MusicCollection;

Console.WriteLine("****Hi! Welcome to your private Music Collection****");
Console.WriteLine("You can put your Cds, Vinyls, Video Tapes or Cassette Tapes right here");
Console.WriteLine("What do you want to do?:");
Console.WriteLine("------------------------------------");
Console.WriteLine("1.Add something to collection");
Console.WriteLine("2.Remove from collection");
Console.WriteLine("3.Browse your collection");
Console.WriteLine("Press 1, 2, 3 ...");

int choice=int.Parse(Console.ReadLine());

if (choice > 3)
{
    Console.WriteLine("Enter the corect value");
}
else
{
    Console.WriteLine($"You have chosen option {choice}");
}

Console.WriteLine("Select a category");
Console.WriteLine("1.Cds");
Console.WriteLine("2.Vinyls");
Console.WriteLine("3.Video Tapes");
Console.WriteLine("4.DVD");
Console.WriteLine("5.Cassette Tapes");

int Id = int.Parse(Console.ReadLine());

if (Id == 1)
{
    Console.WriteLine("Category: Cds");
}
if (Id == 2)
{
    Console.WriteLine("Category: Vinyls");
}
if (Id == 3)
{
    Console.WriteLine("Category: Video Tapes");
}
if (Id == 4)
{
    Console.WriteLine("Category: DVD");
}
if (Id == 5)
{
    Console.WriteLine("Category: Cassette Tapes");
}

List<String> items = new List<String>();
items.Add("Agnostic Front");
items.Add("AC/DC");
items.Add("Metallica");
items.Add("Iron Maiden");
Console.WriteLine("-------------------------------------");
Console.WriteLine("---This is your all collection:---");
Console.WriteLine(items[0]);
Console.WriteLine(items[1]);
Console.WriteLine(items[2]);
Console.WriteLine(items[3]);



