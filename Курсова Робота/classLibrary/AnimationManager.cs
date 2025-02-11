using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_Робота.classLibrary
{
    public class AnimationManager
    {
        private PictureBox Road, Road2, Opponent1, Opponent2, Coin;

        public AnimationManager(PictureBox road, PictureBox road2, PictureBox opponent1, PictureBox opponent2, PictureBox coin)
        {
            Road = road;
            Road2 = road2;
            Opponent1 = opponent1;
            Opponent2 = opponent2;
            Coin = coin;
        }

        public void Update()
        {
            int speed = 10;
            Road.Top += speed;
            Road2.Top += speed;
            Opponent1.Top += 7;
            Opponent2.Top += 7;
            Coin.Top += 7;
            ResetPositions();
        }

        public void ResetPositions()
        {
            if (Road.Top >= 650)
            {
                Road.Top = 0;
                Road2.Top = -650;
            }
            if (Opponent1.Top >= 650)
                Opponent1.Top = -130;
            if (Opponent2.Top >= 650)
                Opponent2.Top = -400;
            if (Coin.Top >= 650)
                ResetCoinPosition();
        }

        public void ResetCoinPosition()
        {
            Coin.Top = -50;
            Coin.Left = new Random().Next(150, 560);
        }
    }
}
