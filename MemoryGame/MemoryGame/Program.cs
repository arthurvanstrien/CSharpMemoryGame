using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<string> images = new List<string>();
            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string directory = Directory.GetParent(Directory.GetParent(directoryPath).ToString()).ToString();
            string fileName = "Resources\\6Siegeicon.png";
            string sixSiegePath = Path.Combine(directory, fileName);
            fileName = "Resources\\LeagueIcon.png";
            string LeaguePath = Path.Combine(directory, fileName);

            images.Add(sixSiegePath);
            images.Add(LeaguePath);
            images.Add(LeaguePath);
            images.Add(sixSiegePath);

            Application.Run(new Game("patrick", "arthur", 2, 2, images));
        }
    }
}
