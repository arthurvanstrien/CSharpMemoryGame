using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryGame
{
    class HostGame
    {
        private List<string> cards;
        private string playerName;
        private int x;
        private int y;
        private StartupScreen startupScreen;

        public HostGame(int x, int y, string playerName, StartupScreen startupScreen)
        {
            cards = new Cards().getRandomCards(x * y);
            this.playerName = playerName;
            this.x = x;
            this.y = y;
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
            WriteToConsole(streamReader.ReadLine());

            StreamWriter streamWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            streamWriter.WriteLine("OK");
            streamWriter.Flush();

            client.Close();
            WriteToConsole("Connection closed");

            StartGame("opponent", hostGame);
        }

        private static void StartGame(string opponent, HostGame hostGame)
        {
            //Opens the new window.
            Game gamePanel = new Game(hostGame.playerName, opponent, hostGame.x, hostGame.y);
            gamePanel.Show();

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
