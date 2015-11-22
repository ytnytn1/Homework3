using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jay: Gambler
    {
        public Jay() : base("Jay")
        {
        }
        
        public override void FetchNewNumber(object sender, NewNumberEventArgs e)
        {
            if (e.NewNumber.IsEven())
            {
                Score++;
            }
        }
    }
}
