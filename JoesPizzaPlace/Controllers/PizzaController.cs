using JoesPizzaPlace.Models;
using JoesPizzaPlace.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JoesPizzaPlace.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository _pizzarepository;
        private readonly ICategoryRepository _categoryRepository;

        public PizzaController(IPizzaRepository pizzaRepository, 
            ICategoryRepository categoryRepository)
        {
            _pizzarepository = pizzaRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            PizzaListViewModel pizzaListViewModel = new PizzaListViewModel(_pizzarepository.MockPizzas,
                "Napoletana");

            return View(pizzaListViewModel);
        }

    }
}
