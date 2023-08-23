using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
 

    public class Animal
    {
        private string _nowName;
        private string _previousName = null;
        public string NowName
        {
            get { return _nowName; }
            set
            {
                _previousName = _nowName;
                _nowName = value;
            }
        }

        public string PreviousName
        {
            get { return _previousName; }
        }
    

        public int Age { get; set; }
        public Color Color { get; set; }


    }

}

