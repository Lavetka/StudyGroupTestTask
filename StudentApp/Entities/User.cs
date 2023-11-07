// Add this small model to unblock the build
namespace StudentApp.StudyGroupFeature.Entities
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; protected set; }

        private static int _lastAssignedId = 0;

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = ++_lastAssignedId;

        }
    }
}

