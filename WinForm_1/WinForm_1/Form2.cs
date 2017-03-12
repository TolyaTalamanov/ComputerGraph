using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            f.Dispose();
        }
    }
}
