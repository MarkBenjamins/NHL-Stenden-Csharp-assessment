namespace Eindopdracht_Weerstation_Mark_Benjamins
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Actueel = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.Wind = new System.Windows.Forms.Label();
            this.Luchtvochtigheid = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Trend = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Opties = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.huidigeTemperatuurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sluitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plaats = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Actueel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Trend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Opties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Actueel);
            this.tabControl1.Controls.Add(this.Trend);
            this.tabControl1.Controls.Add(this.Opties);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabControl1.Location = new System.Drawing.Point(-5, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1109, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // Actueel
            // 
            this.Actueel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Actueel.Controls.Add(this.plaats);
            this.Actueel.Controls.Add(this.label8);
            this.Actueel.Controls.Add(this.Wind);
            this.Actueel.Controls.Add(this.Luchtvochtigheid);
            this.Actueel.Controls.Add(this.Temp);
            this.Actueel.Controls.Add(this.pictureBox1);
            this.Actueel.Location = new System.Drawing.Point(4, 25);
            this.Actueel.Name = "Actueel";
            this.Actueel.Padding = new System.Windows.Forms.Padding(3);
            this.Actueel.Size = new System.Drawing.Size(1101, 580);
            this.Actueel.TabIndex = 0;
            this.Actueel.Text = "Actueel";
            this.Actueel.Click += new System.EventHandler(this.Actueel_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "[ Last Update ] ";
            // 
            // Wind
            // 
            this.Wind.AutoSize = true;
            this.Wind.Location = new System.Drawing.Point(10, 360);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(52, 17);
            this.Wind.TabIndex = 8;
            this.Wind.Text = "Wind : ";
            this.Wind.Click += new System.EventHandler(this.label3_Click);
            // 
            // Luchtvochtigheid
            // 
            this.Luchtvochtigheid.AutoSize = true;
            this.Luchtvochtigheid.Location = new System.Drawing.Point(10, 315);
            this.Luchtvochtigheid.Name = "Luchtvochtigheid";
            this.Luchtvochtigheid.Size = new System.Drawing.Size(127, 17);
            this.Luchtvochtigheid.TabIndex = 7;
            this.Luchtvochtigheid.Text = "Luchtvochtigheid : ";
            this.Luchtvochtigheid.Click += new System.EventHandler(this.label2_Click);
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Location = new System.Drawing.Point(10, 273);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(102, 17);
            this.Temp.TabIndex = 6;
            this.Temp.Text = "Temperatuur : ";
            this.Temp.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 208);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Trend
            // 
            this.Trend.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Trend.Controls.Add(this.chart1);
            this.Trend.Controls.Add(this.pictureBox2);
            this.Trend.Location = new System.Drawing.Point(4, 25);
            this.Trend.Name = "Trend";
            this.Trend.Padding = new System.Windows.Forms.Padding(3);
            this.Trend.Size = new System.Drawing.Size(1101, 580);
            this.Trend.TabIndex = 1;
            this.Trend.Text = "Trend";
            this.Trend.Click += new System.EventHandler(this.Trend_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(394, 127);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(646, 388);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 208);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Opties
            // 
            this.Opties.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Opties.Controls.Add(this.label7);
            this.Opties.Controls.Add(this.textBox2);
            this.Opties.Controls.Add(this.radioButton2);
            this.Opties.Controls.Add(this.radioButton1);
            this.Opties.Controls.Add(this.label6);
            this.Opties.Controls.Add(this.label5);
            this.Opties.Controls.Add(this.label4);
            this.Opties.Controls.Add(this.textBox1);
            this.Opties.Controls.Add(this.pictureBox3);
            this.Opties.Location = new System.Drawing.Point(4, 25);
            this.Opties.Name = "Opties";
            this.Opties.Padding = new System.Windows.Forms.Padding(3);
            this.Opties.Size = new System.Drawing.Size(1101, 580);
            this.Opties.TabIndex = 2;
            this.Opties.Text = "Opties";
            this.Opties.Click += new System.EventHandler(this.Opties_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(771, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "(in Sec)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 304);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(352, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "60";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(502, 348);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "C";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(424, 348);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "F";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Weergave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plaats";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Emmen";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(327, 208);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Weerstation Mark";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huidigeTemperatuurToolStripMenuItem,
            this.overToolStripMenuItem,
            this.optiesToolStripMenuItem,
            this.openToolStripMenuItem,
            this.sluitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 124);
            // 
            // huidigeTemperatuurToolStripMenuItem
            // 
            this.huidigeTemperatuurToolStripMenuItem.Name = "huidigeTemperatuurToolStripMenuItem";
            this.huidigeTemperatuurToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.huidigeTemperatuurToolStripMenuItem.Text = "Huidige temperatuur";
            this.huidigeTemperatuurToolStripMenuItem.Click += new System.EventHandler(this.huidigeTemperatuurToolStripMenuItem_Click);
            // 
            // overToolStripMenuItem
            // 
            this.overToolStripMenuItem.Name = "overToolStripMenuItem";
            this.overToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.overToolStripMenuItem.Text = "Over...";
            this.overToolStripMenuItem.Click += new System.EventHandler(this.overToolStripMenuItem_Click);
            // 
            // optiesToolStripMenuItem
            // 
            this.optiesToolStripMenuItem.Name = "optiesToolStripMenuItem";
            this.optiesToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.optiesToolStripMenuItem.Text = "Opties...";
            this.optiesToolStripMenuItem.Click += new System.EventHandler(this.optiesToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // sluitToolStripMenuItem
            // 
            this.sluitToolStripMenuItem.Name = "sluitToolStripMenuItem";
            this.sluitToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.sluitToolStripMenuItem.Text = "Sluit...";
            this.sluitToolStripMenuItem.Click += new System.EventHandler(this.sluitToolStripMenuItem_Click);
            // 
            // plaats
            // 
            this.plaats.AutoSize = true;
            this.plaats.Location = new System.Drawing.Point(10, 231);
            this.plaats.Name = "plaats";
            this.plaats.Size = new System.Drawing.Size(47, 17);
            this.plaats.TabIndex = 10;
            this.plaats.Text = "Plaats";
            this.plaats.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1091, 602);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weerstation van Mark Benjamins";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.Actueel.ResumeLayout(false);
            this.Actueel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Trend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Opties.ResumeLayout(false);
            this.Opties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Actueel;
        private System.Windows.Forms.TabPage Trend;
        private System.Windows.Forms.TabPage Opties;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Wind;
        private System.Windows.Forms.Label Luchtvochtigheid;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem huidigeTemperatuurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitToolStripMenuItem;
        private System.Windows.Forms.Label plaats;
    }
}

