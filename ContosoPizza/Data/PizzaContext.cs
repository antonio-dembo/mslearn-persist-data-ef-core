using Microsoft.EntityFrameworkCore;
using ContosoPizza.Models;

namespace ContosoPizza.Data;

class PizzaContext : DbContext
{
    public PizzaContext(DbContextOptions<PizzaContext> options)
        : base(options)
    {
    }

    public DbSet<Pizza> Pizzas => Set<Pizza>();
    public DbSet<Topping> Topping => Set<Topping>();
    public DbSet<Sauce> Sauce => Set<Sauce>();
}