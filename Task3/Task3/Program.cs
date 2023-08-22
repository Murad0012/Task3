namespace Task3
{
    public class RussianPerson : IPerson
    {
        public void Speak()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Привет");
        }
    }
    public class FrenchPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("Bonjour");
        }
    }
    public class SpanishPerson : IPerson
    {
        public void Speak()
        {
            Console.WriteLine("Hola");
        }
    }
    public interface IPerson
    {
        public void Speak();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SpanishPerson pr = new SpanishPerson();
            pr.Speak();
            FrenchPerson pr1 = new FrenchPerson();
            pr1.Speak();
            RussianPerson pr2 = new RussianPerson();
            pr2.Speak();
        }
    }
}