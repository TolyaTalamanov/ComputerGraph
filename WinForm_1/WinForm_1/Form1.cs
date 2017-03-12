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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            Text = "application_1";
            this.BackColor = Color.Aquamarine;
            this.Size = new Size(400, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ForeColor = Color.Red;
            
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2(this);
            Form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
