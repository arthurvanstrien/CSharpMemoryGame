using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    class HostGame
    {
        private List<string> Cards { get; }
        private string PlayerName { get; }
        private int X { get; } 
        private int Y { get; }
        private StartupScreen startupScreen;
        private bool Heads { get; set; }

        public HostGame(int x, int y, string playerName, StartupScreen startupScreen)
        {
            Cards = new Cards().GetRandomCards(x * y);
            PlayerName = playerName;
            X = x;
            Y = y;
            this.startupScreen = startupScreen;

            Thread thread = new Thread(WaitForPlayer);
            thread.Start(this);
        }

        static void WaitForPlayer(object obj)
        {
            HostGame hostGame = obj as HostGame;

            IPAddress localhost;

            bool ipIsOk = IPAddress.TryParse("127.0.0.1", out localhost);
            if (!ipIsOk) { WriteToConsole("The IP adress cannot be parsed."); Environment.Exit(1); }

            TcpListener listener = new TcpListener(localhost, 1300);
            listener.Start();

            WriteToConsole("Waiting on client " + DateTime.Now.ToString());

            hostGame.startupScreen.EnableInput(false);

            //Display a message while we wait for clients to connect:
            var task = WaitingForClient(listener);
            int counter = 0;
            while (task.IsCompleted == false)
            {
                if (counter == 0)
                {
                    hostGame.startupScreen.SetMessageBox("Waiting for client to connect", System.Drawing.Color.Blue);
                    counter++;
                    Thread.Sleep(500);
                }
                else if (counter == 1)
                {
                    hostGame.startupScreen.SetMessageBox("Waiting for client to connect >", System.Drawing.Color.Blue);
                    counter++;
                    Thread.Sleep(500);
                }
                else if (counter == 2)
                {
                    hostGame.startupScreen.SetMessageBox("Waiting for client to connect >>", System.Drawing.Color.Blue);
                    counter++;
                    Thread.Sleep(500);
                }
                else if (counter == 3)
                {
                    hostGame.startupScreen.SetMessageBox("Waiting for client to connect >>>", System.Drawing.Color.Blue);
                    counter = 0;
                    Thread.Sleep(500);
                }
            }
            TcpClient client = task.Result;

            WriteToConsole("Client connected.");

            StreamReader streamReader = new StreamReader(client.GetStream(), Encoding.ASCII);
            StreamWriter streamWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);

            //Sending our playername to the other player.
            streamWriter.WriteLine(hostGame.PlayerName);
            streamWriter.Flush();

            //Sending the amount of cards we are going to send to the other player.
            streamWriter.WriteLine(hostGame.X);
            streamWriter.Flush();
            streamWriter.WriteLine(hostGame.Y);
            streamWriter.Flush();
            WriteToConsole("Y * X: " + hostGame.X * hostGame.Y);
            WriteToConsole("Number of cards: " + hostGame.Cards.Count);

            //Writing the actual cards to the other player.
            foreach (string card in hostGame.Cards)
            {
                streamWriter.WriteLine(card);
                streamWriter.Flush();
                WriteToConsole(card);
            }

            //Determine who's turn it is.
            Random rand = new Random(2);
            hostGame.Heads = rand.NextDouble() == 0;
            streamWriter.WriteLine(hostGame.Heads);
            streamWriter.Flush();
            WriteToConsole("myturn --> " + hostGame.Heads);

            //Recieving the name from the connected player.
            string connectedPlayerName = streamReader.ReadLine();

            StartGame(connectedPlayerName, hostGame, streamReader, streamWriter);

            client.Close();
            WriteToConsole("Connection closed");
        }

        private static void StartGame(string opponent, HostGame hostGame, StreamReader streamReader, StreamWriter streamWriter)
        {
            //Opens the new window.
            Game gamePanel = new Game(hostGame.PlayerName, opponent, hostGame.X, hostGame.Y, hostGame.Cards, hostGame.Heads, streamReader, streamWriter);
            Application.Run(gamePanel);

            //Hides the startup window
            hostGame.startupScreen.HideScreen();
        }

        private static void WriteToConsole(string message)
        {
            Console.WriteLine("Server: " + message);
        }

        private static async Task<TcpClient> WaitingForClient(TcpListener listener)
        {
            return await listener.AcceptTcpClientAsync();
        }
    }
}
