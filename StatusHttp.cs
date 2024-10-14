using System.ComponentModel;

namespace API_StatusHttp
{
    public class StatusHttp
    {
        public int Status { get; set; }
        public string? Response { get; set; }
        public string? Description { get; set; }
    }

    public static class Extension
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                return attribute.Description;
            }
            throw new ArgumentException("Item not found.", nameof(enumValue));
        }
    }
}
