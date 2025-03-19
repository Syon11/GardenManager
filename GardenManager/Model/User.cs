using GardenManager.Utility;
using Newtonsoft.Json;

namespace GardenManager.Model;

public class User
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public List<Character> Characters { get; set; } = [];
    
    public User() {}

    public User(string Name, string Password, string Email)
    {
        Id = getNewID();
        this.Name = Name;
        this.Password = Cryptography.HashSHA256(Password);
        this.Email = Email;
    }

    public long getNewID()
    {
        string jsonString = File.ReadAllText("users.json");
        List<User>? tempUsers = JsonConvert.DeserializeObject<List<User>>(jsonString);
        return tempUsers.Count + 1;
    }
}