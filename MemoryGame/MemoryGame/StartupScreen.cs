using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class StartupScreen : Form
    {
        public StartupScreen()
        {
            InitializeComponent();

            HostGameButton.Click += new System.EventHandler(HostGameButton_Click);
            void HostGameButton_Click(object sender, EventArgs e)
            {
                //Opens the new window.
                Game gamePanel = new Game();
                gamePanel.Show();

                //Hides the startup window
                Hide();
            }
        }
    }
}
