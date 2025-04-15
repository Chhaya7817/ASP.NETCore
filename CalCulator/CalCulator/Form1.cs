namespace CalCulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1;
        int num2;
        string operation=null;
        int res;
        string calTotal;

        private void button1_Click(object sender, EventArgs e)
        {
            isZero();
            Result.Text = Result.Text + button1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void isZero()
        {
            if (Result.Text.Equals("0")) Result.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            isZero();
            Result.Text = Result.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isZero();
            Result.Text = Result.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isZero();
            Result.Text = Result.Text + "3";
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (isInputBoxEmpty()) return;
            operation = "*";
            num1 = int.Parse(Result.Text);
            Result.Clear();
        }

        private bool isInputBoxEmpty()
        {
            if (Result.Text.Equals("")) return true;
            return false;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            isZero();
            Result.Text = Result.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isZero();
            Result.Text = Result.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isZero();
            Result.Text = Result.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            isZero();
            Result.Text = Result.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            isZero();
            Result.Text = Result.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            isZero();
            Result.Text = Result.Text + "0";
        }
        private void sub_Click(object sender, EventArgs e)
        {
            if (isInputBoxEmpty()) return;
            operation = "-";
            num1 = int.Parse(Result.Text);
            Result.Clear();

        }
        private bool isOperationExist()
        {
            //return operation.Equals("+") || operation.Equals("-") || operation.Equals("*") || operation.Equals("/");
            return operation!=null;
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (isInputBoxEmpty()) return;
            //if (!isOperationExist())
            //{
            //    equal_Click(sender, e);
            //    operation = "+";
            //    return;
            //}
            operation = "+";
            num1 = int.Parse(Result.Text);
            Result.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (isInputBoxEmpty()) return;
            operation = "/";
            num1 = int.Parse(Result.Text);
            Result.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Console.WriteLine(num1);
            try
            {
                num2 = int.Parse(Result.Text);
            }
            catch(FormatException e1) {
                return;
            };
            switch(operation)
            {
                case "+": res = num1 + num2;
                    break;
                case "-": res = num1 - num2;
                    break;
                case "*": res= num1 * num2;
                    break;
                case "/": res= num1 / num2;
                    break;
               
            }
            Result.Clear();
            num1 = res;
            Result.Text = res.ToString();
            operation = null;
            Console.ReadLine();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Result.Clear();
            Result.Text = "0";
            num1 = 0;
            num2 = 0;
            operation = "";
            res = 0;
        }
    }
}