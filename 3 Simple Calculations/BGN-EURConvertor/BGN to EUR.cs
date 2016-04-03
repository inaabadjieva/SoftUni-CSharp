using System;


namespace BGN_EURConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Convert();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }

       
        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            Convert();
        }
        private void Convert()
        {
            var BGN = this.numericUpDownAmount.Value;
            var EUR = BGN * 1.95583m;
            this.lableResult.Text = BGN + "BGN = " + Math.Round(EUR,2) + "EUR"; 
        }
    }
}
