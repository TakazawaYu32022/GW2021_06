
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbPieDay = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.lbBudget = new System.Windows.Forms.Label();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChPieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ChPieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ChPieChart.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.ChPieChart.Legends.Add(legend2);
            this.ChPieChart.Location = new System.Drawing.Point(84, 67);
            this.ChPieChart.Name = "ChPieChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieLabelStyle=Disabled";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.ChPieChart.Series.Add(series2);
            this.ChPieChart.Size = new System.Drawing.Size(618, 345);
            this.ChPieChart.TabIndex = 0;
            this.ChPieChart.Text = "chart1";
            // 
            // lbPieDay
            // 
            this.lbPieDay.AutoSize = true;
            this.lbPieDay.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPieDay.ForeColor = System.Drawing.Color.Sienna;
            this.lbPieDay.Location = new System.Drawing.Point(320, 25);
            this.lbPieDay.Name = "lbPieDay";
            this.lbPieDay.Size = new System.Drawing.Size(124, 27);
            this.lbPieDay.TabIndex = 1;
            this.lbPieDay.Text = "〇年〇月";
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.SandyBrown;
            this.btBack.BackgroundImage = global::SimpleExpenses.Properties.Resources.book_note_empty;
            this.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBack.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(0, -1);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(77, 42);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "戻る";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbBudget
            // 
            this.lbBudget.AutoSize = true;
            this.lbBudget.BackColor = System.Drawing.Color.White;
            this.lbBudget.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbBudget.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbBudget.Location = new System.Drawing.Point(553, 303);
            this.lbBudget.Name = "lbBudget";
            this.lbBudget.Size = new System.Drawing.Size(56, 16);
            this.lbBudget.TabIndex = 3;
            this.lbBudget.Text = "予算：";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.BackColor = System.Drawing.Color.White;
            this.lbTotalCost.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTotalCost.ForeColor = System.Drawing.Color.Red;
            this.lbTotalCost.Location = new System.Drawing.Point(553, 336);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(56, 16);
            this.lbTotalCost.TabIndex = 4;
            this.lbTotalCost.Text = "支出：";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.White;
            this.lbTotal.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTotal.Location = new System.Drawing.Point(553, 368);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(56, 16);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "収支：";
            // 
            // PieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbTotalCost);
            this.Controls.Add(this.lbBudget);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lbPieDay);
            this.Controls.Add(this.ChPieChart);
            this.Name = "PieChart";
            this.Text = "簡単家計簿★円グラフ★";
            this.Load += new System.EventHandler(this.PieChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChPieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChPieChart;
        private System.Windows.Forms.Label lbPieDay;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbBudget;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Label lbTotal;
    }
}