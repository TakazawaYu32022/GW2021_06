
namespace SimpleExpenses
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ExpensesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpensesChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ExpensesChart.ChartAreas.Add(chartArea3);
            legend5.Name = "費用合計";
            legend6.Name = "予算";
            this.ExpensesChart.Legends.Add(legend5);
            this.ExpensesChart.Legends.Add(legend6);
            this.ExpensesChart.Location = new System.Drawing.Point(26, 62);
            this.ExpensesChart.Name = "ExpensesChart";
            this.ExpensesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series5.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            series5.Legend = "費用合計";
            series5.Name = "費用";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Blue;
            series6.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.Legend = "予算";
            series6.Name = "予算";
            this.ExpensesChart.Series.Add(series5);
            this.ExpensesChart.Series.Add(series6);
            this.ExpensesChart.Size = new System.Drawing.Size(734, 339);
            this.ExpensesChart.TabIndex = 0;
            this.ExpensesChart.Text = "chart1";
            // 
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.Color.LightGreen;
            this.btMenu.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btMenu.Location = new System.Drawing.Point(723, 2);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(74, 38);
            this.btMenu.TabIndex = 1;
            this.btMenu.Text = "メニュー";
            this.btMenu.UseVisualStyleBackColor = false;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.ExpensesChart);
            this.Name = "Statistics";
            this.Text = "簡単家計簿★統計画面★";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ExpensesChart;
        private System.Windows.Forms.Button btMenu;
    }
}