using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NewNumberEventArgs: EventArgs
    {
        public NewNumberEventArgs(int newNumber)
        {
            NewNumber = newNumber;
        }

        public int NewNumber { get;}
    }
}
