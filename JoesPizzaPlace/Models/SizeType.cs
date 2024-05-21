using System.ComponentModel;

namespace JoesPizzaPlace.Models
{
    public enum SizeType
    {
        [Description("6 slices - 8 inches")]
        Small = 1,
        [Description("8 slices - 12 inches")]
        Medium = 2,
        [Description("12 slices - 18 inches")]
        Large = 3
    }
}
