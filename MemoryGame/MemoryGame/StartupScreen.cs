using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class StartupScreen : Form
    {
        public StartupScreen()
        {
            InitializeComponent();

            Random random = new Random();
            int gridWidth = random.Next(2, 4) * 2;
            int gridHeight = 5;

            String playerNameBoxPlaceholder = "Your name";
            PlayerNameBox.Text = playerNameBoxPlaceholder;
            PlayerNameBox.GotFocus += new EventHandler(clearPlayerNameBox);
            void clearPlayerNameBox(object sender, EventArgs e)
            {
                if (PlayerNameBox.Text == playerNameBoxPlaceholder)
                    PlayerNameBox.Text = "";
            }
            PlayerNameBox.LostFocus += new EventHandler(fillPlayerNameBox);
            void fillPlayerNameBox(object server, EventArgs e)
            {
                if (PlayerNameBox.Text == "")
                    PlayerNameBox.Text = playerNameBoxPlaceholder;
            }


            //This button handles the start of a game that players can join.
            HostGameButton.Click += new EventHandler(hostGameButton_Click);
            void hostGameButton_Click(object sender, EventArgs e)
            {
                new HostGame(gridWidth, gridHeight, PlayerNameBox.Text, this);
            }


            //This button handles the joining of player to a game.
            JoinGameButton.Click += new EventHandler(joinGameButton_Click);
            void joinGameButton_Click(object sender, EventArgs e)
            {
                new ConnectGame(this);
            }


            string ipFieldPlaceholder = "IP or domain";
            IPField.Text = ipFieldPlaceholder;
            IPField.GotFocus += new EventHandler(clearIPField);
            void clearIPField(object sender, EventArgs e)
            {
                if (IPField.Text == ipFieldPlaceholder)
                    IPField.Text = "";
            }
            IPField.LostFocus += new EventHandler(fillIPField);
            void fillIPField(object server, EventArgs e)
            {
                if (IPField.Text == "")
                    IPField.Text = ipFieldPlaceholder;
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

        public void SetMessageBox(string message, Color color)
        {
            MessageBox.Invoke(new Action(() =>
            {
                MessageBox.ForeColor = color;
                MessageBox.Text = message;
            }));
        }

        public void EnableInput(bool state)
        {
            HostGameButton.Invoke(new Action(() =>
            {
                HostGameButton.Enabled = state;
            }));

            JoinGameButton.Invoke(new Action(() =>
            {
                JoinGameButton.Enabled = state;
            }));

            IPField.Invoke(new Action(() =>
            {
                IPField.Enabled = state;
            }));

            PlayerNameBox.Invoke(new Action(() =>
            {
                PlayerNameBox.Enabled = state;
            }));
        }

        public string getIPField()
        {
            return IPField.Text;
        }

        public string getPlayerName()
        {
            return PlayerNameBox.Text;
        }
    }
}
