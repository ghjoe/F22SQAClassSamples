namespace BMIExceptions
{
    public partial class Form1 : Form
    {
        private int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int height = Int32.Parse(heightTB.Text);
                int mass = Int32.Parse(weightTB.Text);
                double bmi = CalculateBMI(height, mass);

                bmiTB.Text = bmi.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "My BMI App");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "My BMI App");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "My BMI App");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "My BMI App");
            }
            finally
            {
                count++;
                countLbl.Text = count.ToString();
            }
        }

        private static double CalculateBMI(int height, int mass)
        {
            if (height <= 0)
                throw new ArgumentException("Height must be greater than zero");

            if (mass <= 0)
                throw new ArgumentException("Mass must be greater than zero");

            // no reason to do this other than to demonstrate safe coding practices
            if (height % 2 == 1)
              throw new ArgumentException("Height can't be odd for some strange reason");


            return mass * 703 / (height * height);
        }

        private void calculateBtn2_Click(object sender, EventArgs e)
        {
            int height = (int)heightNUD.Value;
            int mass = (int)massNUD.Value;

            try
            {
                double bmi = CalculateBMI(height, mass);
                bmiTB2.Text = bmi.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "MyBMI App"); }
            finally
            {
                count++;
                countLbl.Text = count.ToString();
            }

        }
    }
}