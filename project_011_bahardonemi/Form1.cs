namespace project_011_bahardonemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void icoCloseBtn_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            //...
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (inputNumbers.Text == "0") { inputNumbers.Text = ""; }
            inputNumbers.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (inputNumbers.Text == "0") { inputNumbers.Text = ""; }
            inputNumbers.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (inputNumbers.Text == "0") { inputNumbers.Text = ""; }
            inputNumbers.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (inputNumbers.Text == "0") { inputNumbers.Text = ""; }
            inputNumbers.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (inputNumbers.Text == "0") { inputNumbers.Text = ""; }
            inputNumbers.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (inputNumbers.Text == "0") { inputNumbers.Text = ""; }
            inputNumbers.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (inputNumbers.Text == "0") { inputNumbers.Text = ""; }
            inputNumbers.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (inputNumbers.Text == "0") { inputNumbers.Text = ""; }
            inputNumbers.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (inputNumbers.Text == "0") { inputNumbers.Text = ""; }
            inputNumbers.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (inputNumbers.Text == "0") { inputNumbers.Text = ""; }
            inputNumbers.Text += "9";
        }


        #region Ýþlem Simgleri

        //Simge olup olmadýðýnýn kontrolü
        private int islemKontrol = 0;
        //Toplama Ýþlemi Simgesi Ekleme
        private void toplama_Click(object sender, EventArgs e)
        {
            if (islemKontrol == 0 || inputNumbers.Text.Length != 1)
            {
                if (inputNumbers.Text != "0")
                {
                    beforeInputNumbers.Text += "+" + inputNumbers.Text;
                    inputNumbers.Text = "0";
                }
            }
            islemKontrol++;
        }
        //Çýkarma Ýþlemi Simgesi Ekleme
        private void cikarma_Click(object sender, EventArgs e)
        {
            if (islemKontrol == 0)
            {
                if (inputNumbers.Text != "0")
                {
                    inputNumbers.Text = "";
                    inputNumbers.Text += "-";
                }
            }
            islemKontrol++;
        }
        //Çarpma Ýþlemi Simgesi Ekleme
        private void carpma_Click(object sender, EventArgs e)
        {
            if (islemKontrol == 0)
            {
                if (inputNumbers.Text != "0")
                {
                    inputNumbers.Text = "";
                    inputNumbers.Text += "*";
                }

            }
            islemKontrol++;
        }
        //Bölme Ýþlemi Simgesi Ekleme
        private void bolme_Click(object sender, EventArgs e)
        {
            if (islemKontrol == 0)
            {
                if (inputNumbers.Text != "0")
                {
                    inputNumbers.Text = "";
                    inputNumbers.Text += "/";
                }

            }
            islemKontrol++;
        }
        private void mod_Click(object sender, EventArgs e)
        {
            if (islemKontrol == 0)
            {
                if (inputNumbers.Text != "0")
                {
                    inputNumbers.Text = "";
                    inputNumbers.Text += "%";
                }

            }
            islemKontrol++;
        }

        #endregion
        private void delAll_Click(object sender, EventArgs e)
        {
            inputNumbers.Text = "0";
        }

        private void sonucHesapla_Click(object sender, EventArgs e)
        {
            beforeInputNumbers.Text += inputNumbers.Text;
            string input = beforeInputNumbers.Text;
            char[] operators = { '+', '-', '*', '/', '%' };

            char op = ' ';
            foreach (char c in operators)
            {
                if (input.Contains(c))
                {
                    op = c;
                    break;
                }
            }

            if (op != ' ')
            {
                string[] numbers = input.Split(op);
                double num1 = double.Parse(numbers[0]);
                double num2 = double.Parse(numbers[1]);
                double num3 = double.Parse(numbers[2]);
                double num4 = double.Parse(numbers[3]);
                double num5 = double.Parse(numbers[4]);
                double num6 = double.Parse(numbers[5]);
                double result = 0;

                switch (op)
                {
                    case '+':
                        result = num1 + num2 + num3 + num4;
                        break;
                    case '-':
                        result = num1 - num2 - num3 - num4;
                        break;
                    case '*':
                        result = num1 * num2 * num3 * num4;
                        break;
                    case '/':
                        result = num1 / num2 / num3 / num4;
                        break;
                    case '%':
                        result = num1 % num2;
                        break;
                }

                inputNumbers.Text = "" + result;
                islemKontrol = 0;
            }
        }
        #region Dragable App
        private bool mouseDown;
        private Point lastLocation;
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void label1_MouseUp(object sender, MouseEventArgs e){
            mouseDown = false;
        }
        #endregion
    }
}
