namespace Airplane
{
    public class CrewMember
    {
        public string Name { get; private set; }
        public string Role { get; private set; }

       public CrewMember(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}