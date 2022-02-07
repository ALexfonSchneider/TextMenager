using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextMenager
{
    public partial class Form2 : Form
    {
        public string inputString = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inputString = textBoxName.Text;
            this.Hide();
        }
    }
}
