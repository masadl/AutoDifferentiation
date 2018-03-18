using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic
{
    public interface IArithmetic
    {
        public static IArithmetic operator +(IArithmetic a, IArithmetic b);
    }
}
