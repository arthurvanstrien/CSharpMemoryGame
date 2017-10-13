using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class StartupScreen : Form
    {
        public StartupScreen()
        {
            InitializeComponent();

            //This button handles the start of a game that players can join.
            HostGameButton.Click += new EventHandler(hostGameButton_Click);
            void hostGameButton_Click(object sender, EventArgs e)
            {
                //Opens the new window.
                Game gamePanel = new Game();
                gamePanel.Show();

                //Hides the startup window
                Hide();
            }


            //This button handles the joining of player to a game.
            JoinGameButton.Click += new EventHandler(joinGameButton_Click);
            void joinGameButton_Click(object sender, EventArgs e)
            {
                

                //Opens the new window.
                Game gamePanel = new Game();
                gamePanel.Show();

                //Hides the startup window
                Hide();
            }


            string ipFieldPlaceholder = "IP or domain";
            IPField.Text = ipFieldPlaceholder;
            IPField.GotFocus += new EventHandler(clearIPField);
            void clearIPField(object sender, EventArgs e)
            {
                IPField.Text = "";
            }
            IPField.LostFocus += new EventHandler(fillIPField);
            void fillIPField(object server, EventArgs e)
            {
                if (IPField.Text == "")
                    IPField.Text = ipFieldPlaceholder;
            }


            string portFieldPlaceholder = "port";
            PortField.Text = portFieldPlaceholder;
            PortField.GotFocus += new EventHandler(clearPortField);
            void clearPortField(object sender, EventArgs e)
            {
                PortField.Text = "";
            }
            PortField.LostFocus += new EventHandler(fillPortField);
            void fillPortField(object sender, EventArgs e)
            {
                if (PortField.Text == "")
                    PortField.Text = portFieldPlaceholder;
            }


            List<string> rulesBoxList = new List<string>();
            string rulesBoxText = "";
            RulesBox.BorderStyle = BorderStyle.None;
            RulesBox.ForeColor = Color.Black;
            RulesBox.ReadOnly = true;

            rulesBoxList.Add("Welcome to the game memory");
            rulesBoxList.Add("");
            rulesBoxList.Add("You can host a game or connect to one. The game starts when two players are connected with each other.");
            rulesBoxList.Add("When its your turn, turn over any two of the clickable cards.");
            rulesBoxList.Add("If the cards you selected match, they will be grayed out and added to your score.");
            rulesBoxList.Add("If they do not match, remember what emblems are on the cards and turn them back.");
            rulesBoxList.Add("After the cards are turned back, the other player gets the turn.");
            rulesBoxList.Add("While the other player is turning cards, look closely what cards he is turning and try to remember the emblems.");
            rulesBoxList.Add("After the other player turned his cards back, its your turn again. Now try to match two cards again.");
            rulesBoxList.Add("Don't forget to use the locations of the cards you have remembered.");
            rulesBoxList.Add("The match is over when all cards have been matched.");
            rulesBoxList.Add("The player with the most matched cards has the highest score and wins.");
            rulesBoxList.Add("");
            rulesBoxList.Add("Good luck and have fun!");

            foreach (string text in rulesBoxList)
            {
                rulesBoxText = rulesBoxText + text + "\r\n";
            }
            RulesBox.Text = rulesBoxText;
        }
    }
}
