using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Randomizer
    {
        private static Random _rnd { get; set; }
        
        public static Random Rnd
        {
            get
            {
                if (_rnd == null)
                {
                    _rnd = new Random();
                    return _rnd;
                }
                else
                {
                    return _rnd;
                }
                
            }
        }
    }
}
