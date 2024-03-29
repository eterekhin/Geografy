using Geograf_y.Entities.Base;

namespace Geograf_y.Entities
{
    public class People : ICanInsert
    {
        public People(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string InsertCommand() => InsertString();
        public static string ClearAll() => "delete from peoples";
        public int Id;
        public string Name;

        public string InsertString()
        {
            return $"INSERT INTO Peoples (Id,Name) VALUES({Id},'{Name}')";
        }
    }
}