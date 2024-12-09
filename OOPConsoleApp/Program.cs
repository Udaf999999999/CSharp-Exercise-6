using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
    
    public class Shape
    {
        float[] sides;
        public float GetSquare()
        {
            return sides[0];
        }
        public float GetPerimeter()
        {
            return sides[0];
        }
    }
    public class Tryange: Shape
    {

    }
    public class Rectangle : Shape
    {

    }
    public class Circle : Shape
    {

    }
    public class TrafficLight
    {
        private void ChangeColor(string color)
        {

        }
        public string GetColor()
        {
            return null;
        }
    }
    class User
    {
        private int age;
        private string login;
        private string mail;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Name's length shorter 3!");
                }
                else
                {
                    login = value;
                }
            }
        }
        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                if (value.Contains('@'))
                {
                    mail = value;
                }
                else
                {
                    Console.WriteLine("Email must contain @");
                }

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Merry Christmas");
        }
    }
}
