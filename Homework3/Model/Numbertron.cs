using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {  
        public event EventHandler<NewNumberEventArgs> NewNumber;

        public void Generate(Random rnd)
        {
            int rndNumber = rnd.Next(10);

            NewNumber?.Invoke(this, new NewNumberEventArgs(rndNumber));
        }
    }
}
