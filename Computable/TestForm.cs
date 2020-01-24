using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computable
{
  public partial class TestForm : Form
  {
    List<Equation> equations = new List<Equation>(); 

    public TestForm()
    {
      InitializeComponent();
      Prime.InitializePrimes(); 
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
      try
      {
        Equation equation = new Equation(new Integer(Convert.ToInt64(InputBox.Text)));
        Add(equation); 
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message,"Error"); 
      }
    }

    private void Add(IValue value)
    {
      Equation equation = new Equation(value); 
      OutputBox.Text = equation.ToString(); 
      equations.Add(equation);
      UpdateLists(); 
    }

    private void UpdateLists()
    {
      ABox.Items.Clear();
      BBox.Items.Clear(); 
      foreach (Equation equation in equations)
      {
        string s = equation.ToString(); 
        ABox.Items.Add(s);
        BBox.Items.Add(s);
      }
      if (equations.Count >0)
      {
        ABox.SelectedIndex = equations.Count - 1;
        BBox.SelectedIndex = equations.Count - 1; 
      }
    }

    public Equation GetA()
    {
      return equations[ABox.SelectedIndex];
    }
    public Equation GetB()
    {
      return equations[BBox.SelectedIndex];
    }

    private void NegateButton_Click(object sender, EventArgs e)
    {
      try
      {
        Add(GetA().Negate());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error"); 
      }

    }

    private void SquareButton_Click(object sender, EventArgs e)
    {
      try
      {
        Add(GetA().Squared()); 
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void SqrtButton_Click(object sender, EventArgs e)
    {
      try
      {
        Add(MathE.Sqrt(GetA()));
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void PlusButton_Click(object sender, EventArgs e)
    {
      try
      {
        Add(new Sum(GetA(),GetB()).Simple());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void MinusButton_Click(object sender, EventArgs e)
    {
      try
      {
        Add(new Sum(GetA(), GetB().Negate()).Simple());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void MultiplyButton_Click(object sender, EventArgs e)
    {
      try
      {
        Add(new Product(GetA(), GetB()).Simple());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void DivideButton_Click(object sender, EventArgs e)
    {
      try
      {
        Add(new Fraction(GetA(), GetB()).Simple());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
      try
      {
        int index = ABox.SelectedIndex;
        equations.RemoveAt(index);
        UpdateLists();
        if (index < ABox.Items.Count)
        {
          ABox.SelectedIndex = index;
          BBox.SelectedIndex = index;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
    }
  }
}
