using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace MemoryGame
{
    class ConnectGame
    {
        public ConnectGame(StartupScreen startupScreen)
        {
            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 1330);
            startupScreen.SetMessageBox("Establishing connection", System.Drawing.Color.Blue);
            startupScreen.EnableInput(false);

            StreamWriter streamWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            streamWriter.WriteLine("HI");
            streamWriter.Flush();

            StreamReader streamReader = new StreamReader(client.GetStream(), Encoding.ASCII);
            WriteToConsole(streamReader.ReadLine());

            //TODO: Update data of the game panel with data from the serverside.
            Game gamePanel = new Game(startupScreen.getPlayerName(), "Connecting player name TODO", 6, 6);
            gamePanel.Show();

            //Hides the startup window
            startupScreen.Hide();
        }

        private static void WriteToConsole(string message)
        {
            Console.WriteLine("Client: " + message);
        }
    }
}
