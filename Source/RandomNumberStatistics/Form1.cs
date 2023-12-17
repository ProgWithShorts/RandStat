using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms.DataVisualization.Charting;
namespace RandomNumberStatistics
{
    public partial class RandStat : Form
    {
        public RandStat()
        {



            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void randNumRangeup_TextChanged(object sender, EventArgs e)
        {

        }
        public bool IsNumeric(string text)
        {
            foreach (char character in text)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsNumeric(tryInputBox.Text) && 
                IsNumeric(randNumRangedown.Text) && 
                IsNumeric(randNumRangeup.Text) && 
                IsNumeric(textBox1.Text) && 
                (textBox1.Text) != "")
            {

                if (Convert.ToInt32(tryInputBox.Text) <= 300 &&
                    Convert.ToInt32(randNumRangedown.Text) >= 0 &&
                    Convert.ToInt32(randNumRangeup.Text) <= 1000)
                {
                    label2.Text = "";
                    int iterator = 0;
                    ArrayList randNumbers = new ArrayList();
                    while (iterator < Convert.ToInt32(tryInputBox.Text))
                    {


                        Random random = new Random();
                        randNumbers.Add(random.Next(Convert.ToInt32(randNumRangedown.Text), (Convert.ToInt32(randNumRangeup.Text))+1));
                        label2.Text += Convert.ToString(randNumbers[iterator]);
                        label2.Text += " | ";

                        //
                        
                        //
                        iterator++;

                    }

                    int ExpectedValue = 0;

                    if (IsNumeric(textBox1.Text))
                    {

                        if (Convert.ToInt32(textBox1.Text) >= Convert.ToInt32(randNumRangedown.Text) &&
                            Convert.ToInt32(textBox1.Text) <= Convert.ToInt32(randNumRangeup.Text))
                        {
                            ExpectedValue = Convert.ToInt32(textBox1.Text);
                            int countForExpectedValue = 0;
                            foreach (int item in randNumbers)
                            {
                                if (item == ExpectedValue) { countForExpectedValue++; }
                            }


                            label3.Text = $"Real Probability - {Convert.ToSingle(countForExpectedValue) / Convert.ToSingle(tryInputBox.Text)}" +
                                          $"\nExpected Probability - {1 / Convert.ToSingle(randNumRangeup.Text)}";
                        }
                        else
                        {
                            label3.Text = "ERROR!!!";
                        }

                    }
                    else
                    {
                        label3.Text = "ERROR!!!";
                    }



                }
                else
                {
                    label3.Text = "ERROR!!!";
                }


            }
            else
            {
                label3.Text = "ERROR!!!";

            }
        }
    }
}
