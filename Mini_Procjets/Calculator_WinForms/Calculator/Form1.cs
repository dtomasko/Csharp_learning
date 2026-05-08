
using System.Data;


namespace Calculator
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";//whole math expresion thats typed
        private bool equalsPressed = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void button_click(object sender, EventArgs e)//for every btn except CE, CLEAR and =
        {
            Button btn = (Button)sender;
            string btnText = btn.Text;


            if (btnText == "√")
            {

                if (double.TryParse(currentCalculation, out double num))
                {
                    if (num < 0)
                    {
                        txtOutput.Text = "ERROR";
                        currentCalculation = "";
                    }
                    else
                    {
                        double sqrtResult = Math.Sqrt(num);
                        currentCalculation = sqrtResult.ToString();
                        txtOutput.Text = currentCalculation;
                    }

                    equalsPressed = true; //treat sqrt like = 
                   
                }
                return;
            }


                if (equalsPressed)
                {
                    // If an operator is pressed keep the result and continue
                    if (IsOperatorOrSpecial(btnText)) equalsPressed = false;
                    // if digit, dot, or () start new expresion
                    else
                    {
                        currentCalculation = "";
                        equalsPressed = false;
                    }
                }

             
                currentCalculation += btnText;
                txtOutput.Text = currentCalculation;
            }



        private void equals_clicked(object sender, EventArgs e)
        {
            string expresion = currentCalculation;

            try
            {

                var result = new DataTable().Compute(expresion, null);

                double dblResult = Convert.ToDouble(result);
                


                    if (double.IsInfinity(dblResult)||double.IsNaN(dblResult))//if u try to divide int and 0 with 0
                    {
                        txtOutput.Text = "Can't divide by 0";
                        currentCalculation = "";
                        equalsPressed = false;
                        return;
                    }
                

                string StrResult = dblResult.ToString(); 

                txtOutput.Text = StrResult;
                currentCalculation = StrResult;
                equalsPressed = true;
            }
            catch (DivideByZeroException)//if u try to divide float with 0
            {
                txtOutput.Text = "Cant't divide by 0";
                currentCalculation = "";
                equalsPressed = false;

            }
            catch
            {
               
                txtOutput.Text = "ERROR";
                currentCalculation = "";
                equalsPressed = false;

            }
        }

        private void CLEAR_clicked(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            currentCalculation = "";
            equalsPressed = false;
        }
        private void CE_clicked(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            { 
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            txtOutput.Text = currentCalculation;
        }
        private bool IsOperatorOrSpecial(string text)//only these operators are allowed to continue after =
        {
            
            return text == "+" || text == "-" || text == "*" || text == "/";
        }
        
        
    }
}