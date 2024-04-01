using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            borsch_picture.Visible = true;
            menu_open.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            counter++;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                borsch_picture.Visible = true;
                borsch_text.Visible = true;
                cumpot_picture.Visible = false;
                cumpot_text.Visible = false;
                varenuku_picture.Visible = false;
                varenuku_text.Visible = false;
                button2.Visible=false;
                button1.Visible = true;

            }
            if (counter == 2)
            {
                borsch_picture.Visible = false;
                borsch_text.Visible = false;
                varenuku_picture.Visible = true;
                varenuku_text.Visible = true;
                cumpot_picture.Visible = false;
                cumpot_text.Visible = false;
                button2.Visible = true;
                button1.Visible = true;
            }
            if (counter == 3)
            {
                varenuku_picture.Visible = false;
                varenuku_text.Visible = false;
                cumpot_picture.Visible = true;
                cumpot_text.Visible = true;
                borsch_picture.Visible = false;
                borsch_text.Visible = false;
                button2.Visible = true;
                button1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter == 1)
            {
                borsch_picture.Visible = true;
                borsch_text.Visible = true;
                cumpot_picture.Visible = false;
                cumpot_text.Visible = false;
                varenuku_picture.Visible = false;
                varenuku_text.Visible = false;
                button2.Visible = false;
                button1.Visible = true;

            }
            if (counter == 2)
            {
                borsch_picture.Visible = false;
                borsch_text.Visible = false;
                varenuku_picture.Visible = true;
                varenuku_text.Visible = true;
                cumpot_picture.Visible = false;
                cumpot_text.Visible = false;
                button2.Visible = true;
                button1.Visible = true;
            }
            if (counter == 3)
            {
                varenuku_picture.Visible = false;
                varenuku_text.Visible = false;
                cumpot_picture.Visible = true;
                cumpot_text.Visible = true;
                borsch_picture.Visible = false;
                borsch_text.Visible = false;
                button2.Visible = true;
                button1.Visible = false;
            }
        }
    }
}
