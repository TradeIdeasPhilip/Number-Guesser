using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random _random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            int low = Convert.ToInt32(lowTextBox.Text);
            int high = Convert.ToInt32(highTextBox.Text);
            _random.Next(low, high);
        }
    }
}
