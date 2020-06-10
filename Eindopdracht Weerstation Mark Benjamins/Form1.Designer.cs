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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Actueel = new System.Windows.Forms.TabPage();
            this.Voorspelling = new System.Windows.Forms.Label();
            this.plaats = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.Wind = new System.Windows.Forms.Label();
            this.Luchtvochtigheid = new System.Windows.Forms.Label();
            this.Tempera = new System.Windows.Forms.Label();
            this.Trend = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Opties = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.inputInterval = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.RadioButton();
            this.F = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.intervaltext = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPlaats = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.huidigeTemperatuurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verversenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sluitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Actueel.SuspendLayout();
            this.Trend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Opties.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(554, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // Actueel
            // 
            this.Actueel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Actueel.Controls.Add(this.Voorspelling);
            this.Actueel.Controls.Add(this.plaats);
            this.Actueel.Controls.Add(this.time);
            this.Actueel.Controls.Add(this.Wind);
            this.Actueel.Controls.Add(this.Luchtvochtigheid);
            this.Actueel.Controls.Add(this.Tempera);
            this.Actueel.Location = new System.Drawing.Point(4, 25);
            this.Actueel.Name = "Actueel";
            this.Actueel.Padding = new System.Windows.Forms.Padding(3);
            this.Actueel.Size = new System.Drawing.Size(546, 401);
            this.Actueel.TabIndex = 0;
            this.Actueel.Text = "Actueel";
            // 
            // Voorspelling
            // 
            this.Voorspelling.AutoSize = true;
            this.Voorspelling.Location = new System.Drawing.Point(255, 79);
            this.Voorspelling.Name = "Voorspelling";
            this.Voorspelling.Size = new System.Drawing.Size(86, 17);
            this.Voorspelling.TabIndex = 11;
            this.Voorspelling.Text = "Voorspelling";
            // 
            // plaats
            // 
            this.plaats.AutoSize = true;
            this.plaats.Location = new System.Drawing.Point(52, 79);
            this.plaats.Name = "plaats";
            this.plaats.Size = new System.Drawing.Size(47, 17);
            this.plaats.TabIndex = 10;
            this.plaats.Text = "Plaats";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(320, 212);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(105, 17);
            this.time.TabIndex = 9;
            this.time.Text = "[ Last Update ] ";
            // 
            // Wind
            // 
            this.Wind.AutoSize = true;
            this.Wind.Location = new System.Drawing.Point(52, 201);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(52, 17);
            this.Wind.TabIndex = 8;
            this.Wind.Text = "Wind : ";
            // 
            // Luchtvochtigheid
            // 
            this.Luchtvochtigheid.AutoSize = true;
            this.Luchtvochtigheid.Location = new System.Drawing.Point(52, 164);
            this.Luchtvochtigheid.Name = "Luchtvochtigheid";
            this.Luchtvochtigheid.Size = new System.Drawing.Size(127, 17);
            this.Luchtvochtigheid.TabIndex = 7;
            this.Luchtvochtigheid.Text = "Luchtvochtigheid : ";
            // 
            // Tempera
            // 
            this.Tempera.AutoSize = true;
            this.Tempera.Location = new System.Drawing.Point(48, 124);
            this.Tempera.Name = "Tempera";
            this.Tempera.Size = new System.Drawing.Size(102, 17);
            this.Tempera.TabIndex = 6;
            this.Tempera.Text = "Temperatuur : ";
            // 
            // Trend
            // 
            this.Trend.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Trend.Controls.Add(this.chart1);
            this.Trend.Location = new System.Drawing.Point(4, 25);
            this.Trend.Name = "Trend";
            this.Trend.Padding = new System.Windows.Forms.Padding(3);
            this.Trend.Size = new System.Drawing.Size(546, 401);
            this.Trend.TabIndex = 1;
            this.Trend.Text = "Trend";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 50);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(523, 302);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Opties
            // 
            this.Opties.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Opties.Controls.Add(this.button1);
            this.Opties.Controls.Add(this.label7);
            this.Opties.Controls.Add(this.inputInterval);
            this.Opties.Controls.Add(this.C);
            this.Opties.Controls.Add(this.F);
            this.Opties.Controls.Add(this.label6);
            this.Opties.Controls.Add(this.intervaltext);
            this.Opties.Controls.Add(this.label4);
            this.Opties.Controls.Add(this.inputPlaats);
            this.Opties.Location = new System.Drawing.Point(4, 25);
            this.Opties.Name = "Opties";
            this.Opties.Padding = new System.Windows.Forms.Padding(3);
            this.Opties.Size = new System.Drawing.Size(546, 401);
            this.Opties.TabIndex = 2;
            this.Opties.Text = "Opties";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(771, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "(in Sec)";
            // 
            // inputInterval
            // 
            this.inputInterval.Location = new System.Drawing.Point(138, 114);
            this.inputInterval.Name = "inputInterval";
            this.inputInterval.Size = new System.Drawing.Size(352, 22);
            this.inputInterval.TabIndex = 9;
            this.inputInterval.Text = "60";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Checked = true;
            this.C.Location = new System.Drawing.Point(166, 158);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(38, 21);
            this.C.TabIndex = 8;
            this.C.TabStop = true;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(222, 158);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(37, 21);
            this.F.TabIndex = 7;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Weergave";
            // 
            // intervaltext
            // 
            this.intervaltext.AutoSize = true;
            this.intervaltext.Location = new System.Drawing.Point(62, 114);
            this.intervaltext.Name = "intervaltext";
            this.intervaltext.Size = new System.Drawing.Size(54, 17);
            this.intervaltext.TabIndex = 5;
            this.intervaltext.Text = "Interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plaats";
            // 
            // inputPlaats
            // 
            this.inputPlaats.Location = new System.Drawing.Point(138, 76);
            this.inputPlaats.Name = "inputPlaats";
            this.inputPlaats.Size = new System.Drawing.Size(352, 22);
            this.inputPlaats.TabIndex = 3;
            this.inputPlaats.Text = "Emmen";
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
            this.verversenToolStripMenuItem,
            this.optiesToolStripMenuItem,
            this.openToolStripMenuItem,
            this.sluitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 148);
            // 
            // huidigeTemperatuurToolStripMenuItem
            // 
            this.huidigeTemperatuurToolStripMenuItem.Name = "huidigeTemperatuurToolStripMenuItem";
            this.huidigeTemperatuurToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.huidigeTemperatuurToolStripMenuItem.Text = "Huidige temperatuur";
            // 
            // overToolStripMenuItem
            // 
            this.overToolStripMenuItem.Name = "overToolStripMenuItem";
            this.overToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.overToolStripMenuItem.Text = "Over...";
            this.overToolStripMenuItem.Click += new System.EventHandler(this.overToolStripMenuItem_Click);
            // 
            // verversenToolStripMenuItem
            // 
            this.verversenToolStripMenuItem.Name = "verversenToolStripMenuItem";
            this.verversenToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.verversenToolStripMenuItem.Text = "Verversen";
            this.verversenToolStripMenuItem.Click += new System.EventHandler(this.verversenToolStripMenuItem_Click);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(436, 337);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weerstation van Mark Benjamins";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Actueel.ResumeLayout(false);
            this.Actueel.PerformLayout();
            this.Trend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Opties.ResumeLayout(false);
            this.Opties.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Actueel;
        private System.Windows.Forms.TabPage Trend;
        private System.Windows.Forms.TabPage Opties;
        private System.Windows.Forms.Label Wind;
        private System.Windows.Forms.Label Luchtvochtigheid;
        private System.Windows.Forms.Label Tempera;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label intervaltext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputPlaats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputInterval;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton F;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem huidigeTemperatuurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitToolStripMenuItem;
        private System.Windows.Forms.Label plaats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem verversenToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Voorspelling;
    }
}

