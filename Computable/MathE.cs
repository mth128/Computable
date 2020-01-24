using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computable
{
  public class MathE
  {
    public static IValue Sqrt(IValue value)
    {
      if (value.Negative)
        throw new ArgumentOutOfRangeException("Square root of negative not allowed.");

      return new Radical(value).Simple(); 
    }
  }
}
