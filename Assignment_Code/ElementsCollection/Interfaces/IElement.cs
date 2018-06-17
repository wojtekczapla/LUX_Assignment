namespace Assignment.ElementsCollection.Interfaces
{
    using System;

    public interface IElement
    {
        int Num { get; }
        String Name { get; }
        int Age { get; }

        void InitElement(int num, string name, int age);
    }
}