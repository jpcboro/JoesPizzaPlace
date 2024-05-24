using JoesPizzaPlace.Models;

namespace JoesPizzaPlace.ViewModels
{
    public class PizzaListViewModel
    {
        public IEnumerable<Pizza> Pizzas { get; set; }
        public string? CurrentCategory { get; set; }
        public PizzaListViewModel(IEnumerable<Pizza> pizzas, string? currentCategory)
        {
            Pizzas = pizzas;
            CurrentCategory = currentCategory;
        }
    }
}
