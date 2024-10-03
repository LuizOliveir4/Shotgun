using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun.Classes
{
    public static class Game
    {
        public static bool CompairScenarios(Player player1, Player player2)
        {
            FileHandler fileHandler = new FileHandler();
            bool isWinner = false;

            if (player1.MoveCase == 1 && player2.MoveCase == player1.MoveCase)
            {
                fileHandler.PlaySoundEffect(1);
            }
            else if(player1.MoveCase == 2 && player2.MoveCase == player1.MoveCase)
            {
                fileHandler.PlaySoundEffect(2);
            }
            else if (player1.MoveCase == 3 && player2.MoveCase == player1.MoveCase)
            {
                fileHandler.PlaySoundEffect(3);
            }
            else if (player1.MoveCase == 4 && player2.MoveCase == player1.MoveCase)
            {
                fileHandler.PlaySoundEffect(4);
                MessageBox.Show("Russian roulette:\nThere is no Winner!");
                ResetPlayers();
            }
            else if ((player1.MoveCase == 1 && player2.MoveCase == 2) || (player1.MoveCase == 2 && player2.MoveCase == 1))
            {
                fileHandler.PlaySoundEffect(2);
            }
            else if ((player1.MoveCase == 1 && player2.MoveCase == 3) || (player1.MoveCase == 3 && player2.MoveCase == 1))
            {
                fileHandler.PlaySoundEffect(1);
            }
            else if (player1.MoveCase == 2 && player2.MoveCase == 3)
            {
                fileHandler.PlaySoundEffect(3);
                isWinner = true;
                player2.IsWinner = isWinner;
            }
            else if (player1.MoveCase == 3 && player2.MoveCase == 2)
            {
                fileHandler.PlaySoundEffect(3);
                isWinner = true;
                player1.IsWinner = isWinner;
            }
            else if(player1.MoveCase == 4 && player2.MoveCase < 4)
            {
                fileHandler.PlaySoundEffect(4);
                isWinner = true;
                player1.IsWinner = isWinner;
            }
            else if (player2.MoveCase == 4 && player1.MoveCase < 4)
            {
                fileHandler.PlaySoundEffect(4);
                isWinner = true;
                player2.IsWinner = isWinner;
            }
            return isWinner;
        }


        public static List<Player> ResetPlayers()
        {
            List<Player> Players = new List<Player>();
            Player player1 = new Player("Player 1", false, 1, 0, 0);
            Players.Add(player1);
            Player player2 = new Player("Player 2", false, 2, 0, 0);
            Players.Add(player2);

            return Players;
        }
    }
}
