namespace C__MS_Calculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            CalcOutputTextBox = new TextBox();
            Percentage_Button = new Button();
            Divide_Button = new Button();
            Nine_Button = new Button();
            Eight_Button = new Button();
            Seven_Button = new Button();
            Sqrt_Button = new Button();
            ChangeSign_Button = new Button();
            C_Button = new Button();
            CE_Button = new Button();
            Backspace_Button = new Button();
            MMinus_Button = new Button();
            MPlus_Button = new Button();
            MS_Button = new Button();
            MR_Button = new Button();
            MC_Button = new Button();
            buttonLayoutGrid = new TableLayoutPanel();
            Four_Button = new Button();
            Five_Button = new Button();
            Six_Button = new Button();
            Multiply_Button = new Button();
            Reciprocal_Button = new Button();
            One_Button = new Button();
            Two_Button = new Button();
            Three_Button = new Button();
            Minus_Button = new Button();
            Equals_Button = new Button();
            Zero_Button = new Button();
            Decimal_Button = new Button();
            Add_Button = new Button();
            CalcAnswerTextBox = new TextBox();
            buttonLayoutGrid.SuspendLayout();
            SuspendLayout();
            // 
            // CalcOutputTextBox
            // 
            CalcOutputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CalcOutputTextBox.Font = new Font("Segoe UI", 25.25F, FontStyle.Bold, GraphicsUnit.Point);
            CalcOutputTextBox.Location = new Point(14, 64);
            CalcOutputTextBox.Margin = new Padding(3, 4, 3, 4);
            CalcOutputTextBox.Name = "CalcOutputTextBox";
            CalcOutputTextBox.ReadOnly = true;
            CalcOutputTextBox.Size = new Size(411, 63);
            CalcOutputTextBox.TabIndex = 0;
            CalcOutputTextBox.Text = "0";
            CalcOutputTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Percentage_Button
            // 
            Percentage_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Percentage_Button.AutoSize = true;
            Percentage_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Percentage_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Percentage_Button.Location = new Point(331, 154);
            Percentage_Button.Margin = new Padding(3, 4, 3, 4);
            Percentage_Button.Name = "Percentage_Button";
            Percentage_Button.Size = new Size(77, 67);
            Percentage_Button.TabIndex = 14;
            Percentage_Button.Text = "%";
            Percentage_Button.UseVisualStyleBackColor = true;
            Percentage_Button.Click += Percentage_Button_Click;
            // 
            // Divide_Button
            // 
            Divide_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Divide_Button.AutoSize = true;
            Divide_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Divide_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Divide_Button.Location = new Point(249, 154);
            Divide_Button.Margin = new Padding(3, 4, 3, 4);
            Divide_Button.Name = "Divide_Button";
            Divide_Button.Size = new Size(76, 67);
            Divide_Button.TabIndex = 13;
            Divide_Button.Text = "÷";
            Divide_Button.UseVisualStyleBackColor = true;
            Divide_Button.Click += Divide_Button_Click;
            // 
            // Nine_Button
            // 
            Nine_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Nine_Button.AutoSize = true;
            Nine_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Nine_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nine_Button.Location = new Point(167, 154);
            Nine_Button.Margin = new Padding(3, 4, 3, 4);
            Nine_Button.Name = "Nine_Button";
            Nine_Button.Size = new Size(76, 67);
            Nine_Button.TabIndex = 12;
            Nine_Button.Text = "9";
            Nine_Button.UseVisualStyleBackColor = true;
            Nine_Button.Click += Digits_Buttons_Click;
            // 
            // Eight_Button
            // 
            Eight_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Eight_Button.AutoSize = true;
            Eight_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Eight_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Eight_Button.Location = new Point(85, 154);
            Eight_Button.Margin = new Padding(3, 4, 3, 4);
            Eight_Button.Name = "Eight_Button";
            Eight_Button.Size = new Size(76, 67);
            Eight_Button.TabIndex = 11;
            Eight_Button.Text = "8";
            Eight_Button.UseVisualStyleBackColor = true;
            Eight_Button.Click += Digits_Buttons_Click;
            // 
            // Seven_Button
            // 
            Seven_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Seven_Button.AutoSize = true;
            Seven_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Seven_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Seven_Button.Location = new Point(3, 154);
            Seven_Button.Margin = new Padding(3, 4, 3, 4);
            Seven_Button.Name = "Seven_Button";
            Seven_Button.Size = new Size(76, 67);
            Seven_Button.TabIndex = 10;
            Seven_Button.Text = "7";
            Seven_Button.UseVisualStyleBackColor = true;
            Seven_Button.Click += Digits_Buttons_Click;
            // 
            // Sqrt_Button
            // 
            Sqrt_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Sqrt_Button.AutoSize = true;
            Sqrt_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Sqrt_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Sqrt_Button.Location = new Point(331, 79);
            Sqrt_Button.Margin = new Padding(3, 4, 3, 4);
            Sqrt_Button.Name = "Sqrt_Button";
            Sqrt_Button.Size = new Size(77, 67);
            Sqrt_Button.TabIndex = 9;
            Sqrt_Button.Text = "√";
            Sqrt_Button.UseVisualStyleBackColor = true;
            Sqrt_Button.Click += Sqrt_Button_Click;
            // 
            // ChangeSign_Button
            // 
            ChangeSign_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChangeSign_Button.AutoSize = true;
            ChangeSign_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChangeSign_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeSign_Button.Location = new Point(249, 79);
            ChangeSign_Button.Margin = new Padding(3, 4, 3, 4);
            ChangeSign_Button.Name = "ChangeSign_Button";
            ChangeSign_Button.Size = new Size(76, 67);
            ChangeSign_Button.TabIndex = 8;
            ChangeSign_Button.Text = "±";
            ChangeSign_Button.UseVisualStyleBackColor = true;
            ChangeSign_Button.Click += ChangeSign_Button_Click;
            // 
            // C_Button
            // 
            C_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            C_Button.AutoSize = true;
            C_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            C_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            C_Button.Location = new Point(167, 79);
            C_Button.Margin = new Padding(3, 4, 3, 4);
            C_Button.Name = "C_Button";
            C_Button.Size = new Size(76, 67);
            C_Button.TabIndex = 7;
            C_Button.Text = "C";
            C_Button.UseVisualStyleBackColor = true;
            C_Button.Click += C_Button_Click;
            // 
            // CE_Button
            // 
            CE_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CE_Button.AutoSize = true;
            CE_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CE_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CE_Button.Location = new Point(85, 79);
            CE_Button.Margin = new Padding(3, 4, 3, 4);
            CE_Button.Name = "CE_Button";
            CE_Button.Size = new Size(76, 67);
            CE_Button.TabIndex = 6;
            CE_Button.Text = "CE";
            CE_Button.UseVisualStyleBackColor = true;
            CE_Button.Click += CE_Button_Click;
            // 
            // Backspace_Button
            // 
            Backspace_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Backspace_Button.AutoSize = true;
            Backspace_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Backspace_Button.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Backspace_Button.Location = new Point(3, 79);
            Backspace_Button.Margin = new Padding(3, 4, 3, 4);
            Backspace_Button.Name = "Backspace_Button";
            Backspace_Button.Size = new Size(76, 67);
            Backspace_Button.TabIndex = 5;
            Backspace_Button.Text = "🠄";
            Backspace_Button.UseVisualStyleBackColor = true;
            Backspace_Button.Click += Backspace_Button_Click;
            // 
            // MMinus_Button
            // 
            MMinus_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MMinus_Button.AutoSize = true;
            MMinus_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MMinus_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MMinus_Button.Location = new Point(331, 4);
            MMinus_Button.Margin = new Padding(3, 4, 3, 4);
            MMinus_Button.Name = "MMinus_Button";
            MMinus_Button.Size = new Size(77, 67);
            MMinus_Button.TabIndex = 4;
            MMinus_Button.Text = "M-";
            MMinus_Button.UseVisualStyleBackColor = true;
            MMinus_Button.Click += MMinus_Button_Click;
            // 
            // MPlus_Button
            // 
            MPlus_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MPlus_Button.AutoSize = true;
            MPlus_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MPlus_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MPlus_Button.Location = new Point(249, 4);
            MPlus_Button.Margin = new Padding(3, 4, 3, 4);
            MPlus_Button.Name = "MPlus_Button";
            MPlus_Button.Size = new Size(76, 67);
            MPlus_Button.TabIndex = 3;
            MPlus_Button.Text = "M+";
            MPlus_Button.UseVisualStyleBackColor = true;
            MPlus_Button.Click += MPlus_Button_Click;
            // 
            // MS_Button
            // 
            MS_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MS_Button.AutoSize = true;
            MS_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MS_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MS_Button.Location = new Point(167, 4);
            MS_Button.Margin = new Padding(3, 4, 3, 4);
            MS_Button.Name = "MS_Button";
            MS_Button.Size = new Size(76, 67);
            MS_Button.TabIndex = 2;
            MS_Button.Text = "MS";
            MS_Button.UseVisualStyleBackColor = true;
            MS_Button.Click += MS_Button_Click;
            // 
            // MR_Button
            // 
            MR_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MR_Button.AutoSize = true;
            MR_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MR_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MR_Button.Location = new Point(85, 4);
            MR_Button.Margin = new Padding(3, 4, 3, 4);
            MR_Button.Name = "MR_Button";
            MR_Button.Size = new Size(76, 67);
            MR_Button.TabIndex = 1;
            MR_Button.Text = "MR";
            MR_Button.UseVisualStyleBackColor = true;
            MR_Button.Click += MR_Button_Click;
            // 
            // MC_Button
            // 
            MC_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MC_Button.AutoSize = true;
            MC_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MC_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MC_Button.Location = new Point(3, 4);
            MC_Button.Margin = new Padding(3, 4, 3, 4);
            MC_Button.Name = "MC_Button";
            MC_Button.Size = new Size(76, 67);
            MC_Button.TabIndex = 0;
            MC_Button.Text = "MC";
            MC_Button.UseVisualStyleBackColor = true;
            MC_Button.Click += MC_Button_Click;
            // 
            // buttonLayoutGrid
            // 
            buttonLayoutGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonLayoutGrid.AutoSize = true;
            buttonLayoutGrid.ColumnCount = 5;
            buttonLayoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonLayoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonLayoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonLayoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonLayoutGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonLayoutGrid.Controls.Add(MC_Button, 0, 0);
            buttonLayoutGrid.Controls.Add(MR_Button, 1, 0);
            buttonLayoutGrid.Controls.Add(MS_Button, 2, 0);
            buttonLayoutGrid.Controls.Add(MPlus_Button, 3, 0);
            buttonLayoutGrid.Controls.Add(MMinus_Button, 4, 0);
            buttonLayoutGrid.Controls.Add(Backspace_Button, 0, 1);
            buttonLayoutGrid.Controls.Add(CE_Button, 1, 1);
            buttonLayoutGrid.Controls.Add(C_Button, 2, 1);
            buttonLayoutGrid.Controls.Add(ChangeSign_Button, 3, 1);
            buttonLayoutGrid.Controls.Add(Sqrt_Button, 4, 1);
            buttonLayoutGrid.Controls.Add(Seven_Button, 0, 2);
            buttonLayoutGrid.Controls.Add(Eight_Button, 1, 2);
            buttonLayoutGrid.Controls.Add(Nine_Button, 2, 2);
            buttonLayoutGrid.Controls.Add(Divide_Button, 3, 2);
            buttonLayoutGrid.Controls.Add(Percentage_Button, 4, 2);
            buttonLayoutGrid.Controls.Add(Four_Button, 0, 3);
            buttonLayoutGrid.Controls.Add(Five_Button, 1, 3);
            buttonLayoutGrid.Controls.Add(Six_Button, 2, 3);
            buttonLayoutGrid.Controls.Add(Multiply_Button, 3, 3);
            buttonLayoutGrid.Controls.Add(Reciprocal_Button, 4, 3);
            buttonLayoutGrid.Controls.Add(One_Button, 0, 4);
            buttonLayoutGrid.Controls.Add(Two_Button, 1, 4);
            buttonLayoutGrid.Controls.Add(Three_Button, 2, 4);
            buttonLayoutGrid.Controls.Add(Minus_Button, 3, 4);
            buttonLayoutGrid.Controls.Add(Equals_Button, 4, 4);
            buttonLayoutGrid.Controls.Add(Zero_Button, 0, 5);
            buttonLayoutGrid.Controls.Add(Decimal_Button, 2, 5);
            buttonLayoutGrid.Controls.Add(Add_Button, 3, 5);
            buttonLayoutGrid.Location = new Point(14, 147);
            buttonLayoutGrid.Margin = new Padding(3, 4, 3, 4);
            buttonLayoutGrid.Name = "buttonLayoutGrid";
            buttonLayoutGrid.RowCount = 6;
            buttonLayoutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666622F));
            buttonLayoutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            buttonLayoutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            buttonLayoutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            buttonLayoutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            buttonLayoutGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            buttonLayoutGrid.Size = new Size(411, 452);
            buttonLayoutGrid.TabIndex = 1;
            // 
            // Four_Button
            // 
            Four_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Four_Button.AutoSize = true;
            Four_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Four_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Four_Button.Location = new Point(3, 229);
            Four_Button.Margin = new Padding(3, 4, 3, 4);
            Four_Button.Name = "Four_Button";
            Four_Button.Size = new Size(76, 67);
            Four_Button.TabIndex = 15;
            Four_Button.Text = "4";
            Four_Button.UseVisualStyleBackColor = true;
            Four_Button.Click += Digits_Buttons_Click;
            // 
            // Five_Button
            // 
            Five_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Five_Button.AutoSize = true;
            Five_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Five_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Five_Button.Location = new Point(85, 229);
            Five_Button.Margin = new Padding(3, 4, 3, 4);
            Five_Button.Name = "Five_Button";
            Five_Button.Size = new Size(76, 67);
            Five_Button.TabIndex = 16;
            Five_Button.Text = "5";
            Five_Button.UseVisualStyleBackColor = true;
            Five_Button.Click += Digits_Buttons_Click;
            // 
            // Six_Button
            // 
            Six_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Six_Button.AutoSize = true;
            Six_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Six_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Six_Button.Location = new Point(167, 229);
            Six_Button.Margin = new Padding(3, 4, 3, 4);
            Six_Button.Name = "Six_Button";
            Six_Button.Size = new Size(76, 67);
            Six_Button.TabIndex = 17;
            Six_Button.Text = "6";
            Six_Button.UseVisualStyleBackColor = true;
            Six_Button.Click += Digits_Buttons_Click;
            // 
            // Multiply_Button
            // 
            Multiply_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Multiply_Button.AutoSize = true;
            Multiply_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Multiply_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Multiply_Button.Location = new Point(249, 229);
            Multiply_Button.Margin = new Padding(3, 4, 3, 4);
            Multiply_Button.Name = "Multiply_Button";
            Multiply_Button.Size = new Size(76, 67);
            Multiply_Button.TabIndex = 18;
            Multiply_Button.Text = "x";
            Multiply_Button.UseVisualStyleBackColor = true;
            Multiply_Button.Click += Multiply_Button_Click;
            // 
            // Reciprocal_Button
            // 
            Reciprocal_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Reciprocal_Button.AutoSize = true;
            Reciprocal_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Reciprocal_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Reciprocal_Button.Location = new Point(331, 229);
            Reciprocal_Button.Margin = new Padding(3, 4, 3, 4);
            Reciprocal_Button.Name = "Reciprocal_Button";
            Reciprocal_Button.Size = new Size(77, 67);
            Reciprocal_Button.TabIndex = 19;
            Reciprocal_Button.Text = "⅟𝑥";
            Reciprocal_Button.UseVisualStyleBackColor = true;
            Reciprocal_Button.Click += Reciprocal_Button_Click;
            // 
            // One_Button
            // 
            One_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            One_Button.AutoSize = true;
            One_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            One_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            One_Button.Location = new Point(3, 304);
            One_Button.Margin = new Padding(3, 4, 3, 4);
            One_Button.Name = "One_Button";
            One_Button.Size = new Size(76, 67);
            One_Button.TabIndex = 20;
            One_Button.Text = "1";
            One_Button.UseVisualStyleBackColor = true;
            One_Button.Click += Digits_Buttons_Click;
            // 
            // Two_Button
            // 
            Two_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Two_Button.AutoSize = true;
            Two_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Two_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Two_Button.Location = new Point(85, 304);
            Two_Button.Margin = new Padding(3, 4, 3, 4);
            Two_Button.Name = "Two_Button";
            Two_Button.Size = new Size(76, 67);
            Two_Button.TabIndex = 21;
            Two_Button.Text = "2";
            Two_Button.UseVisualStyleBackColor = true;
            Two_Button.Click += Digits_Buttons_Click;
            // 
            // Three_Button
            // 
            Three_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Three_Button.AutoSize = true;
            Three_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Three_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Three_Button.Location = new Point(167, 304);
            Three_Button.Margin = new Padding(3, 4, 3, 4);
            Three_Button.Name = "Three_Button";
            Three_Button.Size = new Size(76, 67);
            Three_Button.TabIndex = 22;
            Three_Button.Text = "3";
            Three_Button.UseVisualStyleBackColor = true;
            Three_Button.Click += Digits_Buttons_Click;
            // 
            // Minus_Button
            // 
            Minus_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Minus_Button.AutoSize = true;
            Minus_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Minus_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Minus_Button.Location = new Point(249, 304);
            Minus_Button.Margin = new Padding(3, 4, 3, 4);
            Minus_Button.Name = "Minus_Button";
            Minus_Button.Size = new Size(76, 67);
            Minus_Button.TabIndex = 23;
            Minus_Button.Text = "-";
            Minus_Button.UseVisualStyleBackColor = true;
            Minus_Button.Click += Minus_Button_Click;
            // 
            // Equals_Button
            // 
            Equals_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Equals_Button.AutoSize = true;
            Equals_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Equals_Button.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Equals_Button.Location = new Point(331, 304);
            Equals_Button.Margin = new Padding(3, 4, 3, 4);
            Equals_Button.Name = "Equals_Button";
            buttonLayoutGrid.SetRowSpan(Equals_Button, 2);
            Equals_Button.Size = new Size(77, 144);
            Equals_Button.TabIndex = 24;
            Equals_Button.Text = "=";
            Equals_Button.UseVisualStyleBackColor = true;
            Equals_Button.Click += Equals_Button_Click;
            // 
            // Zero_Button
            // 
            Zero_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Zero_Button.AutoSize = true;
            Zero_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonLayoutGrid.SetColumnSpan(Zero_Button, 2);
            Zero_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Zero_Button.Location = new Point(3, 379);
            Zero_Button.Margin = new Padding(3, 4, 3, 4);
            Zero_Button.Name = "Zero_Button";
            Zero_Button.Size = new Size(158, 69);
            Zero_Button.TabIndex = 25;
            Zero_Button.Text = "0";
            Zero_Button.UseVisualStyleBackColor = true;
            Zero_Button.Click += Digits_Buttons_Click;
            // 
            // Decimal_Button
            // 
            Decimal_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Decimal_Button.AutoSize = true;
            Decimal_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Decimal_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Decimal_Button.Location = new Point(167, 379);
            Decimal_Button.Margin = new Padding(3, 4, 3, 4);
            Decimal_Button.Name = "Decimal_Button";
            Decimal_Button.Size = new Size(76, 69);
            Decimal_Button.TabIndex = 26;
            Decimal_Button.Text = ".";
            Decimal_Button.UseVisualStyleBackColor = true;
            Decimal_Button.Click += Decimal_Button_Click;
            // 
            // Add_Button
            // 
            Add_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Add_Button.AutoSize = true;
            Add_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Add_Button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Add_Button.Location = new Point(249, 379);
            Add_Button.Margin = new Padding(3, 4, 3, 4);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(76, 69);
            Add_Button.TabIndex = 27;
            Add_Button.Text = "+";
            Add_Button.UseVisualStyleBackColor = true;
            Add_Button.Click += Add_Button_Click;
            // 
            // CalcAnswerTextBox
            // 
            CalcAnswerTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CalcAnswerTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CalcAnswerTextBox.Location = new Point(14, 22);
            CalcAnswerTextBox.Margin = new Padding(3, 4, 3, 4);
            CalcAnswerTextBox.Name = "CalcAnswerTextBox";
            CalcAnswerTextBox.ReadOnly = true;
            CalcAnswerTextBox.Size = new Size(411, 34);
            CalcAnswerTextBox.TabIndex = 2;
            CalcAnswerTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 615);
            Controls.Add(CalcAnswerTextBox);
            Controls.Add(buttonLayoutGrid);
            Controls.Add(CalcOutputTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(455, 651);
            Name = "CalculatorForm";
            Text = "Calculator";
            buttonLayoutGrid.ResumeLayout(false);
            buttonLayoutGrid.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CalcOutputTextBox;
        private Button Percentage_Button;
        private Button Divide_Button;
        private Button Nine_Button;
        private Button Eight_Button;
        private Button Seven_Button;
        private Button Sqrt_Button;
        private Button ChangeSign_Button;
        private Button C_Button;
        private Button CE_Button;
        private Button Backspace_Button;
        private Button MMinus_Button;
        private Button MPlus_Button;
        private Button MS_Button;
        private Button MR_Button;
        private Button MC_Button;
        private TableLayoutPanel buttonLayoutGrid;
        private Button Four_Button;
        private Button Five_Button;
        private Button Six_Button;
        private Button Multiply_Button;
        private Button Reciprocal_Button;
        private Button One_Button;
        private Button Two_Button;
        private Button Three_Button;
        private Button Minus_Button;
        private Button Equals_Button;
        private Button Zero_Button;
        private Button Decimal_Button;
        private Button Add_Button;
        private TextBox CalcAnswerTextBox;
    }
}