using System.Media;

namespace Shotgun.Classes
{
    public class Player : User
    {
        public bool IsWinner { get; set; }
        public int PlayerNumber { get; set; }
        public int BulletsCounter { get; set; }
        public int MoveCase { get; set; }

        public Player()
        {
            
        }

        public Player(string name, bool isWinner, int playerNumber, int bulletsCounter, int moveCase):base(name)
        {
            IsWinner = isWinner;
            PlayerNumber = playerNumber;
            BulletsCounter = bulletsCounter;
            MoveCase = moveCase;
        }

        public int SetMoveCase(int moveCase)
        {
            switch (moveCase)
            {
                case 1:
                    MoveCase = 1;
                    break;
                 
                case 2:
                    BulletsCounter++;
                    MoveCase = 2;
                    break;
                   
                case 3:
                    if (BulletsCounter > 0 && BulletsCounter < 3)
                    {
                        BulletsCounter--;
                        MoveCase = 3;
                    }
                    else if (BulletsCounter >= 3) //Användaren kan välja inte använda knappen "Shotgun"
                    {
                        BulletsCounter -=3; 
                        MoveCase = 4;
                    }
                    else
                    {
                        MessageBox.Show("You must reload before shooting.");
                        MoveCase = 1;
                    }
                    break;
            }
            return MoveCase;
        }
    }
}
