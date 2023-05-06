using DK.FoodBackend.Domain.Entity;

namespace DK.FoodBackend.Domain.UseCases;

public interface IThingRepository
{
    IList<Thing> GetThings();
    void AddThing(Thing thing);
    Thing? FindThingById(Guid id);
}