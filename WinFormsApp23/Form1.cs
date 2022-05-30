using System.Text.RegularExpressions;

namespace WinFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                label3.Text = "1.50";

            }
            if (comboBox1.SelectedIndex == 1)
            {
                label3.Text = "1.80";

            }
            if (comboBox1.SelectedIndex == 2)
            {
                label3.Text = "2";

            }






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null && comboBox1.SelectedIndex == 0 && radioButton1.Checked)
            {
                int i = int.Parse(textBox1.Text);
                label10.Text = (i * 1.5).ToString();
            }

            else if (textBox1.Text != null && comboBox1.SelectedIndex == 1 && radioButton1.Checked)
            {
                int i = int.Parse(textBox1.Text);
                label10.Text = (i * 1.8).ToString();
            }
            else if (textBox1.Text != null && comboBox1.SelectedIndex == 2 && radioButton1.Checked)
            {
                int i = int.Parse(textBox1.Text);
                label10.Text = (i * 2).ToString();
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null && comboBox1.SelectedIndex == 0 && radioButton2.Checked)
            {
                int s = int.Parse(textBox2.Text);
                label10.Text = (s * 1.5).ToString();


            }

            else if (textBox2.Text != null && comboBox1.SelectedIndex == 1 && radioButton2.Checked)
            {
                int s = int.Parse(textBox2.Text);
                label10.Text = (s * 1.8).ToString();


            }
            else if (textBox2.Text != null && comboBox1.SelectedIndex == 2 && radioButton2.Checked)
            {
                int s = int.Parse(textBox2.Text);
                label10.Text = (s * 2).ToString();

            }






        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox2.Text = null;
                label10.Text = null;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox1.Text = null;
                label10.Text = null;
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
                textBox1.Enabled = false;
                textBox1.Text = null;
                label10.Text = null;
            }
            else
            {
                textBox2.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Text = null;
                label10.Text = null;
            }


        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Enabled = true;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    int numt4 = int.Parse(textBox4.Text);
                    label14.Text = ((Convert.ToDouble(label14.Text)) - (numt4 * 4)).ToString();
                }
                textBox4.Text = null;
                textBox4.Enabled = false;
            }




        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox6.Enabled = true;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    int numt6 = int.Parse(textBox6.Text);
                    label14.Text = ((Convert.ToDouble(label14.Text)) - (numt6 * 5.4)).ToString();
                }
                textBox6.Enabled = false;
                textBox6.Text = null;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox8.Enabled = true;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    int numt8 = int.Parse(textBox8.Text);
                    label14.Text = ((Convert.ToDouble(label14.Text)) - (numt8 * 7.2)).ToString();
                }
                textBox8.Enabled = false;
                textBox8.Text = null;
            }

        }

        void CheckCheckBox(ref CheckBox checkBox, ref TextBox textBox, ref Label lbl, ref int count)
        {
            if (checkBox.Checked)
            {
                textBox.Enabled = true;
                textBox.Text = null;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                    count = int.Parse(textBox.Text);
                lbl.Text = ((Convert.ToDouble(lbl.Text)) - (count * 4.4)).ToString();
                textBox.Enabled = false;
                textBox.Text = null;
                count = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(ref checkBox4, ref textBox10, ref label14, ref CountCola);
        }
        public void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (!string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    int numt4 = int.Parse(textBox4.Text);
                    label14.Text = ((Convert.ToDouble(label14.Text)) + (numt4 * 4)).ToString();
                }
            }




        }

        public void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (!string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    int numt6 = int.Parse(textBox6.Text);
                    label14.Text = ((Convert.ToDouble(label14.Text)) + (numt6 * 5.4)).ToString();
                }



            }


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                if (!string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    int numt8 = int.Parse(textBox8.Text);
                    label14.Text = ((Convert.ToDouble(label14.Text)) + (numt8 * 7.2)).ToString();
                }


            }

        }

        int CountCola = 0;

        void ChechkTexBox(ref TextBox texbox, ref int count, ref Label lbl, string regex = "^-?\\d+\\.?\\d*$")
        {
            if (new Regex(regex).IsMatch(texbox.Text))
                if (!string.IsNullOrWhiteSpace(texbox.Text))
                {
                    lbl.Text = ((Convert.ToDouble(lbl.Text)) - (count * 4.4)).ToString();
                    count = int.Parse(texbox.Text);
                    lbl.Text = ((Convert.ToDouble(lbl.Text)) + (count * 4.4)).ToString();
                }
                else
                {
                    lbl.Text = ((Convert.ToDouble(lbl.Text)) - (count * 4.4)).ToString();
                    count = 0;
                }
            else if (!new Regex(regex).IsMatch(texbox.Text) && texbox.Text.Length > 0)
            {
                MessageBox.Show("Please FIll Correctly Count!", "Count", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                texbox.Text = "0";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            ChechkTexBox(ref textBox10, ref CountCola, ref label14);

        }
        private void label18_Click(object sender, EventArgs e)
        {
            label18.Text = "4,40";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label15.Text = "4,00";
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label16.Text = "5.40";
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label17.Text = "7.20";
        }

        private void label14_Click(object sender, EventArgs e)
        {


        }
    }



}