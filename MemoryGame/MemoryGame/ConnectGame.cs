using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MemoryGame
{
    class ConnectGame
    {
        private TcpClient Client { get; }
        private StartupScreen StartupScreen { get; }
        private List<string> Cards { get; }
        private string Playername { get; }
        private int X { get; set;  }
        private int Y { get; set; }
        private bool Heads { get; set; }

        public ConnectGame(StartupScreen startupScreen)
        {
            try
            {
                Client = new TcpClient();
                Client.Connect(startupScreen.GetIPField(), 1300);
                StartupScreen = startupScreen;
                Cards = new List<string>();
                Playername = StartupScreen.GetPlayerName();
                X = 0;
                Y = 0;

                StartupScreen.SetMessageBox("Establishing connection", System.Drawing.Color.Blue);
                StartupScreen.EnableInput(false);

                try
                {
                    Thread thread = new Thread(SetupGame);
                    thread.Start(this);
                }
                catch
                {
                    StartupScreen.SetMessageBox("Unable to connect to game", System.Drawing.Color.Red);
                }
            }
            catch(Exception e)
            {
                Console.Write(e);
                startupScreen.SetMessageBox("IP is invalid/Host is offline", Color.Red);
            }
        }

        private static void SetupGame(object obj)
        {
            try
            {
                ConnectGame connectGame = obj as ConnectGame;
                TcpClient client = connectGame.Client;

                StreamReader streamReader = new StreamReader(client.GetStream(), Encoding.ASCII);
                StreamWriter streamWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);

                //Recieving the other players playername.
                string hostPlayerName = streamReader.ReadLine();

                //Recieving the dimenstions of the board.
                connectGame.X = int.Parse(streamReader.ReadLine());
                connectGame.Y = int.Parse(streamReader.ReadLine());
                WriteToConsole("Number of cards: " + connectGame.Y * connectGame.X);

                string card;
                //Recieving the cards from the host.
                for (int i = 0; i < (connectGame.X * connectGame.Y); i++)
                {
                    WriteToConsole(" --> I: " + i);
                    card = streamReader.ReadLine();
                    connectGame.Cards.Add(card);
                    WriteToConsole(card);
                }

                //Revieve wich player will start.
                connectGame.Heads = bool.Parse(streamReader.ReadLine());
                WriteToConsole("myturn --> " + connectGame.Heads);

                //Send the playername to the host.
                streamWriter.WriteLine(connectGame.Playername);
                streamWriter.Flush();

                StartGame(hostPlayerName, connectGame, streamReader, streamWriter);
            }
            catch (Exception e)
            {
                Console.Write(e);
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private static void StartGame(string opponent, ConnectGame connectGame, StreamReader streamReader, StreamWriter streamWriter)
        {
            Game gamePanel = new Game(connectGame.Playername, opponent, connectGame.X, connectGame.Y, connectGame.Cards, connectGame.Heads, streamReader, streamWriter);
            Application.Run(gamePanel);
            connectGame.StartupScreen.HideScreen();
        }

        private static void WriteToConsole(string message)
        {
            Console.WriteLine("Client: " + message);
        }
    }
}
