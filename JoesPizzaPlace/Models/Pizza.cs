namespace JoesPizzaPlace.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Name { get; set; } = string.Empty;

        public string[] Toppings { get; set; }

        public SizeType Sizes { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsPizzaOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;




    }
}
