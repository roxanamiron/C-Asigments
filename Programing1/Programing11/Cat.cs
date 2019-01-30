//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programing11
//{
//   public class Cat
//    {
//        //Fields
//        private string name;
//        private string color;


//        //Properties
//        public string Name
//        {
//            get { return this.name; }
//            set { this.name = value; }
//        }
//        public string Color
//        {
//            get { return this.color; }
//            set { this.color = value; }
//        }

//        //Default Construnctor
//        public Cat()
//        {
//            this.name = "unnamed";
//            this.color = "grey";
//        }
//        //Constructor with 2 parameters
//        public Cat(string name, string color)
//        {
//            this.name = name;
//            this.color = color;
//        }
//        //method
//        public void SayMiau()
//        {
//            Console.WriteLine("Cat {0} said Miauuuuuu!",name);
//        }
//        static void Main()
//        {
//            Cat firstCat = new Cat();
//            firstCat.Name = "Tomy";
//            firstCat.SayMiau();

//            Cat secondCat = new Cat("Sheba", "Brown");
//            secondCat.SayMiau();
//            Console.WriteLine("Cat {0} is {1}", secondCat.Name, secondCat.Color);

//            Cat myCat = new Cat();
//            myCat.Name = "Alfred";
//            Console.WriteLine("My cat name is {0}", myCat.Name);
//            myCat.SayMiau();


//            Cat cat1 = new Cat();
//            cat1.SayMiau();
//            Console.WriteLine("The color of cat {0} is {1}", cat1.Name, cat1.Color);

//            Cat cat2 = new Cat("Johny", "brown");
//            cat2.SayMiau();
//            Console.WriteLine("The color of cat {0} is {1}", cat2.Name, cat2.Color);
//        }
//    }
//}
