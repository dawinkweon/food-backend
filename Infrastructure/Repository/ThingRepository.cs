using DK.FoodBackend.Domain.Entity;
using DK.FoodBackend.Domain.UseCases;

namespace DK.FoodBackend.Infrastructure.Repository;

public class ThingRepository : IThingRepository
{
    private static readonly List<Thing> things = new();

    static ThingRepository()
    {
        Initialize();
    }

    private static void Initialize()
    {
        Thing thing = new ()
        {
            Id = Guid.NewGuid(),
            Base64Img = "",
            Name = "thing1",
            Tags = new ()
            {
                new Tag() { Value = "tag1" }
            }
        };
        things.Add(thing);
    }

    public IList<Thing> GetThings()
    {
        return things;
    }

    public void AddThing(Thing thing)
    {
        things.Add(thing);
    }

    public Thing? FindThingById(Guid id)
    {
        return things.Find(t => t.Id == id);  
    }
}