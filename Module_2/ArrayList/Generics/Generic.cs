using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Generic<T>
    {
        public bool Equal(T value_1, T value_2)
        {
            return value_1.Equals(value_2);
        }
    }
}
