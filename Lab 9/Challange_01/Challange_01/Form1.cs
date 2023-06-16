using System;
using System.Windows.Forms;

namespace Challange_01
{
    public partial class Form1 : Form
    {
        private int colorIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void nextColor()
        {
            if (colorIndex > 2)
            {
                colorIndex = 0;
            }
            txt_colorChange.BackColor = ColorChanger.getColorList()[colorIndex].getColor();
            colorIndex++;
        }

        public void prevColor()
        {
            colorIndex--;
            if (colorIndex < 0)
            {
                colorIndex = 2;
            }
            txt_colorChange.BackColor = ColorChanger.getColorList()[colorIndex].getColor();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            nextColor();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            prevColor();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Red red = new Red();
            Green green = new Green();
            Blue blue = new Blue();
            ColorChanger.getColorList().Add(red);
            ColorChanger.getColorList().Add(green);
            ColorChanger.getColorList().Add(blue);
        }
    }
}
