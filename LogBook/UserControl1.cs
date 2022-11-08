using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook
{
    public partial class UserControl1 : UserControl
    {

        public EventHandler<EventArgs> DiamondClick { get; set; }
        public EventHandler<EventArgs> DiamondClickIncrease { get; set; }
        public UserControl1(Student student)
        {
            InitializeComponent();

            nameLbl.Text = student.FullName;
            lastDayLbl.Text = student.LastIn.ToShortDateString();
        }
        public bool HasClicked1 { get; set; }
        public bool HasClicked2 { get; set; }
        public bool HasClicked3 { get; set; }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var box = (sender as PictureBox);
            if (!HasClicked1)
            {
                HasClicked1 = true;
                box.Image = Properties.Resources.icons8_diamond_48;
                DiamondClick.Invoke(sender, e);
            }
            else
            {
                if (!HasClicked2)
                {
                    DiamondClickIncrease(sender, e);
                    HasClicked1 = false;
                    box.Image = Properties.Resources.icons8_diamond_50;
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var box = (sender as PictureBox);
            if (!HasClicked2)
            {
                HasClicked2 = true;
                box.Image = Properties.Resources.icons8_diamond_48;
                DiamondClick.Invoke(sender, e);
                if (!HasClicked1)
                {
                    HasClicked1 = true;
                    DiamondClick.Invoke(sender, e);
                    pictureBox1.Image = Properties.Resources.icons8_diamond_48;
                }
            }
            else
            {
                DiamondClickIncrease(sender, e);
                DiamondClickIncrease(sender, e);
                HasClicked2 = false;
                HasClicked1 = false;
                box.Image = Properties.Resources.icons8_diamond_50;
                pictureBox1.Image = Properties.Resources.icons8_diamond_50;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
