using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Class1
    {
        private int _speed;
        private string _carname = "elentra";
        public int Speed
        {
            get { return _speed; }
            set { if (value > 120)
                {
                    Console.WriteLine("mimirihaaaaaa....");
                    _speed = 0;
                }
                else
                    _speed = value;
            }
        }
        public string carname
        {
            get { return _carname; }
        }
    }
}
