using task5.Enums;

namespace task5
{
    public class TagFlyweight
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public TagType ClosingType { get; }

        public TagFlyweight(string tagName, DisplayType display, TagType closingType)
        {
            TagName = tagName;
            Display = display;
            ClosingType = closingType;
        }
    }
}
