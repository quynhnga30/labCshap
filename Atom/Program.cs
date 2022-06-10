using lab341;

class program
{
    static void Main(string[] args)
    {
        Atom at1 = new Atom();
        Console.WriteLine("Atomic information ");
        Console.WriteLine("===============================");
        Console.WriteLine("Enter atomic FullName:  ");
        at1.atomfn = Console.ReadLine();
        Console.WriteLine("Enter atomic Symbol :  ");
        at1.atomsb = Console.ReadLine();
        Console.WriteLine("Enter tomic Number:  ");
        at1.atomnb = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter tomic Weight:  ");
        at1.atomw = float.Parse(Console.ReadLine());

        Console.WriteLine("----------------------------------  ");
        at1.display();
        Console.ReadLine();



    }
}
