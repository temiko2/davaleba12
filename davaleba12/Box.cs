using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    public class Box<T>
    {
        private T _value;
        public void SetValue(T newValue)

        {
            _value = newValue;
        }

        public T GetValue()
        {
            return _value;
        }
    }
}
