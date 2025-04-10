using task5.Enums;

namespace task5
{
    public class TagFlyweightFactory
    {
        private Dictionary<string, TagFlyweight> flyweights = new();

        public TagFlyweight GetFlyweight(string tagName, DisplayType display, TagType closingType)
        {
            string key = $"{tagName}_{display}_{closingType}";
            if (!flyweights.ContainsKey(key))
            {
                flyweights[key] = new TagFlyweight(tagName, display, closingType);
            }
            return flyweights[key];
        }

        public int Count => flyweights.Count;
    }
}
