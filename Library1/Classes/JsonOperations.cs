using Library1.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace Library1.Classes;
public class JsonOperations
{
    public static void SerializePerson1()
    {
        Person person = new()
        {
            Id = 1, 
            FirstName = "Jim", 
            LastName = "Smith", 
            BirthDate = new DateTime(1945,2,12), 
            Title = "Sir"
        };
        string output = JsonConvert.SerializeObject(person, Formatting.Indented);
    }
    public static void SerializePerson2()
    {

        Person person = new()
        {
            Id = 1, 
            FirstName = "Jim", 
            LastName = "Smith", 
            BirthDate = new DateTime(1945, 2, 12), 
            Title = "Sir"
        };
        person.BirthDate = DateTime.Now;

        string output = System.Text.Json.JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
    }
}
