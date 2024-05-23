
namespace JoesPizzaPlace.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{ CategoryId=1, CategoryName="Neapolitan", Description="Pizzas prepared with simple and fresh ingredients"},
            new Category{ CategoryId=2, CategoryName="BBQ", Description="Pizzas with barbecue sauce base"},
            new Category{ CategoryId=3, CategoryName="Seafood", Description="Pizzas with seafood toppings" },
            new Category{ CategoryId=4, CategoryName="Gourmet", Description="Pizza specialty"}
        };
    }
}
