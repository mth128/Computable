﻿namespace Computable
{
  partial class TestForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.ABox = new System.Windows.Forms.ListBox();
      this.InputBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.AddButton = new System.Windows.Forms.Button();
      this.BBox = new System.Windows.Forms.ListBox();
      this.PlusButton = new System.Windows.Forms.Button();
      this.MinusButton = new System.Windows.Forms.Button();
      this.MultiplyButton = new System.Windows.Forms.Button();
      this.NegateButton = new System.Windows.Forms.Button();
      this.DivideButton = new System.Windows.Forms.Button();
      this.SquareButton = new System.Windows.Forms.Button();
      this.SqrtButton = new System.Windows.Forms.Button();
      this.OutputBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.RemoveButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ABox
      // 
      this.ABox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ABox.FormattingEnabled = true;
      this.ABox.Location = new System.Drawing.Point(84, 4);
      this.ABox.Name = "ABox";
      this.ABox.Size = new System.Drawing.Size(165, 342);
      this.ABox.TabIndex = 0;
      // 
      // InputBox
      // 
      this.InputBox.Location = new System.Drawing.Point(49, 9);
      this.InputBox.Name = "InputBox";
      this.InputBox.Size = new System.Drawing.Size(100, 20);
      this.InputBox.TabIndex = 1;
      this.InputBox.Text = "0";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(34, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Input:";
      // 
      // AddButton
      // 
      this.AddButton.Location = new System.Drawing.Point(155, 7);
      this.AddButton.Name = "AddButton";
      this.AddButton.Size = new System.Drawing.Size(75, 23);
      this.AddButton.TabIndex = 3;
      this.AddButton.Text = "Add";
      this.AddButton.UseVisualStyleBackColor = true;
      this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
      // 
      // BBox
      // 
      this.BBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.BBox.FormattingEnabled = true;
      this.BBox.Location = new System.Drawing.Point(84, 4);
      this.BBox.Name = "BBox";
      this.BBox.Size = new System.Drawing.Size(173, 342);
      this.BBox.TabIndex = 4;
      // 
      // PlusButton
      // 
      this.PlusButton.Location = new System.Drawing.Point(3, 4);
      this.PlusButton.Name = "PlusButton";
      this.PlusButton.Size = new System.Drawing.Size(75, 23);
      this.PlusButton.TabIndex = 5;
      this.PlusButton.Text = "+";
      this.PlusButton.UseVisualStyleBackColor = true;
      this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
      // 
      // MinusButton
      // 
      this.MinusButton.Location = new System.Drawing.Point(3, 33);
      this.MinusButton.Name = "MinusButton";
      this.MinusButton.Size = new System.Drawing.Size(75, 23);
      this.MinusButton.TabIndex = 6;
      this.MinusButton.Text = "-";
      this.MinusButton.UseVisualStyleBackColor = true;
      this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
      // 
      // MultiplyButton
      // 
      this.MultiplyButton.Location = new System.Drawing.Point(3, 62);
      this.MultiplyButton.Name = "MultiplyButton";
      this.MultiplyButton.Size = new System.Drawing.Size(75, 23);
      this.MultiplyButton.TabIndex = 7;
      this.MultiplyButton.Text = "*";
      this.MultiplyButton.UseVisualStyleBackColor = true;
      this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
      // 
      // NegateButton
      // 
      this.NegateButton.Location = new System.Drawing.Point(3, 3);
      this.NegateButton.Name = "NegateButton";
      this.NegateButton.Size = new System.Drawing.Size(75, 23);
      this.NegateButton.TabIndex = 8;
      this.NegateButton.Text = "-";
      this.NegateButton.UseVisualStyleBackColor = true;
      this.NegateButton.Click += new System.EventHandler(this.NegateButton_Click);
      // 
      // DivideButton
      // 
      this.DivideButton.Location = new System.Drawing.Point(3, 91);
      this.DivideButton.Name = "DivideButton";
      this.DivideButton.Size = new System.Drawing.Size(75, 23);
      this.DivideButton.TabIndex = 9;
      this.DivideButton.Text = "/";
      this.DivideButton.UseVisualStyleBackColor = true;
      this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
      // 
      // SquareButton
      // 
      this.SquareButton.Location = new System.Drawing.Point(3, 32);
      this.SquareButton.Name = "SquareButton";
      this.SquareButton.Size = new System.Drawing.Size(75, 23);
      this.SquareButton.TabIndex = 10;
      this.SquareButton.Text = "^2";
      this.SquareButton.UseVisualStyleBackColor = true;
      this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
      // 
      // SqrtButton
      // 
      this.SqrtButton.Location = new System.Drawing.Point(3, 61);
      this.SqrtButton.Name = "SqrtButton";
      this.SqrtButton.Size = new System.Drawing.Size(75, 23);
      this.SqrtButton.TabIndex = 11;
      this.SqrtButton.Text = "Sqrt";
      this.SqrtButton.UseVisualStyleBackColor = true;
      this.SqrtButton.Click += new System.EventHandler(this.SqrtButton_Click);
      // 
      // OutputBox
      // 
      this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.OutputBox.Location = new System.Drawing.Point(335, 9);
      this.OutputBox.Name = "OutputBox";
      this.OutputBox.ReadOnly = true;
      this.OutputBox.Size = new System.Drawing.Size(194, 20);
      this.OutputBox.TabIndex = 12;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(251, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "Last added:";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.Location = new System.Drawing.Point(12, 35);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.RemoveButton);
      this.splitContainer1.Panel1.Controls.Add(this.ABox);
      this.splitContainer1.Panel1.Controls.Add(this.NegateButton);
      this.splitContainer1.Panel1.Controls.Add(this.SquareButton);
      this.splitContainer1.Panel1.Controls.Add(this.SqrtButton);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.BBox);
      this.splitContainer1.Panel2.Controls.Add(this.PlusButton);
      this.splitContainer1.Panel2.Controls.Add(this.MinusButton);
      this.splitContainer1.Panel2.Controls.Add(this.DivideButton);
      this.splitContainer1.Panel2.Controls.Add(this.MultiplyButton);
      this.splitContainer1.Size = new System.Drawing.Size(516, 348);
      this.splitContainer1.SplitterDistance = 252;
      this.splitContainer1.TabIndex = 14;
      // 
      // RemoveButton
      // 
      this.RemoveButton.Location = new System.Drawing.Point(3, 90);
      this.RemoveButton.Name = "RemoveButton";
      this.RemoveButton.Size = new System.Drawing.Size(75, 23);
      this.RemoveButton.TabIndex = 12;
      this.RemoveButton.Text = "Remove";
      this.RemoveButton.UseVisualStyleBackColor = true;
      this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
      // 
      // TestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(541, 392);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.OutputBox);
      this.Controls.Add(this.AddButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.InputBox);
      this.Name = "TestForm";
      this.Text = "Test";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox ABox;
    private System.Windows.Forms.TextBox InputBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.ListBox BBox;
    private System.Windows.Forms.Button PlusButton;
    private System.Windows.Forms.Button MinusButton;
    private System.Windows.Forms.Button MultiplyButton;
    private System.Windows.Forms.Button NegateButton;
    private System.Windows.Forms.Button DivideButton;
    private System.Windows.Forms.Button SquareButton;
    private System.Windows.Forms.Button SqrtButton;
    private System.Windows.Forms.TextBox OutputBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button RemoveButton;
  }
}

