using Newtonsoft.Json;

namespace Application1;

internal partial class Program
{
    static void Main(string[] args)
    {
        P1 person1 = new();
        person1.BirthDate = DateTime.Now;
        
        P2 person2 = new();

        Console.ReadLine();
    }

    public static void SerializePerson1()
    {
        P2 person = new ()
        {
            FirstName = "Jim", 
            LastName = "Smith", 
            Id = 1, BirthDate = 
                new DateOnly(1978,1,2), 
            Title = "Sir"
        };
        string output = JsonConvert.SerializeObject(person, Formatting.Indented);
    }
}