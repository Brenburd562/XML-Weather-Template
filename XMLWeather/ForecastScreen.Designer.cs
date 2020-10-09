namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(1298, 415);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(193, 62);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 221);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.White;
            this.min1.Location = new System.Drawing.Point(361, 586);
            this.min1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(51, 29);
            this.min1.TabIndex = 48;
            // 
            // max1
            // 
            this.max1.BackColor = System.Drawing.Color.White;
            this.max1.Location = new System.Drawing.Point(361, 448);
            this.max1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(51, 29);
            this.max1.TabIndex = 45;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Font = new System.Drawing.Font("Stencil", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(406, 292);
            this.date1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(251, 99);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(1250, 586);
            this.date2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(63, 29);
            this.date2.TabIndex = 69;
            this.date2.Text = "Date";
            // 
            // min2
            // 
            this.min2.BackColor = System.Drawing.Color.White;
            this.min2.Location = new System.Drawing.Point(1474, 711);
            this.min2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(51, 29);
            this.min2.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1250, 711);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 29);
            this.label4.TabIndex = 67;
            this.label4.Text = " Min Temperature";
            // 
            // max2
            // 
            this.max2.BackColor = System.Drawing.Color.White;
            this.max2.Location = new System.Drawing.Point(1474, 646);
            this.max2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(51, 29);
            this.max2.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1250, 646);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 29);
            this.label7.TabIndex = 65;
            this.label7.Text = "Max Temperature";
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.HotDay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.date2);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.max1);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label label7;
    }
}
