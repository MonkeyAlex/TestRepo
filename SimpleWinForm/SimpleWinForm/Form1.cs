using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            MessageBox.Show("Sum of 1 to 10 = " + sum);
        }
    }
}
