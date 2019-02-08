using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programing14
{
   public class Exemples
    {
        int myValue = 3;
        private int size;
        static int exCount;
        public int Size
        { get { return size; } }
       

        public double X { get; set; }
        public double Y { get; set; }
        public Exemples(int x, int y)
        {
            this.X = x;
            this.Y = y;

            Exemples.exCount += 1;
        }
        
        void PrintValue()
        {
            Console.WriteLine("my value is : " + myValue);
        }

        //static void Main()
        //{
        //    Exemples instance = new Exemples(2,3);
        //    instance.PrintValue();
        //    Console.WriteLine("Collar size is : " + instance.Size);
        //    Console.WriteLine("the X coordonate is: " + instance.X);
        //    Console.WriteLine("the Y coordonate is : " + instance.Y);
        //    Console.WriteLine("dog count is :" +Exemples.exCount);

        //    Exemples ex1 = new Exemples(4, 5);
        //    Exemples ex2 = new Exemples(17, 55);
        //    Exemples ex3 = new Exemples(46, 25);
        //    Console.WriteLine("the new variable is now: "+Exemples.exCount);

           
        //    Console.ReadLine();
        //}
    }
    public class Coffee
    {
        public CoffeSize size;
        public Coffee(CoffeSize size)
        {
            this.size = size;
        }
        public CoffeSize Size
        {
            get { return size; }
        }

        
    }
    public class CoffeSize
    {
       public enum CoffeeSize
        {
            Small=100, Normal=150, Double=300
        }
        
    }
    public class OuterClass
    {
        private string name;
        private OuterClass(string name)
        {
            this.name = name;
        }

        private class NestedClass
        {
            private string name;
            private OuterClass parent;
            public NestedClass(OuterClass parent, string name)
            {
                this.parent = parent;
                this.name = name;
            }
            public void PrintNames()
            {
                Console.WriteLine("Nested name: " + this.name);
                Console.WriteLine("Outer name: " + this.parent.name);
            }
        }

        //static void Main()
        //{
        //    OuterClass outerClass = new OuterClass("outer");
        //    NestedClass nestedClass = new NestedClass(outerClass, "nested");
        //    nestedClass.PrintNames();

        //    Console.ReadLine();
        //}
    }

    public class Car
    {
        Door FrontRightDoor;
        Door FrontLeftDorr;
        Door RearRightDoor;
        Door RearLeftDoor;
        Engine engine;

        public Car()
        {
            engine = new Engine();
            engine.horsePower = 2000;
        }
        public class Engine
        {
            public int horsePower;
        }
    }
    public class Door
    {

    }
    public class Dog
    {

    }
    public class Cat
    {

    }
    public class AnimalShelter<T>
    {
        private const int DefaultPlacesCount = 20;

        private T[] animalList;
        private int usedPlaces;
        public AnimalShelter() : this(DefaultPlacesCount)
        {

        }
        public AnimalShelter(int placeCount)
        {
            this.animalList = new T[placeCount];
            this.usedPlaces = 0;
        }

        public void Shelter(T newAnimal)
        {
            if(this.usedPlaces >= this.animalList.Length)
            {
                throw new InvalidOperationException("shelter is full");
            }
            this.animalList[this.usedPlaces] = newAnimal;
            this.usedPlaces++;
        }
        public T Release(int index)
        {
            if(index < 0 || index >= this.usedPlaces)
            {
                throw new ArgumentOutOfRangeException("invalid cell index" + index);
            }
            T releasedAnimal = this.animalList[index];
            for(int i = 0; i < this.usedPlaces -1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }
            this.animalList[this.usedPlaces - 1] = default(T);
            this.usedPlaces--;

            return releasedAnimal;
        }
       //static void Main()
       // {

       //     AnimalShelter<Dog> dogsShelter = new AnimalShelter<Dog>(10);
       //     Dog dog1 = new Dog();
       //     Dog dog2 = new Dog();
       //     Dog dog3 = new Dog();

       //     dogsShelter.Shelter(dog1);
       //     dogsShelter.Shelter(dog2);
       //     dogsShelter.Shelter(dog3);

       //     dogsShelter.Release(1);
       //     Console.WriteLine(dogsShelter);

       //     AnimalShelter<Cat> dogsShelter2 = new AnimalShelter<Cat>(10);
       //     Cat cat1 = new Cat();

       //     dogsShelter2.Shelter(cat1);
       //     Console.WriteLine("cat", dogsShelter2);
       //     Console.ReadLine();
       // }
    }

}
