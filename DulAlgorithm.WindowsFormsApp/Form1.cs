using System;
using System.Windows.Forms;

namespace DulAlgorithm.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //[1] Input
            int[] data = { 1, 4, 3, 2, 5 };

            //[2] Process
            int[] numbers = DulAlgorithm.Algorithm.SelectionSort(data);

            //[3] Output
            MessageBox.Show(data[1].ToString()); // 2
        }
    }
}
