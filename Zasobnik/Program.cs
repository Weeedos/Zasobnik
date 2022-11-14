namespace Zasobnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zasobnik<int> zasobnik = new Zasobnik<int>();
            zasobnik.Push(1);
            zasobnik.Push(2);
            zasobnik.Push(3);
            zasobnik.Push(4);
            while (!zasobnik.IsEmpty)
            {
                Console.WriteLine(zasobnik.Pop());
            }
        }
    }
}