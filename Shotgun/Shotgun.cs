using Shotgun.Classes;
using System.Media;

namespace Shotgun
{
    public partial class Shotgun : Form
    {   private Player player1 = new Player();
        private Player player2 = new Player();
        private FileHandler fileHandler = new FileHandler();

        public Shotgun()
        {
            InitializeComponent();
            LoadMedia();

        }

        private void btnMoveCase1_Click(object sender, EventArgs e)
        {
            LoadMedia(player1.PlayerNumber, player1.SetMoveCase(1));
            LoadMedia(player2.PlayerNumber, player2.SetMoveCase(CPU.BotPlay(player2)));
            IsWinner(Game.CompairScenarios(player1,player2));
        }

        private void btnMoveCase2_Click(object sender, EventArgs e)
        {
            LoadMedia(player1.PlayerNumber, player1.SetMoveCase(2));
            ShowShotgun(player1);
            LoadMedia(player2.PlayerNumber, player2.SetMoveCase(CPU.BotPlay(player2)));
            IsWinner(Game.CompairScenarios(player1, player2));

        }

        private void btnMoveCase3_Click(object sender, EventArgs e)
        {
            LoadMedia(player1.PlayerNumber, player1.SetMoveCase(3));
            ShowShotgun(player1);
            LoadMedia(player2.PlayerNumber, player2.SetMoveCase(CPU.BotPlay(player2)));
            IsWinner(Game.CompairScenarios(player1, player2));
        }


        public void LoadMedia()
        {
            Reset();
            lblPlayer1_Name.Text = player1.Name;
            lblPlayer2_Name.Text = player2.Name;
            lblPlayer1_Bullets.Text = "Ammunition " + player1.BulletsCounter.ToString();
            lblPlayer2_Bullets.Text = "Ammunition " + player2.BulletsCounter.ToString();
            imgLeftMoveCase.ImageLocation = fileHandler.PathLeftImage(0);
            imgRightMoveCase.ImageLocation = fileHandler.PathRightImage(0);
            fileHandler.PlaySoundEffect(0);
            //Nu har jag gjort en ändring som jag vill pusha till servern!
        }

        public void LoadMedia(int playerNumber, int moveCase)
        {
            switch (playerNumber)
            {
                case 1:
                    lblPlayer1_Bullets.Text = "Ammunition " + player1.BulletsCounter.ToString();
                    imgLeftMoveCase.ImageLocation = fileHandler.PathLeftImage(moveCase);
                    break;

                case 2:
                    lblPlayer2_Bullets.Text = "Ammunition " + player2.BulletsCounter.ToString();
                    imgRightMoveCase.ImageLocation = fileHandler.PathRightImage(moveCase);
                    break;
            }
        }

        public void ShowShotgun(Player player)
        {
            if (player.BulletsCounter > 2)
            {
                btnMoveCase3.Text = "Shotgun";
            }
            else
            {
                btnMoveCase3.Text = "Shoot";
            }
        }

        public void Reset()
        {
           List<Player> Players = Game.ResetPlayers();
            player1 = Players[0];
            player2 = Players[1];
        }

        public void IsWinner(bool isWinner)
        {
            if (player1.IsWinner)
            {
                MessageBox.Show("YOU WIN!");
                LoadMedia();
            }
            else if (player2.IsWinner)
            {
                MessageBox.Show("COMPUTER WINS!");
                LoadMedia();
            }
        }
    }
}
