﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computable
{
  public class Equation : IValue
  {
    private IValue content;

    public bool Negative => content.Negative;

    public double Value => content.Value;

    public bool Integerable => content.Integerable;

    public bool Fractionable => content.Fractionable;

    public bool Radicalable => content.Radicalable;

    string IValue.Equation => "["+Type+"] "+ Value.ToString() + "=" + content.Equation;

    public string Type => content.Type;

    public int RadicalDepth => content.RadicalDepth;

    public Equation(IValue value)
    {
      if (value == null)
        content = new Integer(0);

      content = value.Direct();
    }

    public static Equation operator+(Equation a, IValue b)
    {
      if (a.Integerable && b.Integerable)
        return new Equation(a.ToInteger() + b.ToInteger());
      if (a.Fractionable && b.Fractionable)
        return new Equation(a.ToFraction() + b.ToFraction());
      if (a.Radicalable && b.Radicalable)
        return new Equation(a.ToRadical() + b.ToRadical());
      return new Equation(new Sum(a.Simple(), b.Simple()));
    }

    public static Equation operator-(Equation a)
    {
      return new Equation(a.Negate()); 
    }

    public static Equation operator-(Equation a, IValue b)
    {
      return a + b.Negate(); 
    }

    public static Equation operator*(Equation a, IValue b)
    {
      if (a.Integerable && b.Integerable)
        return new Equation(a.ToInteger() * b.ToInteger());
      if (a.Fractionable && b.Fractionable)
        return new Equation(a.ToFraction() * b.ToFraction());
      if (a.Radicalable && b.Radicalable)
        return new Equation(a.ToRadical() * b.ToRadical());
      return new Equation(new Product(a.Simple(), b.Simple()));
    }

    public IValue Negate()
    {
      return content.Negate(); 
    }

    public IValue Simple()
    {
      return content.Simple(); 
    }

    public Fraction ToFraction()
    {
      return content.ToFraction();
    }

    public Integer ToInteger()
    {
      return content.ToInteger(); 
    }

    public Radical ToRadical()
    {
      return content.ToRadical();
    }

    public IValue Squared()
    {
      return content.Squared(); 
    }

    public override string ToString()
    {
      return (this as IValue).Equation; 
    }
  }
}
