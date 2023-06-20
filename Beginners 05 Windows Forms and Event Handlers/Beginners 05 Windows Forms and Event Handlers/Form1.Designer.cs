namespace Beginners_05_Windows_Forms_and_Event_Handlers
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
            UserInputText = new TextBox();
            CalculatorResulttext = new Label();
            ButtonsPanel = new TableLayoutPanel();
            EqualsButton = new Button();
            DotButton = new Button();
            ZeroButton = new Button();
            PlusButton = new Button();
            ThreeButton = new Button();
            TwoButton = new Button();
            OneButton = new Button();
            RestButton = new Button();
            SixButton = new Button();
            FiveButton = new Button();
            FourButton = new Button();
            MultiplyButton = new Button();
            NineButton = new Button();
            EightButton = new Button();
            SevenButton = new Button();
            PorcentajeButton = new Button();
            DelButton = new Button();
            CEButton = new Button();
            ButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UserInputText
            // 
            UserInputText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UserInputText.Location = new Point(18, 12);
            UserInputText.Name = "UserInputText";
            UserInputText.Size = new Size(275, 23);
            UserInputText.TabIndex = 0;
            // 
            // CalculatorResulttext
            // 
            CalculatorResulttext.Location = new Point(18, 38);
            CalculatorResulttext.Name = "CalculatorResulttext";
            CalculatorResulttext.Size = new Size(412, 25);
            CalculatorResulttext.TabIndex = 1;
            CalculatorResulttext.Text = "Por favor haz una operación y marca Enter o =";
            CalculatorResulttext.Click += CalculatorResulttext_Click;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonsPanel.ColumnCount = 4;
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsPanel.Controls.Add(EqualsButton, 3, 4);
            ButtonsPanel.Controls.Add(DotButton, 2, 4);
            ButtonsPanel.Controls.Add(ZeroButton, 1, 4);
            ButtonsPanel.Controls.Add(PlusButton, 3, 3);
            ButtonsPanel.Controls.Add(ThreeButton, 2, 3);
            ButtonsPanel.Controls.Add(TwoButton, 1, 3);
            ButtonsPanel.Controls.Add(OneButton, 0, 3);
            ButtonsPanel.Controls.Add(RestButton, 3, 2);
            ButtonsPanel.Controls.Add(SixButton, 2, 2);
            ButtonsPanel.Controls.Add(FiveButton, 1, 2);
            ButtonsPanel.Controls.Add(FourButton, 0, 2);
            ButtonsPanel.Controls.Add(MultiplyButton, 3, 1);
            ButtonsPanel.Controls.Add(NineButton, 2, 1);
            ButtonsPanel.Controls.Add(EightButton, 1, 1);
            ButtonsPanel.Controls.Add(SevenButton, 0, 1);
            ButtonsPanel.Controls.Add(PorcentajeButton, 3, 0);
            ButtonsPanel.Controls.Add(DelButton, 2, 0);
            ButtonsPanel.Controls.Add(CEButton, 0, 0);
            ButtonsPanel.Location = new Point(18, 94);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.RowCount = 5;
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            ButtonsPanel.Size = new Size(275, 240);
            ButtonsPanel.TabIndex = 2;
            // 
            // EqualsButton
            // 
            EqualsButton.Dock = DockStyle.Fill;
            EqualsButton.Location = new Point(207, 195);
            EqualsButton.Name = "EqualsButton";
            EqualsButton.Size = new Size(65, 42);
            EqualsButton.TabIndex = 19;
            EqualsButton.Text = "=";
            EqualsButton.UseVisualStyleBackColor = true;
            // 
            // DotButton
            // 
            DotButton.Dock = DockStyle.Fill;
            DotButton.Location = new Point(139, 195);
            DotButton.Name = "DotButton";
            DotButton.Size = new Size(62, 42);
            DotButton.TabIndex = 18;
            DotButton.Text = ".";
            DotButton.UseVisualStyleBackColor = true;
            DotButton.Click += DotButton_Click;
            // 
            // ZeroButton
            // 
            ZeroButton.Dock = DockStyle.Fill;
            ZeroButton.Location = new Point(71, 195);
            ZeroButton.Name = "ZeroButton";
            ZeroButton.Size = new Size(62, 42);
            ZeroButton.TabIndex = 17;
            ZeroButton.Text = "0";
            ZeroButton.UseVisualStyleBackColor = true;
            ZeroButton.Click += ZeroButton_Click;
            // 
            // PlusButton
            // 
            PlusButton.Dock = DockStyle.Fill;
            PlusButton.Location = new Point(207, 147);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(65, 42);
            PlusButton.TabIndex = 15;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.Click += PlusButton_Click;
            // 
            // ThreeButton
            // 
            ThreeButton.Dock = DockStyle.Fill;
            ThreeButton.Location = new Point(139, 147);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(62, 42);
            ThreeButton.TabIndex = 14;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = true;
            ThreeButton.Click += ThreeButton_Click;
            // 
            // TwoButton
            // 
            TwoButton.Dock = DockStyle.Fill;
            TwoButton.Location = new Point(71, 147);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(62, 42);
            TwoButton.TabIndex = 13;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = true;
            TwoButton.Click += TwoButton_Click;
            // 
            // OneButton
            // 
            OneButton.Dock = DockStyle.Fill;
            OneButton.Location = new Point(3, 147);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(62, 42);
            OneButton.TabIndex = 12;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = true;
            OneButton.Click += OneButton_Click;
            // 
            // RestButton
            // 
            RestButton.Dock = DockStyle.Fill;
            RestButton.Location = new Point(207, 99);
            RestButton.Name = "RestButton";
            RestButton.Size = new Size(65, 42);
            RestButton.TabIndex = 11;
            RestButton.Text = "-";
            RestButton.UseVisualStyleBackColor = true;
            RestButton.Click += RestButton_Click;
            // 
            // SixButton
            // 
            SixButton.Dock = DockStyle.Fill;
            SixButton.Location = new Point(139, 99);
            SixButton.Name = "SixButton";
            SixButton.Size = new Size(62, 42);
            SixButton.TabIndex = 10;
            SixButton.Text = "6";
            SixButton.UseVisualStyleBackColor = true;
            SixButton.Click += SixButton_Click;
            // 
            // FiveButton
            // 
            FiveButton.Dock = DockStyle.Fill;
            FiveButton.Location = new Point(71, 99);
            FiveButton.Name = "FiveButton";
            FiveButton.Size = new Size(62, 42);
            FiveButton.TabIndex = 9;
            FiveButton.Text = "5";
            FiveButton.UseVisualStyleBackColor = true;
            FiveButton.Click += FiveButton_Click;
            // 
            // FourButton
            // 
            FourButton.Dock = DockStyle.Fill;
            FourButton.Location = new Point(3, 99);
            FourButton.Name = "FourButton";
            FourButton.Size = new Size(62, 42);
            FourButton.TabIndex = 8;
            FourButton.Text = "4";
            FourButton.UseVisualStyleBackColor = true;
            FourButton.Click += FourButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.Dock = DockStyle.Fill;
            MultiplyButton.Location = new Point(207, 51);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(65, 42);
            MultiplyButton.TabIndex = 7;
            MultiplyButton.Text = "x";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // NineButton
            // 
            NineButton.Dock = DockStyle.Fill;
            NineButton.Location = new Point(139, 51);
            NineButton.Name = "NineButton";
            NineButton.Size = new Size(62, 42);
            NineButton.TabIndex = 6;
            NineButton.Text = "9";
            NineButton.UseVisualStyleBackColor = true;
            NineButton.Click += NineButton_Click;
            // 
            // EightButton
            // 
            EightButton.Dock = DockStyle.Fill;
            EightButton.Location = new Point(71, 51);
            EightButton.Name = "EightButton";
            EightButton.Size = new Size(62, 42);
            EightButton.TabIndex = 5;
            EightButton.Text = "8";
            EightButton.UseVisualStyleBackColor = true;
            EightButton.Click += EightButton_Click;
            // 
            // SevenButton
            // 
            SevenButton.Dock = DockStyle.Fill;
            SevenButton.Location = new Point(3, 51);
            SevenButton.Name = "SevenButton";
            SevenButton.Size = new Size(62, 42);
            SevenButton.TabIndex = 4;
            SevenButton.Text = "7";
            SevenButton.UseVisualStyleBackColor = true;
            SevenButton.Click += SevenButton_Click;
            // 
            // PorcentajeButton
            // 
            PorcentajeButton.Dock = DockStyle.Fill;
            PorcentajeButton.Location = new Point(207, 3);
            PorcentajeButton.Name = "PorcentajeButton";
            PorcentajeButton.Size = new Size(65, 42);
            PorcentajeButton.TabIndex = 3;
            PorcentajeButton.Text = "%";
            PorcentajeButton.UseVisualStyleBackColor = true;
            PorcentajeButton.Click += PorcentajeButton_Click;
            // 
            // DelButton
            // 
            DelButton.Dock = DockStyle.Fill;
            DelButton.Location = new Point(139, 3);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(62, 42);
            DelButton.TabIndex = 2;
            DelButton.Text = "DEL";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DelButton_Click;
            // 
            // CEButton
            // 
            CEButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CEButton.Location = new Point(3, 3);
            CEButton.Name = "CEButton";
            CEButton.Size = new Size(62, 42);
            CEButton.TabIndex = 0;
            CEButton.Text = "CE";
            CEButton.UseVisualStyleBackColor = true;
            CEButton.Click += CEButton_Click;
            // 
            // Form1
            // 
            AcceptButton = EqualsButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CEButton;
            ClientSize = new Size(305, 346);
            Controls.Add(ButtonsPanel);
            Controls.Add(CalculatorResulttext);
            Controls.Add(UserInputText);
            MinimumSize = new Size(321, 385);
            Name = "Form1";
            Text = "Calculadora Basica";
            Load += Form1_Load;
            ButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserInputText;
        private Label CalculatorResulttext;
        private TableLayoutPanel ButtonsPanel;
        private Button CEButton;
        private Button EqualsButton;
        private Button PlusButton;
        private Button DelButton;
        private Button RestButton;
        private Button PorcentajeButton;
        private Button OneButton;
        private Button TwoButton;
        private Button ThreeButton;
        private Button FourButton;
        private Button FiveButton;
        private Button SixButton;
        private Button SevenButton;
        private Button EightButton;
        private Button NineButton;
        private Button DotButton;
        private Button ZeroButton;
        private Button MultiplyButton;
    }
}