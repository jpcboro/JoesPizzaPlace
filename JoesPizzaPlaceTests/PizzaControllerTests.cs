using JoesPizzaPlace.Controllers;
using JoesPizzaPlace.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesPizzaPlaceTests
{
    public  class PizzaControllerTests
    {
        [Fact]
        public void List_ReturnsAnActionResult_WithAListOfPizzas()
        {
            //Arrange
            var mockPizzaRepo = new Mock<IPizzaRepository>();
            mockPizzaRepo.SetupGet(repo => repo.MockPizzas).Returns(GetMockPizzas());
            var mockCategoryRepo = new Mock<ICategoryRepository>();
            var pizzaController = new PizzaController(mockPizzaRepo.Object, mockCategoryRepo.Object);

            //Act
            var result = pizzaController.List();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Pizza>>(viewResult.ViewData.Model);

            Assert.NotNull(model);
            Assert.Equal(4, model.Count());

        }

        private IEnumerable<Pizza> GetMockPizzas()
        {
            return  new List<Pizza>
            {
                new Pizza {PizzaId = 1, Name="Pizza Supreme", Price=15.95M, ShortDescription="Supreme pizza", LongDescription="This mouthwatering masterpiece is generously topped with a savory blend of classic ingredients, creating a symphony of flavors that will tantalize your taste buds. Picture a perfectly baked crust, smothered in rich tomato sauce and piled high with a medley of toppings. From succulent pepperoni to tender mushrooms, crisp bell peppers, zesty onions, and savory Italian sausage, every bite is a celebration of culinary delight. Finished with a blanket of gooey mozzarella cheese and a sprinkle of aromatic herbs, our Pizza Supreme is the pinnacle of pizza perfection", Category = GetMockCategories().ToList()[3],ImageUrl="https://images.unsplash.com/photo-1681567604770-0dc826c870ae?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1OTk2MzR8MHwxfGFsbHx8fHx8fHx8fDE3MTYyNzY5NzN8&ixlib=rb-4.0.3&q=80&w=1080", InStock=true, IsPizzaOfTheWeek=false, ImageThumbnailUrl="https://images.unsplash.com/photo-1681567604770-0dc826c870ae?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1OTk2MzR8MHwxfGFsbHx8fHx8fHx8fDE3MTYyNzY5NzN8&ixlib=rb-4.0.3&q=80&w=200"},
                new Pizza {PizzaId = 2, Name="Pizza Margherita", Price=18.95M, ShortDescription="Margherita pizza", LongDescription="Our Pizza Margherita is adorned with vibrant San Marzano tomato sauce, imported directly from the volcanic soils of Campania, lending a rich and tangy flavor that harmonizes with every bite. Delicately layered with fresh mozzarella cheese, sourced from the finest buffalo milk, and topped with fragrant basil leaves, this pizza embodies the colors of the Italian flag – red, white, and green. Each slice is a celebration of tradition and authenticity, offering a symphony of flavors that transport you to the sun-drenched streets of Naples", Category = GetMockCategories().ToList()[0],ImageUrl="https://images.unsplash.com/photo-1555072956-7758afb20e8f?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1OTk2MzR8MHwxfGFsbHx8fHx8fHx8fDE3MTYyNzcxMTB8&ixlib=rb-4.0.3&q=80&w=1080", InStock=true, IsPizzaOfTheWeek=false, ImageThumbnailUrl="https://images.unsplash.com/photo-1555072956-7758afb20e8f?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1OTk2MzR8MHwxfGFsbHx8fHx8fHx8fDE3MTYyNzcxMTB8&ixlib=rb-4.0.3&q=80&w=200"},
                new Pizza {PizzaId = 3, Name="Smokey Barbecue Chicken Pizza", Price=15.95M, ShortDescription="BBQ Chicken pizza with bacon", LongDescription=" Our Smokey Barbecue Pizza is generously slathered with a tangy barbecue sauce, its smoky sweetness balanced with a subtle kick of spice, ensuring each bite is a harmonious blend of flavors. Layered atop this savory canvas is a symphony of ingredients: tender grilled chicken, crispy bacon, caramelized onions, and juicy pineapple, each adding its own dimension of taste and texture. Finished with a blanket of melted mozzarella cheese and a sprinkle of fresh cilantro, our Smokey Barbecue Pizza is a culinary masterpiece that promises to satisfy even the most discerning palate", Category = GetMockCategories().ToList()[1],ImageUrl="https://images.unsplash.com/photo-1592977731761-2d58aafef572?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1OTk2MzR8MHwxfGFsbHx8fHx8fHx8fDE3MTYyNzQ0NDF8&ixlib=rb-4.0.3&q=80&w=1080", InStock=true, IsPizzaOfTheWeek=true, ImageThumbnailUrl="https://images.unsplash.com/photo-1592977731761-2d58aafef572?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1OTk2MzR8MHwxfGFsbHx8fHx8fHx8fDE3MTYyNzQ0NDF8&ixlib=rb-4.0.3&q=80&w=200"},
                new Pizza {PizzaId = 4, Name="Char Grilled Seafood Pizza", Price=12.95M, ShortDescription="Seafood pizza", LongDescription="Our Char-Grilled Seafood Pizza features a delectable medley of fresh seafood, including succulent shrimp, tender calamari rings, and plump scallops, each charred to perfection to unlock their natural sweetness and briny essence. Complementing the seafood symphony is a luscious blend of roasted garlic aioli, adding a creamy richness and subtle garlic aroma that enhances every bite. Topped with a scattering of sun-dried tomatoes, earthy olives, and fragrant basil leaves, this pizza is a harmony of flavors that transports you to the sun-drenched shores of the Mediterranean", Category = GetMockCategories().ToList()[2],ImageUrl="https://images.unsplash.com/photo-1652952561151-97e82f26c336?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1OTk2MzR8MHwxfGFsbHx8fHx8fHx8fDE3MTYyNzcyNTR8&ixlib=rb-4.0.3&q=80&w=1080", InStock=true, IsPizzaOfTheWeek=true, ImageThumbnailUrl="https://images.unsplash.com/photo-1652952561151-97e82f26c336?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=M3w1OTk2MzR8MHwxfGFsbHx8fHx8fHx8fDE3MTYyNzcyNTR8&ixlib=rb-4.0.3&q=80&w=200"}
             };

        }

        private IEnumerable<Category> GetMockCategories()
        {
            return new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="Neapolitan", Description="Pizzas prepared with simple and fresh ingredients"},
                new Category{ CategoryId=2, CategoryName="BBQ", Description="Pizzas with barbecue sauce base"},
                new Category{ CategoryId=3, CategoryName="Seafood", Description="Pizzas with seafood toppings" },
                new Category{ CategoryId=4, CategoryName="Gourmet", Description="Pizza specialty"}
             };
        }
}
}
