namespace JoesPizzaPlace.Models
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> MockPizzas { get; }
        IEnumerable<Pizza> PizzasOfTheWeek { get; }
        Pizza? GetPizzaById(int pizzaId);
    }
}
