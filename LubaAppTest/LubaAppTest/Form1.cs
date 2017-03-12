using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LubaAppTest
{
    public partial class Form1 : Form
    {
        
        int countClickButton = 0;
        Label text;
        Button btn;
        

        public Form1()
        {
            
            
            InitializeComponent();

            text = new Label();
            text.Location = new Point(100, 50);
            this.Controls.Add(text);

            btn = new Button();
            btn.Text = "Click me";
            btn.Location = new Point(100, 100);
            this.Controls.Add(btn);
            btn.Click += new EventHandler(Clickbtn);
            this.createMenu(countClickButton);
            
                
            
            

        }
        protected void createMenu(int _count)
        {

            
            text.Text = text.Text + "button click : " + _count;
            
            

        }
        public void Clickbtn(Object who,EventArgs e)
        {
           countClickButton++;
           this.createMenu(countClickButton);
        }

        
    }
}
