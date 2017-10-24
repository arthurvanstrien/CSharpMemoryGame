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
            string[] filepaths = Directory.GetFiles(directory);
            string[] images = new string[20];
            for(int i = 0; i < filepaths.Length; i++){
                images[i] = Path.GetFileName(filepaths[i]);
            }

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
