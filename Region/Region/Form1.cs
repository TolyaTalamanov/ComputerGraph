using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Region
{
    public partial class Form1 : Form
    {
        Point moveStart;
        public Form1()
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.YellowGreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath mypath = new System.Drawing.Drawing2D.GraphicsPath();
            mypath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(mypath);
            this.Region = myRegion;



        }


    }
}
