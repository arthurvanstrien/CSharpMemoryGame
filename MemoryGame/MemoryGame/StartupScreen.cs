using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class StartupScreen : Form
    {
        public StartupScreen()
        {
            InitializeComponent();

            //This button handles the start of a game that players can join.
            HostGameButton.Click += new EventHandler(HostGameButton_Click);
            void HostGameButton_Click(object sender, EventArgs e)
            {
                //Opens the new window.
                Game gamePanel = new Game();
                gamePanel.Show();

                //Hides the startup window
                Hide();
            }

            //This button handles the joining of player to a game.
            JoinGameButton.Click += new EventHandler(JoinGameButton_Click);
            void JoinGameButton_Click(object sender, EventArgs e)
            {
                

                //Opens the new window.
                Game gamePanel = new Game();
                gamePanel.Show();

                //Hides the startup window
                Hide();
            }

            string ipFieldPlaceholder = "IP or domain";
            IPField.Text = ipFieldPlaceholder;
            IPField.GotFocus += new EventHandler(ClearIPField);
            void ClearIPField(object sender, EventArgs e)
            {
                IPField.Text = "";
            }
            IPField.LostFocus += new EventHandler(FillIPField);
            void FillIPField(object server, EventArgs e)
            {
                if (IPField.Text == "")
                    IPField.Text = ipFieldPlaceholder;
            }

            string portFieldPlaceholder = "port";
            PortField.Text = portFieldPlaceholder;
            PortField.GotFocus += new EventHandler(ClearPortField);
            void ClearPortField(object sender, EventArgs e)
            {
                PortField.Text = "";
            }
            PortField.LostFocus += new EventHandler(FillPortField);
            void FillPortField(object sender, EventArgs e)
            {
                if (PortField.Text == "")
                    PortField.Text = portFieldPlaceholder;
            }
        }
    }
}
