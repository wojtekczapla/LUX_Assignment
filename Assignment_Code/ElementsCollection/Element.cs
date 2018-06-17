namespace Assignment.ElementsCollection
{
    using Assignment.ElementsCollection.Interfaces;
    using System;

    public class Element : IElement
    {
        private int num;
        private String name;
        private int age;

        public int Num => num;
        public string Name => name;
        public int Age => age;

        public void InitElement(int num, string name, int age)
        {
            this.num = num;
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format($"{this.Name}, {this.Age}, {this.Num}");
        }
    }
}