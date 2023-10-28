namespace Labb7OopPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // för att tecken i utskrift ska synas

            //hämta instans/objekt rektangel, via Geometri, kan även skriva
            Geometri rektangel = new Rektangel();  // kan även skriva: Rektangel rektangel = new Rektangel();
            double rektangelArea = rektangel.Area(); //hämta metoden area
            Console.WriteLine("Arean av din ▲ är: " + rektangelArea + " cm2"); // skriver ut metoden area för rektangel

            Geometri fyrkant = new Fyrkant();
            double FyrkantArea = fyrkant.Area();
            Console.WriteLine("Arean av din □ är: " + FyrkantArea + " cm2");

            Geometri cirkel = new Cirkel();
            double CirkelArea = cirkel.Area();
            Console.WriteLine("Arean av din ◙ är: " + CirkelArea + " cm2");

            Geometri parallellogram = new Parallellogram();
            double ParallellogramArea = parallellogram.Area();
            Console.WriteLine("Arean av ditt Parallellogram är: " + ParallellogramArea + " cm2");

            Geometri ellips = new Ellips();
            double EllipsArea = ellips.Area();
            Console.WriteLine("Arean av din Ellips är: " + EllipsArea + " cm2");

        }
    }
}