using DK.FoodBackend.Domain.Entity;
using DK.FoodBackend.Domain.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace DK.FoodBackend.V1.Controllers;

[ApiController]
[Route("api/v1/thing")]
public class ThingController : ControllerBase
{
    
    private readonly ILogger<ThingController> logger;
    private readonly ThingUseCases thingUseCases;

    public ThingController(ILogger<ThingController> logger, ThingUseCases thingUseCases) =>
        (this.logger, this.thingUseCases) = (logger, thingUseCases);
    

    [HttpGet]
    public IList<Thing> List()
    {
        return thingUseCases.GetThings();
    }

    [HttpPost]
    public Thing Create(Thing thing)
    {
        return thingUseCases.CreateThing(thing);
    }
    
    [HttpGet("{id}")]
    public Thing? GetThingById(string id)
    {
        return thingUseCases.FindThingById(id);
    }
}
