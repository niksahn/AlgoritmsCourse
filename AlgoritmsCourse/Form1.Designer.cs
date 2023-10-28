namespace AlgoritmsCourse
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.arraySize = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.percentSortRadio = new System.Windows.Forms.RadioButton();
            this.backSortedRadio = new System.Windows.Forms.RadioButton();
            this.sortedRadio = new System.Windows.Forms.RadioButton();
            this.notSortedRadio = new System.Windows.Forms.RadioButton();
            this.sortPercent = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraySize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.arraySize);
            this.panel1.Location = new System.Drawing.Point(2, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 207);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Размерность списка ";
            // 
            // arraySize
            // 
            this.arraySize.Location = new System.Drawing.Point(76, 114);
            this.arraySize.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.arraySize.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(120, 20);
            this.arraySize.TabIndex = 3;
            this.arraySize.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.percentSortRadio);
            this.panel2.Controls.Add(this.backSortedRadio);
            this.panel2.Controls.Add(this.sortedRadio);
            this.panel2.Controls.Add(this.notSortedRadio);
            this.panel2.Controls.Add(this.sortPercent);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(2, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 315);
            this.panel2.TabIndex = 1;
            // 
            // percentSortRadio
            // 
            this.percentSortRadio.AutoSize = true;
            this.percentSortRadio.Location = new System.Drawing.Point(19, 160);
            this.percentSortRadio.Name = "percentSortRadio";
            this.percentSortRadio.Size = new System.Drawing.Size(154, 17);
            this.percentSortRadio.TabIndex = 9;
            this.percentSortRadio.TabStop = true;
            this.percentSortRadio.Text = "Частично упорядоченный";
            this.percentSortRadio.UseVisualStyleBackColor = true;
            // 
            // backSortedRadio
            // 
            this.backSortedRadio.AutoSize = true;
            this.backSortedRadio.Location = new System.Drawing.Point(19, 115);
            this.backSortedRadio.Name = "backSortedRadio";
            this.backSortedRadio.Size = new System.Drawing.Size(212, 17);
            this.backSortedRadio.TabIndex = 8;
            this.backSortedRadio.TabStop = true;
            this.backSortedRadio.Text = "Упорядоченный в обратном порядке";
            this.backSortedRadio.UseVisualStyleBackColor = true;
            // 
            // sortedRadio
            // 
            this.sortedRadio.AutoSize = true;
            this.sortedRadio.Location = new System.Drawing.Point(19, 79);
            this.sortedRadio.Name = "sortedRadio";
            this.sortedRadio.Size = new System.Drawing.Size(106, 17);
            this.sortedRadio.TabIndex = 7;
            this.sortedRadio.TabStop = true;
            this.sortedRadio.Text = "Упорядоченный";
            this.sortedRadio.UseVisualStyleBackColor = true;
            // 
            // notSortedRadio
            // 
            this.notSortedRadio.AutoSize = true;
            this.notSortedRadio.Location = new System.Drawing.Point(19, 35);
            this.notSortedRadio.Name = "notSortedRadio";
            this.notSortedRadio.Size = new System.Drawing.Size(117, 17);
            this.notSortedRadio.TabIndex = 6;
            this.notSortedRadio.TabStop = true;
            this.notSortedRadio.Text = "Неупорядоченный";
            this.notSortedRadio.UseVisualStyleBackColor = true;
            // 
            // sortPercent
            // 
            this.sortPercent.Location = new System.Drawing.Point(76, 269);
            this.sortPercent.Name = "sortPercent";
            this.sortPercent.Size = new System.Drawing.Size(120, 20);
            this.sortPercent.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Процент упорядоченности";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ввод значений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип упорядоченности";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 721);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Отсортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(948, 721);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(336, 506);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 209);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Длина списка";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Время сортировки прямым включением";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Время сортировки двоичным включением";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Время сортировки методом Шелла";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // chart1
            // 
            chartArea8.AxisX.Title = "Размер";
            chartArea8.AxisY.Title = "Время";
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(285, 66);
            this.chart1.Name = "chart1";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Legend = "Legend1";
            series22.Name = "Метод прямого выбора";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.Name = "Метод двоичного выбора";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.Name = "Метод Шелла";
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Size = new System.Drawing.Size(801, 434);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1087, 785);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Сахно 22Вп3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraySize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown arraySize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton percentSortRadio;
        private System.Windows.Forms.RadioButton backSortedRadio;
        private System.Windows.Forms.RadioButton sortedRadio;
        private System.Windows.Forms.RadioButton notSortedRadio;
        private System.Windows.Forms.NumericUpDown sortPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

