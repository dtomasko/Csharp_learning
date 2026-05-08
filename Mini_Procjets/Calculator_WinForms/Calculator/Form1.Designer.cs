namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtOutput = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnEqual = new Button();
            button0 = new Button();
            clearTxt = new Button();
            btnSub = new Button();
            btnPlus = new Button();
            btnDiv = new Button();
            btnSqrt = new Button();
            btnMulti = new Button();
            btnCE = new Button();
            btnDot = new Button();
            leftParent = new Button();
            rightParent = new Button();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.AccessibleName = "";
            txtOutput.Font = new Font("Segoe UI", 20F);
            txtOutput.Location = new Point(29, 33);
            txtOutput.Margin = new Padding(3, 4, 3, 4);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(332, 43);
            txtOutput.TabIndex = 0;
            txtOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(29, 110);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 51);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(148, 114);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 47);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(276, 114);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 47);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(29, 178);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 51);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F);
            button5.Location = new Point(148, 178);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 51);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F);
            button6.Location = new Point(276, 178);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 51);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14F);
            button7.Location = new Point(29, 251);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 51);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14F);
            button8.Location = new Point(148, 251);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 51);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14F);
            button9.Location = new Point(276, 251);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(86, 51);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.AppWorkspace;
            btnEqual.Font = new Font("Segoe UI", 16F);
            btnEqual.Location = new Point(29, 326);
            btnEqual.Margin = new Padding(3, 4, 3, 4);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(86, 51);
            btnEqual.TabIndex = 10;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += equals_clicked;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 14F);
            button0.Location = new Point(148, 326);
            button0.Margin = new Padding(3, 4, 3, 4);
            button0.Name = "button0";
            button0.Size = new Size(86, 51);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_click;
            // 
            // clearTxt
            // 
            clearTxt.BackColor = SystemColors.GradientActiveCaption;
            clearTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearTxt.ForeColor = SystemColors.ControlText;
            clearTxt.Location = new Point(276, 549);
            clearTxt.Margin = new Padding(3, 4, 3, 4);
            clearTxt.Name = "clearTxt";
            clearTxt.Size = new Size(86, 51);
            clearTxt.TabIndex = 12;
            clearTxt.Text = "CLEAR";
            clearTxt.UseVisualStyleBackColor = false;
            clearTxt.Click += CLEAR_clicked;
            // 
            // btnSub
            // 
            btnSub.BackColor = SystemColors.AppWorkspace;
            btnSub.Font = new Font("Segoe UI", 18F);
            btnSub.Location = new Point(29, 399);
            btnSub.Margin = new Padding(3, 4, 3, 4);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(86, 51);
            btnSub.TabIndex = 13;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += button_click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.AppWorkspace;
            btnPlus.Font = new Font("Segoe UI", 16F);
            btnPlus.Location = new Point(148, 399);
            btnPlus.Margin = new Padding(3, 4, 3, 4);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(86, 51);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += button_click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.AppWorkspace;
            btnDiv.Font = new Font("Segoe UI", 15F);
            btnDiv.Location = new Point(276, 399);
            btnDiv.Margin = new Padding(3, 4, 3, 4);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(86, 51);
            btnDiv.TabIndex = 15;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += button_click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = SystemColors.AppWorkspace;
            btnSqrt.Font = new Font("Segoe UI", 16F);
            btnSqrt.Location = new Point(29, 550);
            btnSqrt.Margin = new Padding(3, 4, 3, 4);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(86, 51);
            btnSqrt.TabIndex = 16;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += button_click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = SystemColors.AppWorkspace;
            btnMulti.Font = new Font("Segoe UI", 16F);
            btnMulti.Location = new Point(276, 326);
            btnMulti.Margin = new Padding(3, 4, 3, 4);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(86, 51);
            btnMulti.TabIndex = 17;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += button_click;
            // 
            // btnCE
            // 
            btnCE.BackColor = SystemColors.GradientActiveCaption;
            btnCE.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCE.Location = new Point(149, 549);
            btnCE.Margin = new Padding(3, 4, 3, 4);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(86, 51);
            btnCE.TabIndex = 18;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += CE_clicked;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.AppWorkspace;
            btnDot.Font = new Font("Segoe UI", 24F);
            btnDot.Location = new Point(276, 471);
            btnDot.Margin = new Padding(3, 4, 3, 4);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(86, 51);
            btnDot.TabIndex = 19;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += button_click;
            // 
            // leftParent
            // 
            leftParent.BackColor = SystemColors.AppWorkspace;
            leftParent.Font = new Font("Segoe UI", 18F);
            leftParent.Location = new Point(29, 475);
            leftParent.Margin = new Padding(3, 4, 3, 4);
            leftParent.Name = "leftParent";
            leftParent.Size = new Size(86, 51);
            leftParent.TabIndex = 20;
            leftParent.Text = "(";
            leftParent.UseVisualStyleBackColor = false;
            leftParent.Click += button_click;
            // 
            // rightParent
            // 
            rightParent.BackColor = SystemColors.AppWorkspace;
            rightParent.Font = new Font("Segoe UI", 18F);
            rightParent.Location = new Point(148, 475);
            rightParent.Margin = new Padding(3, 4, 3, 4);
            rightParent.Name = "rightParent";
            rightParent.Size = new Size(86, 51);
            rightParent.TabIndex = 21;
            rightParent.Text = ")";
            rightParent.UseVisualStyleBackColor = false;
            rightParent.Click += button_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 621);
            Controls.Add(rightParent);
            Controls.Add(leftParent);
            Controls.Add(btnDot);
            Controls.Add(btnCE);
            Controls.Add(btnMulti);
            Controls.Add(btnSqrt);
            Controls.Add(btnDiv);
            Controls.Add(btnPlus);
            Controls.Add(btnSub);
            Controls.Add(clearTxt);
            Controls.Add(button0);
            Controls.Add(btnEqual);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtOutput);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Calculator by Dominik!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutput;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnEqual;
        private Button button0;
        private Button clearTxt;
        private Button btnSub;
        private Button btnPlus;
        private Button btnDiv;
        private Button btnSqrt;
        private Button btnMulti;
        private Button btnCE;
        private Button btnDot;
        private Button leftParent;
        private Button rightParent;
    }
}