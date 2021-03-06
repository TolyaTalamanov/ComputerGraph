﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TalamanovBatanina_2
{
    public partial class Form1 : Form
    {
        Form Form2;
        string startImageDialog;
        static int n;
        bool[,] matr;
        DataGridView DataGrid1;
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp  | All Files (*.*) | *.* ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                startImageDialog = dialog.FileName;
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();

            }
            progressBar1.Value = 0;
        }

        private void degradationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlueFilter();
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void filterGausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (startImageDialog != null)
            {
                image = new Bitmap(startImageDialog);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void grayScaleFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new EmbossingFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new RemoveFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void spinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SpinFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void verticalWavesFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new VerticalWavesFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void horizontalWavesFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new HorizontalWavesFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void effectOfGlassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new EffectOfGlass();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void harshnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Harshness();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MotionBlur(3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool [,] matr = new bool[3,3]  { {false,true,false },{true,false,true }, {false,true,false } };
            pictureBox1.Image = MathMorfology.Erosion(image, matr);
            pictureBox1.Refresh();
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool[,] matr = new bool[3, 3] { { false, true, false }, { true, false, true }, { false, true, false } };
            pictureBox1.Image = MathMorfology.Dilation(image, matr);
            pictureBox1.Refresh();
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool[,] matr = new bool[3, 3] { { false, true, false }, { true, false, true }, { false, true, false } };
            
            pictureBox1.Image = MathMorfology.Dilation(MathMorfology.Erosion(image, matr), matr);
            pictureBox1.Refresh();
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool[,] matr = new bool[3, 3] { { false, true, false }, { true, false, true }, { false, true, false } };
            

            pictureBox1.Image = MathMorfology.Erosion(MathMorfology.Dilation(image, matr), matr);
            pictureBox1.Refresh();

        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Filters filter = new MedianFilter(5);
            backgroundWorker1.RunWorkerAsync(filter);

            

        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool[,] matr = new bool[3, 3] { { false, true, false }, { true, false, true }, { false, true, false } };

            pictureBox1.Image = MathMorfology.Gradient(image, matr);
            pictureBox1.Refresh();

        }

        private void autoSelvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new AutoSelvesFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 3;
            matr = new bool[n, n];
            Form2 = new Form();
            Form2.Size = new Size(300, 150);
            Form2.Show();
            DataGrid1 = new DataGridView();
            DataGrid1.Size = new Size(200, 100);
            DataGrid1.ColumnCount = n;
            DataGrid1.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                DataGrid1.Columns[i].Width = 50;
                DataGrid1.Rows[i].Height = 25;
            }
            Form2.Controls.Add(DataGrid1);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    DataGrid1[i, j].Value = 0;
            DataGrid1.Show();
            Button ok = new Button();
            ok.Text = "ok";
            ok.Location = new Point(200,75);
            ok.Click += new EventHandler(button_click);
            Form2.Controls.Add(ok);
            ok.Show();
        }
        public void button_click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (DataGrid1[i, j].Value.ToString() == "0")
                        matr[i, j] = false;
                    else
                        matr[i, j] = true;
                }
            }
            Form2.Close();
            MessageBox.Show("Mask added!");
            

        }
       

    }
}
