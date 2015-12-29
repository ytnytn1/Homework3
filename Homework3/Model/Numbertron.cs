using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        
        public event EventHandler <NewNumberEventArgs> NewNumber;

        public void Generate()
        {
            int rndNumber = Randomizer.Rnd.Next();
            NewNumber?.Invoke(this, new NewNumberEventArgs(rndNumber));
        }
    }
}
