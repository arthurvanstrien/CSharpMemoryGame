using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class HostGame
    {
        public HostGame(int x, int y)
        {
            List<string> cards = new Cards().getRandomCards(x * y);
        }

        

    }
}
