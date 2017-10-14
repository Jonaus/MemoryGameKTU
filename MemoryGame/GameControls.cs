﻿using MemoryGame.Properties;
using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public static class GameControls
    {
        public static void RestartButton_Click(object sender, EventArgs e)
        {
            // TODO: implement
            GameMenu.RestartStopwatch();
        }

        public static void CardButton_Click(object sender, EventArgs e)
        {
            // TODO: implement
            Button cardButton = sender as Button;
            if (cardButton != null)
            {
                cardButton.BackgroundImage = Resources.ace_of_diamonds;
            }
        }
    }
}