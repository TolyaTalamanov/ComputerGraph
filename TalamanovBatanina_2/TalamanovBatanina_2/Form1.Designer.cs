namespace TalamanovBatanina_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalWavesFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalWavesFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectOfGlassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтерГаусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harshnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathMorfologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фильтрыToolStripMenuItem,
            this.фильтрыToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.фильтрыToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem1
            // 
            this.фильтрыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.mathMorfologyToolStripMenuItem,
            this.medianFilterToolStripMenuItem});
            this.фильтрыToolStripMenuItem1.Name = "фильтрыToolStripMenuItem1";
            this.фильтрыToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.фильтрыToolStripMenuItem1.Text = "Filters";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.grayScaleFilterToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.spinToolStripMenuItem,
            this.verticalWavesFilterToolStripMenuItem,
            this.horizontalWavesFilterToolStripMenuItem,
            this.effectOfGlassToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // grayScaleFilterToolStripMenuItem
            // 
            this.grayScaleFilterToolStripMenuItem.Name = "grayScaleFilterToolStripMenuItem";
            this.grayScaleFilterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.grayScaleFilterToolStripMenuItem.Text = "GrayScaleFilter";
            this.grayScaleFilterToolStripMenuItem.Click += new System.EventHandler(this.grayScaleFilterToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // spinToolStripMenuItem
            // 
            this.spinToolStripMenuItem.Name = "spinToolStripMenuItem";
            this.spinToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.spinToolStripMenuItem.Text = "Spin";
            this.spinToolStripMenuItem.Click += new System.EventHandler(this.spinToolStripMenuItem_Click);
            // 
            // verticalWavesFilterToolStripMenuItem
            // 
            this.verticalWavesFilterToolStripMenuItem.Name = "verticalWavesFilterToolStripMenuItem";
            this.verticalWavesFilterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.verticalWavesFilterToolStripMenuItem.Text = "VerticalWavesFilter";
            this.verticalWavesFilterToolStripMenuItem.Click += new System.EventHandler(this.verticalWavesFilterToolStripMenuItem_Click);
            // 
            // horizontalWavesFilterToolStripMenuItem
            // 
            this.horizontalWavesFilterToolStripMenuItem.Name = "horizontalWavesFilterToolStripMenuItem";
            this.horizontalWavesFilterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.horizontalWavesFilterToolStripMenuItem.Text = "HorizontalWavesFilter";
            this.horizontalWavesFilterToolStripMenuItem.Click += new System.EventHandler(this.horizontalWavesFilterToolStripMenuItem_Click);
            // 
            // effectOfGlassToolStripMenuItem
            // 
            this.effectOfGlassToolStripMenuItem.Name = "effectOfGlassToolStripMenuItem";
            this.effectOfGlassToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.effectOfGlassToolStripMenuItem.Text = "EffectOfGlass";
            this.effectOfGlassToolStripMenuItem.Click += new System.EventHandler(this.effectOfGlassToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.фильтерГаусаToolStripMenuItem,
            this.embossingToolStripMenuItem,
            this.harshnessToolStripMenuItem,
            this.motionBlurToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.degradationToolStripMenuItem_Click);
            // 
            // фильтерГаусаToolStripMenuItem
            // 
            this.фильтерГаусаToolStripMenuItem.Name = "фильтерГаусаToolStripMenuItem";
            this.фильтерГаусаToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.фильтерГаусаToolStripMenuItem.Text = "Фильтер Гауса";
            this.фильтерГаусаToolStripMenuItem.Click += new System.EventHandler(this.filterGausToolStripMenuItem_Click);
            // 
            // embossingToolStripMenuItem
            // 
            this.embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            this.embossingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.embossingToolStripMenuItem.Text = "Embossing";
            this.embossingToolStripMenuItem.Click += new System.EventHandler(this.embossingToolStripMenuItem_Click);
            // 
            // harshnessToolStripMenuItem
            // 
            this.harshnessToolStripMenuItem.Name = "harshnessToolStripMenuItem";
            this.harshnessToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.harshnessToolStripMenuItem.Text = "Harshness";
            this.harshnessToolStripMenuItem.Click += new System.EventHandler(this.harshnessToolStripMenuItem_Click);
            // 
            // motionBlurToolStripMenuItem
            // 
            this.motionBlurToolStripMenuItem.Name = "motionBlurToolStripMenuItem";
            this.motionBlurToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.motionBlurToolStripMenuItem.Text = "Motion Blur";
            this.motionBlurToolStripMenuItem.Click += new System.EventHandler(this.motionBlurToolStripMenuItem_Click);
            // 
            // mathMorfologyToolStripMenuItem
            // 
            this.mathMorfologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erosionToolStripMenuItem,
            this.dilationToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem});
            this.mathMorfologyToolStripMenuItem.Name = "mathMorfologyToolStripMenuItem";
            this.mathMorfologyToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.mathMorfologyToolStripMenuItem.Text = "MathMorfology";
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.medianFilterToolStripMenuItem.Text = "MedianFilter";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cansel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 464);
            this.progressBar1.Maximum = 110;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(651, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(758, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 499);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтерГаусаToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem grayScaleFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalWavesFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalWavesFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectOfGlassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harshnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathMorfologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
    }
}

