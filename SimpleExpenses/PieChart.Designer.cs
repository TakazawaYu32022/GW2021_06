
namespace SimpleExpenses
{
    partial class PieChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbPieDay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChPieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ChPieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ChPieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChPieChart.Legends.Add(legend1);
            this.ChPieChart.Location = new System.Drawing.Point(84, 67);
            this.ChPieChart.Name = "ChPieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChPieChart.Series.Add(series1);
            this.ChPieChart.Size = new System.Drawing.Size(599, 348);
            this.ChPieChart.TabIndex = 0;
            this.ChPieChart.Text = "chart1";
            // 
            // lbPieDay
            // 
            this.lbPieDay.AutoSize = true;
            this.lbPieDay.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPieDay.Location = new System.Drawing.Point(320, 25);
            this.lbPieDay.Name = "lbPieDay";
            this.lbPieDay.Size = new System.Drawing.Size(124, 27);
            this.lbPieDay.TabIndex = 1;
            this.lbPieDay.Text = "〇年〇月";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.BackgroundImage = global::SimpleExpenses.Properties.Resources.book_note_empty;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "戻る";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPieDay);
            this.Controls.Add(this.ChPieChart);
            this.Name = "PieChart";
            this.Text = "PieChart";
            this.Load += new System.EventHandler(this.PieChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChPieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChPieChart;
        private System.Windows.Forms.Label lbPieDay;
        private System.Windows.Forms.Button button1;
    }
}