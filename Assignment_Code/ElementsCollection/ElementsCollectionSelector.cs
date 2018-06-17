namespace Assignment.ElementsCollection
{
    using Assignment.ElementsCollection.Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    public class ElementsCollectionSelector
    {
        public static ICollection<IElement> GetElementsUniqueByNumAndAgeMoreThanTwenty(ICollection<IElement> elements)
        {
            return elements?.Where(el => el.Age > 20).GroupBy(el => el.Num).Select(el => el.First()).ToList();
        }
    }
}
