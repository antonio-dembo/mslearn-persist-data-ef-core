namespace ContosoPizza.Data;

public static class Extensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        using var scope = host.Services.CreateScope();
        var Services = scope.ServiceProvider;
        var context = Services.GetRequiredService<PizzaContext>();
        context.Database.EnsureCreated();
        DbInitializer.Initialize(context);
    }
}