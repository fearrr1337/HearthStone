using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class IntLimit
    {
        public int _max = -1;
        public int Max
        {
            get
            {
                return _max;
            }
            set
            {
                _max = value;
                if (_value > _max && _max > 0)
                    _value = _max;
            }
        }
        private int _value;
        public int Value {
            get {
                return _value;
            }
            set
            {
                if (value > _max && _max > 0) 
                    _value = _max;
                else
                    _value = value;
            }
        }
    }
}
