namespace GreetingApp.Models
{
    public class NameRepository
    {

        private static string? name;



        public void SaveName(string username)
        {
            name = username;
        }



        public string? GetName()
        {
            return name;
        }

    }
}