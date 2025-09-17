using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            whackPic1.Image = Properties.Resources.whack_a_mole_hole;
            whackPic2.Image = Properties.Resources.whack_a_mole_hole;
            whackPic3.Image = Properties.Resources.whack_a_mole_hole;
            whackPic4.Image = Properties.Resources.whack_a_mole_hole;
            whackPic5.Image = Properties.Resources.whack_a_mole_mole;
            whackPic6.Image = Properties.Resources.whack_a_mole_hole;
            whackPic7.Image = Properties.Resources.whack_a_mole_hole;
            whackPic8.Image = Properties.Resources.whack_a_mole_hole;
            whackPic9.Image = Properties.Resources.whack_a_mole_hole;



            whackPic1.Enabled = false;
            whackPic2.Enabled = false;
            whackPic3.Enabled = false;
            whackPic4.Enabled = false;
            whackPic5.Enabled = false;
            whackPic6.Enabled = false;
            whackPic7.Enabled = false;
            whackPic8.Enabled = false;
            whackPic9.Enabled = false;

        }
        private void startGameButton_Click(object sender, EventArgs e)
        {
            whackPic1.Enabled = true;
            whackPic2.Enabled = true;
            whackPic3.Enabled = true;
            whackPic4.Enabled = true;
            whackPic5.Enabled = true;
            whackPic6.Enabled = true;
            whackPic7.Enabled = true;
            whackPic8.Enabled = true;
            whackPic9.Enabled = true;

            string firstname, lastname;
            firstname = firstNameTextBox.Text;
            lastname = lastNameTextBox.Text;
            fullNameLabel.Text = "Welcome,"+" " + firstname + " " + lastname;


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
