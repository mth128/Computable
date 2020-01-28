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
        return new ComplexNumber(value); 

      return new Radical(value).Simple(); 
    }
    public static IValue Abs(IValue value)
    {
      if (value.Negative)
        return value.Negate();

      return value; 
    }
  }
}
