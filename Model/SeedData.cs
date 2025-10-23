namespace BlazingPizza;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial()
            {
                Id= 1,
                Name = "Creamy 2-N-1",
                Description = "PIZZA MITAD PEPPERONI MITAD JAMÓN Y CHAMPIÑONES CON BASE CREMOSA DE AJO ROSTIZADO",
                BasePrice = 29.90M,
                ImageUrl = "img/pizzas/1.jpg",
            },
            new PizzaSpecial()
            {
                Id = 2,
                Name = "Familiar Ultimate Supreme",
                Description = "PEPPERONI, SALCHICHA ITALIANA, CHAMPIÑONES, CEBOLLA Y PIMENTÓN VERDE",
                BasePrice = 32.90M,
                ImageUrl = "img/pizzas/2.jpg",
            },
            new PizzaSpecial()
            {
                Id = 3,
                Name = "Familiar Pepperoni",
                Description = "PEPPERONI",
                BasePrice = 32.90M,
                ImageUrl = "img/pizzas/3.jpg",
            },
            new PizzaSpecial()
            {
                Id = 4,
                Name = "SUPER CHEESE",
                Description = "PEPPERONI CON ORILLA RELLENA DE QUESO, MANTEQUILLA DE AJO Y PARMESANO",
                BasePrice = 29.80M,
                ImageUrl = "img/pizzas/4.jpg",
            },
            new PizzaSpecial()
            {
                Id = 5,
                Name = "Familiar Vegetariana",
                Description = "CEBOLLA, CHAMPIÑONES, ACEITUNAS Y PIMENTÓN VERDE",
                BasePrice = 32.90M,
                ImageUrl = "img/pizzas/5.jpg",
            },
            new PizzaSpecial()
            {
                Id = 6,
                Name = "Familiar 3 Meat Treat",
                Description = "PEPPERONI, SALCHICHA ITALIANA Y TOCINO",
                BasePrice = 32.90M,
                ImageUrl = "img/pizzas/6.jpg",
            },
            new PizzaSpecial()
            {
                Id = 7,
                Name = "CRAZY POPS",
                Description = "4 DELICIOSAS PORCIONES RELLENAS DE PEPPERONI Y QUESO",
                BasePrice = 9.90m,
                ImageUrl = "img/pizzas/7.jpg",
            },
        };
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}
