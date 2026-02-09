namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {

        private readonly ICalculator calculator;
       

        public MainPage()
        {
            InitializeComponent();

            calculator = new CalculatorMath();
        }


        public void OnAddClicked(object sender, EventArgs e)
        {
            double n1;
            double n2;

            bool isFirstValid = double.TryParse(Input1.Text, out n1);
            bool isSecondValid = double.TryParse(Input2.Text, out n2);

            if (isFirstValid && isSecondValid)
            {
               
                double result = calculator.Add(n1, n2);
                ResultLabel.Text = $"Result: {n1} + {n2} = {result}";
            }
            else
            {
                ResultLabel.Text = "Error: Please enter valid numbers only.";
            }
        }

        public void OnSubtractClicked(object sender, EventArgs e)
        {
            double n1;
            double n2;

            bool isFirstValid = double.TryParse(Input1.Text, out n1);
            bool isSecondValid = double.TryParse(Input2.Text, out n2);

            if (isFirstValid && isSecondValid)
            {

                double result = calculator.Subtract(n1, n2);
                ResultLabel.Text = $"Result: {n1} - {n2} = {result}";
            }
            else
            {
                ResultLabel.Text = "Error: Please enter valid numbers only.";
            }

        }

        public void OnMultiplyClicked(object sender, EventArgs e)
        {
            double n1;
            double n2;

            bool isFirstValid = double.TryParse(Input1.Text, out n1);
            bool isSecondValid = double.TryParse(Input2.Text, out n2);

            if (isFirstValid && isSecondValid)
            {

                double result = calculator.Multiply(n1, n2);
                ResultLabel.Text = $"Result: {n1} x {n2} = {result}";
            }
            else
            {
                ResultLabel.Text = "Error: Please enter valid numbers only.";
            }

        }

        public void OnDivideClicked(object sender, EventArgs e)
        {
            double n1;
            double n2;

            bool isFirstValid = double.TryParse(Input1.Text, out n1);
            bool isSecondValid = double.TryParse(Input2.Text, out n2);

            if (isFirstValid && isSecondValid)
            {
                try
                {
                    double result = calculator.Divide(n1, n2);
                    ResultLabel.Text = $"Result: {n1} / {n2} = {result}";
                }catch (Exception ex)
                {
                    ResultLabel.Text = "Error: " + ex.Message;
                }
                
            }

            else
            {
                ResultLabel.Text = "Error: Please enter valid numbers only.";
            }

        }


    }
}
