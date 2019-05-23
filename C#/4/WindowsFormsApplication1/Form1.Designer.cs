namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBline = new System.Windows.Forms.ComboBox();
            this.butadd = new System.Windows.Forms.Button();
            this.butdel = new System.Windows.Forms.Button();
            this.butclear = new System.Windows.Forms.Button();
            this.CBcolor = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.butAdd1 = new System.Windows.Forms.Button();
            this.butDel1 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBcolor);
            this.groupBox1.Controls.Add(this.butclear);
            this.groupBox1.Controls.Add(this.butdel);
            this.groupBox1.Controls.Add(this.butadd);
            this.groupBox1.Controls.Add(this.CBline);
            this.groupBox1.Location = new System.Drawing.Point(57, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "series1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.butDel1);
            this.groupBox2.Controls.Add(this.butAdd1);
            this.groupBox2.Location = new System.Drawing.Point(438, 411);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "series2";
            // 
            // CBline
            // 
            this.CBline.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBline.FormattingEnabled = true;
            this.CBline.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBline.Location = new System.Drawing.Point(6, 67);
            this.CBline.Name = "CBline";
            this.CBline.Size = new System.Drawing.Size(110, 21);
            this.CBline.TabIndex = 0;
            this.CBline.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CBline_DrawItem);
            this.CBline.SelectedIndexChanged += new System.EventHandler(this.CBline_SelectedIndexChanged);
            // 
            // butadd
            // 
            this.butadd.Location = new System.Drawing.Point(7, 20);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(75, 23);
            this.butadd.TabIndex = 1;
            this.butadd.Text = "ADD";
            this.butadd.UseVisualStyleBackColor = true;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // butdel
            // 
            this.butdel.Location = new System.Drawing.Point(88, 20);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(75, 23);
            this.butdel.TabIndex = 2;
            this.butdel.Text = "DELETE";
            this.butdel.UseVisualStyleBackColor = true;
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butclear
            // 
            this.butclear.Location = new System.Drawing.Point(169, 20);
            this.butclear.Name = "butclear";
            this.butclear.Size = new System.Drawing.Size(75, 23);
            this.butclear.TabIndex = 3;
            this.butclear.Text = "CLEAR";
            this.butclear.UseVisualStyleBackColor = true;
            this.butclear.Click += new System.EventHandler(this.butclear_Click);
            // 
            // CBcolor
            // 
            this.CBcolor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBcolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBcolor.FormattingEnabled = true;
            this.CBcolor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.CBcolor.Location = new System.Drawing.Point(122, 67);
            this.CBcolor.Name = "CBcolor";
            this.CBcolor.Size = new System.Drawing.Size(121, 21);
            this.CBcolor.TabIndex = 4;
            this.CBcolor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CBcolor_DrawItem);
            this.CBcolor.SelectedIndexChanged += new System.EventHandler(this.CBcolor_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ContextMenuStrip = this.contextMenuStrip1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 34);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(631, 344);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.ContextMenuStripChanged += new System.EventHandler(this.chart1_ContextMenuStripChanged);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // butAdd1
            // 
            this.butAdd1.Location = new System.Drawing.Point(7, 19);
            this.butAdd1.Name = "butAdd1";
            this.butAdd1.Size = new System.Drawing.Size(75, 23);
            this.butAdd1.TabIndex = 0;
            this.butAdd1.Text = "Добавить";
            this.butAdd1.UseVisualStyleBackColor = true;
            this.butAdd1.Click += new System.EventHandler(this.butAdd1_Click);
            // 
            // butDel1
            // 
            this.butDel1.Location = new System.Drawing.Point(119, 19);
            this.butDel1.Name = "butDel1";
            this.butDel1.Size = new System.Drawing.Size(75, 23);
            this.butDel1.TabIndex = 1;
            this.butDel1.Text = "Удалить";
            this.butDel1.UseVisualStyleBackColor = true;
            this.butDel1.Click += new System.EventHandler(this.butDel1_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(7, 68);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(187, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dELETEToolStripMenuItem,
            this.cLEARToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 70);
            this.contextMenuStrip1.Click += new System.EventHandler(this.butclear_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem1.Text = "ADD";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.butadd_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 538);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ContextMenuStripChanged += new System.EventHandler(this.chart1_ContextMenuStripChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBcolor;
        private System.Windows.Forms.Button butclear;
        private System.Windows.Forms.Button butdel;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.ComboBox CBline;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button butDel1;
        private System.Windows.Forms.Button butAdd1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;
    }
}

