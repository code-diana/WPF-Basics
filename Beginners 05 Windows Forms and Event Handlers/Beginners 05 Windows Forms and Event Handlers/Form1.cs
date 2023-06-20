namespace Beginners_05_Windows_Forms_and_Event_Handlers
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Basic calculator
        /// </summary>

        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenid@ a la calculadora");
        }

        #region Buttons
        private void CEButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("CE Button");
            this.UserInputText.Text = String.Empty;
            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (this.UserInputText.TextLength > this.UserInputText.SelectionStart + 1)
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            FocusInputText();
        }
        #endregion

        #region Operaciones
        private void PorcentajeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
        }

        private void RestButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
        }
        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
        }
        #endregion

        #region Botones

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }


        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }



        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }
        #endregion

        #region Calcular
        private void CalculateEquation()
        {
            this.CalculatorResulttext.Text = ParseOperation();
            FocusInputText();
        }
        private void CalculatorResulttext_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }
        #endregion

        private string ParseOperation()
        {
            try
            {
                var input = this.UserInputText.Text;
                //quitar espacios
                input = input.Replace(" ", "");
                var operation = new Operation();
            }
            catch (Exception e)
            {
                return $"invalid equation...{e.Message}";
            }
        }
        private void FocusInputText()
        {
            //repair
            this.UserInputText.Focus();
        }

        private void InsertTextValue(string number)
        {
            //Arregla la selección completa del texto
            var selectionStart = this.UserInputText.SelectionStart;

            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, number);

            this.UserInputText.SelectionStart = selectionStart + number.Length;

            this.UserInputText.SelectionLength = 0;
        }


    }
}