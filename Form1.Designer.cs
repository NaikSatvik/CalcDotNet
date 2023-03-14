﻿
namespace Calculator
{
    partial class calc_form
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
            this.display = new System.Windows.Forms.TextBox();
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.modulo = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.doubleZero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.GrayText;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.Color.Gold;
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(224, 50);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            this.display.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.display_TextChanged);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(71, 306);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(47, 55);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 248);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(47, 55);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(71, 248);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(47, 55);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(130, 248);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(47, 55);
            this.three.TabIndex = 4;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 190);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(47, 55);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(71, 190);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(47, 55);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(130, 190);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(47, 55);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 132);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(47, 55);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(71, 132);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(47, 55);
            this.eight.TabIndex = 9;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(130, 132);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(47, 55);
            this.nine.TabIndex = 10;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(189, 132);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(47, 55);
            this.divide.TabIndex = 11;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(189, 190);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(47, 55);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(189, 248);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(47, 55);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equals.Location = new System.Drawing.Point(188, 306);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(47, 55);
            this.equals.TabIndex = 14;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(130, 306);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(47, 55);
            this.dot.TabIndex = 15;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 71);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(47, 55);
            this.clear.TabIndex = 16;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(130, 71);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(47, 55);
            this.plus.TabIndex = 17;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // modulo
            // 
            this.modulo.Location = new System.Drawing.Point(71, 71);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(47, 55);
            this.modulo.TabIndex = 18;
            this.modulo.Text = "%";
            this.modulo.UseVisualStyleBackColor = true;
            this.modulo.Click += new System.EventHandler(this.modulo_Click);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(189, 71);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(47, 55);
            this.backspace.TabIndex = 19;
            this.backspace.Text = "<-";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // doubleZero
            // 
            this.doubleZero.Location = new System.Drawing.Point(12, 306);
            this.doubleZero.Name = "doubleZero";
            this.doubleZero.Size = new System.Drawing.Size(47, 55);
            this.doubleZero.TabIndex = 20;
            this.doubleZero.Text = "00";
            this.doubleZero.UseVisualStyleBackColor = true;
            this.doubleZero.Click += new System.EventHandler(this.doubleZero_Click);
            // 
            // calc_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 369);
            this.Controls.Add(this.doubleZero);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.display);
            this.Name = "calc_form";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calc_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button modulo;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button doubleZero;
    }
}