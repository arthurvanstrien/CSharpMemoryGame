using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame
{
    class Cards
    {
        public Cards()
        {
            
        }

        public List<string> GetRandomCards(int numberOf)
        {
            List<string> cards = new List<string>();

            string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            string directory = Directory.GetParent(Directory.GetParent(directoryPath).ToString()).ToString();
            directory = Path.Combine(directory, "Resources");
            string[] images = Directory.GetFiles(directory).Select(file => Path.GetFileName(file)).ToArray();
            Console.WriteLine(images);

            for (int i = 0; i < ((numberOf / 2)); i++)
            {
                string filePath = images[i];
                //string filePath = Path.Combine(directory, fileName);
                cards.Add(filePath);
                cards.Add(filePath);
            }

            cards = cards.OrderBy(a => Guid.NewGuid()).ToList();

            return cards;
        }
    }
}
