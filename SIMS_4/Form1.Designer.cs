
namespace SIMS_4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.edEuro = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sellTB = new System.Windows.Forms.TextBox();
            this.buyTB = new System.Windows.Forms.TextBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rubValueLabel = new System.Windows.Forms.Label();
            this.rubLabel = new System.Windows.Forms.Label();
            this.euroValueLabel = new System.Windows.Forms.Label();
            this.euroLabel = new System.Windows.Forms.Label();
            this.daysValueLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // edEuro
            // 
            this.edEuro.DecimalPlaces = 2;
            this.edEuro.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.edEuro.Location = new System.Drawing.Point(114, 24);
            this.edEuro.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.edEuro.Name = "edEuro";
            this.edEuro.Size = new System.Drawing.Size(96, 20);
            this.edEuro.TabIndex = 6;
            this.edEuro.Value = new decimal(new int[] {
            9021,
            0,
            0,
            131072});
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(20, 26);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(92, 13);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Начальная цена:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sellTB);
            this.panel1.Controls.Add(this.buyTB);
            this.panel1.Controls.Add(this.sellButton);
            this.panel1.Controls.Add(this.buyButton);
            this.panel1.Controls.Add(this.priceValueLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rubValueLabel);
            this.panel1.Controls.Add(this.rubLabel);
            this.panel1.Controls.Add(this.euroValueLabel);
            this.panel1.Controls.Add(this.euroLabel);
            this.panel1.Controls.Add(this.daysValueLabel);
            this.panel1.Controls.Add(this.calcButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.edEuro);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 91);
            this.panel1.TabIndex = 7;
            // 
            // sellTB
            // 
            this.sellTB.Location = new System.Drawing.Point(547, 51);
            this.sellTB.Name = "sellTB";
            this.sellTB.Size = new System.Drawing.Size(44, 20);
            this.sellTB.TabIndex = 20;
            this.sellTB.Text = "0";
            // 
            // buyTB
            // 
            this.buyTB.Location = new System.Drawing.Point(547, 19);
            this.buyTB.Name = "buyTB";
            this.buyTB.Size = new System.Drawing.Size(44, 20);
            this.buyTB.TabIndex = 19;
            this.buyTB.Text = "0";
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(432, 47);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(109, 26);
            this.sellButton.TabIndex = 18;
            this.sellButton.Text = "Продать";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(432, 15);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(109, 26);
            this.buyButton.TabIndex = 17;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.AutoSize = true;
            this.priceValueLabel.Location = new System.Drawing.Point(111, 61);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(13, 13);
            this.priceValueLabel.TabIndex = 16;
            this.priceValueLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Текущая цена:";
            // 
            // rubValueLabel
            // 
            this.rubValueLabel.AutoSize = true;
            this.rubValueLabel.Location = new System.Drawing.Point(333, 61);
            this.rubValueLabel.Name = "rubValueLabel";
            this.rubValueLabel.Size = new System.Drawing.Size(13, 13);
            this.rubValueLabel.TabIndex = 14;
            this.rubValueLabel.Text = "0";
            // 
            // rubLabel
            // 
            this.rubLabel.AutoSize = true;
            this.rubLabel.Location = new System.Drawing.Point(287, 61);
            this.rubLabel.Name = "rubLabel";
            this.rubLabel.Size = new System.Drawing.Size(46, 13);
            this.rubLabel.TabIndex = 13;
            this.rubLabel.Text = "Рублей:";
            // 
            // euroValueLabel
            // 
            this.euroValueLabel.AutoSize = true;
            this.euroValueLabel.Location = new System.Drawing.Point(333, 26);
            this.euroValueLabel.Name = "euroValueLabel";
            this.euroValueLabel.Size = new System.Drawing.Size(13, 13);
            this.euroValueLabel.TabIndex = 12;
            this.euroValueLabel.Text = "0";
            // 
            // euroLabel
            // 
            this.euroLabel.AutoSize = true;
            this.euroLabel.Location = new System.Drawing.Point(287, 26);
            this.euroLabel.Name = "euroLabel";
            this.euroLabel.Size = new System.Drawing.Size(35, 13);
            this.euroLabel.TabIndex = 11;
            this.euroLabel.Text = "Евро:";
            // 
            // daysValueLabel
            // 
            this.daysValueLabel.AutoSize = true;
            this.daysValueLabel.Location = new System.Drawing.Point(726, 67);
            this.daysValueLabel.Name = "daysValueLabel";
            this.daysValueLabel.Size = new System.Drawing.Size(13, 13);
            this.daysValueLabel.TabIndex = 10;
            this.daysValueLabel.Text = "0";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(629, 26);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(140, 38);
            this.calcButton.TabIndex = 9;
            this.calcButton.Text = "Следующий день";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Число дней:";
            // 
            // chart1
            // 
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart1.Location = new System.Drawing.Point(0, 90);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(800, 360);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown edEuro;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label daysValueLabel;
        private System.Windows.Forms.Label rubValueLabel;
        private System.Windows.Forms.Label rubLabel;
        private System.Windows.Forms.Label euroValueLabel;
        private System.Windows.Forms.Label euroLabel;
        private System.Windows.Forms.Label priceValueLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.TextBox sellTB;
        private System.Windows.Forms.TextBox buyTB;
    }
}

