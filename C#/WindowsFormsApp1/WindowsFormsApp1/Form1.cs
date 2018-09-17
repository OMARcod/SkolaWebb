using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            int width, length;
            bool widthOK, lengthOK;
            widthOK = Int32.TryParse(WidthBox.Text, out width);
            lengthOK = Int32.TryParse(LengthBox.Text, out length);

            if (widthOK && lengthOK)

            {
                int area = width * length;
                AreaBox.Text = area.ToString();
            }

            else
            {
                AreaBox.Text = "Ogiltigt";
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
