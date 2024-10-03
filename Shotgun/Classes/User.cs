namespace Shotgun.Classes
{
    //Efterfrågas inte. Jag testar med att skapa en basklass
    public abstract class User
    {
        public string Name { get; set; }
        public int NumberOfWinnings { get; set; }
        public DateTime LastWinning { get; set; }

        public User()
        {
            
        }

        public User(string name)
        {
            Name = name;
        }


    }
}
