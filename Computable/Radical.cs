using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computable
{
  public class Radical: IValue
  {
    private double value = double.NaN;
    public IValue Coefficient; 
    public IValue Radicant;

    public double Value => double.IsNaN(value)? value = Math.Sqrt(Radicant.Value) * Coefficient.Value : value;

    public bool Negative => Coefficient.Negative;

    public bool Integerable => Radicant.Simple() is Integer radicant && radicant == 1 && Coefficient.Integerable;

    public bool Fractionable => Radicant.Simple() is Integer radicant && radicant == 1 && Coefficient.Fractionable;

    public bool Radicalable => true;

    public string Equation => (Coefficient is Integer coeffecient && coeffecient == 1 ? "":Coefficient.Equation+"*") + "Sqrt(" + Radicant.Equation + ")";

    public string Type => "Radical";  

    public Radical(IValue value)
    {
      value = value.Direct(); 
      if (value is Integer integer)
      {
        if (integer < 0)
          throw new ArgumentOutOfRangeException("Cannot calculate radical for negative integer.");
        Radicant = new Integer(integer.GetNonDuplicateFactors());
        Coefficient = new Integer(integer.GetDuplicateFactors());
        return; 
      }
      if (value is Fraction fraction)
      {
        if (fraction.Numerator is Integer numerator && fraction.Denominator is Integer denominator)
        {
          Integer radicantNumerator = new Integer(numerator.GetDuplicateFactors());
          Integer radicantDenominator = new Integer(denominator.GetDuplicateFactors());
          Integer coefficientNumerator = new Integer(numerator.GetNonDuplicateFactors());
          Integer coefficientDenominator = new Integer(denominator.GetNonDuplicateFactors());
          
          //simplifying
          radicantNumerator *= radicantDenominator;
          coefficientDenominator *= radicantDenominator;
          radicantDenominator = new Integer(1);

          Radicant = new Fraction(radicantNumerator, radicantDenominator);
          Coefficient = new Fraction(coefficientNumerator, coefficientDenominator);
          return; 
        }
      }
      if (value is Radical radical)
      {
        Radical coefficientRadical = new Radical(radical.Coefficient);
        Coefficient = coefficientRadical.Coefficient;
        Radicant = new Radical(radical.Radicant, coefficientRadical.Radicant, true);
        return;
      }

      Coefficient = new Integer(1); 
      Radicant = value;
    }

    public Radical(IValue radicant, IValue coefficient, bool simplify = false)
    {
      Radicant = radicant.Direct();
      Coefficient = coefficient.Direct();
      if (simplify)
        Simplify();
    }

    public static Radical operator*(Radical a, Radical b)
    {
      return new Radical(new Product(a.Radicant, b.Radicant).Simple(), new Product(a.Coefficient, b.Coefficient).Simple(), true); 
    }

    public static Radical operator /(Radical a, Radical b)
    {
      return new Radical(
        new Product(a.Radicant, b.Radicant).Simple(), 
        new Fraction(a.Coefficient, new Product(b.Coefficient, b.Radicant).Simple()).Simple(), 
        true);
    }
    
    public static IValue operator +(Radical a, Radical b)
    {
      if (a.SameRadicant(b))
        return new Radical(a.Radicant,new Sum(a.Coefficient,b.Coefficient).Simple());

      return new Sum(a, b); 
    }

    public static Radical operator -(Radical a)
    {
      return new Radical(a.Radicant, a.Coefficient.Negate()); 
    }

    public static IValue operator -(Radical a, Radical b)
    {
      return a + -b; 
    }

    public bool SameRadicant(Radical b)
    {
      return Radicant.Is(b.Radicant); 
    }



    private void Simplify()
    {
      if (Radicant.Integerable)
      {
        Integer radicant = Radicant.ToInteger();
        if (radicant == 0)
        {
          Coefficient = new Integer(0);
          Radicant = new Integer(1);
          return; 
        }
        Integer multiplyer = new Integer(radicant.GetDuplicateFactors()); 
        if (multiplyer!=1)
        {
          Radicant = new Integer(radicant.GetNonDuplicateFactors());
          Coefficient = new Product(Coefficient, multiplyer).Simple(); 
        }
      }

      if (Coefficient is Radical coefficient)
      {
        Coefficient = coefficient.Coefficient;
        Radicant = new Product(Radicant, coefficient.Radicant).Simple(); 
      }

    }

    public IValue Negate() => -this; 

    public IValue Simple()
    {
      if (Radicant.Simple() is Integer i)
      {
        if (i == 1)
          return Coefficient.Simple(); 
      }
      return this; 
    }

    public Fraction ToFraction()
    {
      if (Radicant.Simple() is Integer radicant && radicant == 1)
        return Coefficient.ToFraction();
      throw new Exception("This radical is not fractionable.");
    }

    public Radical ToRadical()
    {
      return this; 
    }

    public Integer ToInteger()
    {      
      if (Radicant.Simple() is Integer radicant && radicant == 1)
        return Coefficient.ToInteger();

      throw new Exception("This radical is not integerable.");
    }

    public IValue Squared()
    {
      return new Product(Coefficient.Squared(), Radicant).Simple();
    }

    public override string ToString() => "[" + Type + "] " + Equation + "=" + Value.ToString();
  }
}
