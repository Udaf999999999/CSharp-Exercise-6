namespace OOPConsoleApp
{
    class Human
    {
        // Поля класса
        public string name;
        public int age;

        // Метод класса
        public void Greetings()
        {
            Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
        }
    }

    struct Animal
    {
        // Поля структуры
        public string type;
        public string name;
        public int age;

        // Метод структуры
        public void Info()
        {
            Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
        }
    }
    class Pen
    {
        public string color;
        public int cost;
        public Pen()
        {
            color = "black";
            cost = 100;
        }
        public Pen(string color, int cost)
        {
            this.color = color;
            this.cost = cost;
        }
    }
    public class Rectangle
    {
        int a, b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Rectangle(int a)
        {
            this.a = a;
            b = a;
        }
        public Rectangle()
        {
            a = 6;
            b = 4;
        }
        public int Square() => a * b;
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen { color = "", cost = 30 };
            Console.WriteLine("Hello, World!");
        }
    }
}
