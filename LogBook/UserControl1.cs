﻿using System;
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






        public UserControl1(Student student)
        {
            InitializeComponent();

            nameLbl.Text = student.FullName;
            lastDayLbl.Text = student.LastIn.ToShortDateString();
        }
    }
}
