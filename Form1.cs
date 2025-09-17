using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inClassProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helloLabel_MouseHover(object sender, EventArgs e)
        {MessageBox.Show("hello");

        }

        private void goodByeLabel_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("GoodBye!");
        }
    }
}
