using System;

namespace CreatingAndUsingObjects
{
    public class Cat
    {
        private string name;
        private string color;
               
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
     
        public Cat()
        {
            this.name = "unnamed";
            this.color = "grey";
        }
    
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
      
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said Miauuuuuu!", name);
        }

    }
}
