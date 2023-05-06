using DK.FoodBackend.Domain.Entity;

namespace DK.FoodBackend.Domain.UseCases;

public class ThingUseCases
{
    private readonly IServiceScopeFactory scopeFactory;

    public ThingUseCases(IServiceScopeFactory scopeFactory)
    {
        this.scopeFactory = scopeFactory;
    }

    public IList<Thing> GetThings()
    {
        IThingRepository repository = GetRepository();
        return repository.GetThings();
    }

    public Thing CreateThing(Thing thing)
    {
        thing.Id = Guid.NewGuid();
        
        GetRepository().AddThing(thing);
        return thing;
    }

    public Thing? FindThingById(string id)
    {
        return GetRepository().FindThingById(Guid.Parse(id));
    }
    
    private IThingRepository GetRepository()
    {
        return scopeFactory.CreateScope().ServiceProvider.GetService<IThingRepository>();
    }
}