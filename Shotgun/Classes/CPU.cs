namespace Shotgun.Classes
{
    public static class CPU
    {
        public static int BotPlay(Player player)
        {
            if (player.BulletsCounter == 0)
            {
                return player.MoveCase = 2;
            }
            else if (player.BulletsCounter >= 3) //Datorn ska alltid använda "Shotgun" så snart som möjligt!
            {
                player.BulletsCounter -= 3;
                return player.MoveCase = 4;
            }
            else
            {
                Random rnd = new Random();
                int moveCase = rnd.Next(1, 4);   // creates a number between 1 and 3
                return player.MoveCase = moveCase;
            }
        }
    }
}
