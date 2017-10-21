using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Cards
    {
        List<string> images;

        public Cards()
        {
            images = new List<string>
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20"
            };
        }

        public List<string> GetRandomCards(int numberOf)
        {
            List<string> cards = new List<string>();
            images = images.OrderBy(a => Guid.NewGuid()).ToList();

            for (int i = 0; i < ((numberOf / 2) - 1); i++)
            {
                cards.Add(images[i]);
                cards.Add(images[i]);
            }

            cards = cards.OrderBy(a => Guid.NewGuid()).ToList();

            return cards;
        }
    }
}
