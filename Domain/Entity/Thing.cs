namespace DK.FoodBackend.Domain.Entity;

public class Thing
{
    public Guid Id { get; set; }
    public string Base64Img { get; set; }
    
    public string Name { get; set; }
    
    public List<Tag> Tags { get; set; }
}