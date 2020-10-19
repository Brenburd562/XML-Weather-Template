namespace XMLWeather
{
    partial class CurrentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateTime = new System.Windows.Forms.Label();
            this.labelWeatherType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(463, 87);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(357, 51);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(23, 116);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(202, 62);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7-Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(383, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 137);
            this.label3.TabIndex = 81;
            this.label3.Text = "Today";
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold);
            this.minOutput.ForeColor = System.Drawing.Color.DarkBlue;
            this.minOutput.Location = new System.Drawing.Point(661, 515);
            this.minOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(83, 57);
            this.minOutput.TabIndex = 80;
            this.minOutput.Text = "00";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold);
            this.maxOutput.ForeColor = System.Drawing.Color.Red;
            this.maxOutput.Location = new System.Drawing.Point(520, 515);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(83, 57);
            this.maxOutput.TabIndex = 79;
            this.maxOutput.Text = "00";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Bold);
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(478, 275);
            this.date1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(342, 71);
            this.date1.TabIndex = 78;
            this.date1.Text = "0000-00-00";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Stencil", 80F, System.Drawing.FontStyle.Bold);
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(424, 288);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(397, 284);
            this.tempLabel.TabIndex = 77;
            this.tempLabel.Text = "00";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 62);
            this.label1.TabIndex = 82;
            this.label1.Text = "Widgits";
            // 
            // updateTime
            // 
            this.updateTime.BackColor = System.Drawing.Color.Transparent;
            this.updateTime.Font = new System.Drawing.Font("Stencil", 10F);
            this.updateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateTime.Location = new System.Drawing.Point(-6, 0);
            this.updateTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.updateTime.Name = "updateTime";
            this.updateTime.Size = new System.Drawing.Size(485, 62);
            this.updateTime.TabIndex = 83;
            this.updateTime.Text = "7-Day";
            // 
            // labelWeatherType
            // 
            this.labelWeatherType.BackColor = System.Drawing.Color.Transparent;
            this.labelWeatherType.Font = new System.Drawing.Font("Stencil", 14F);
            this.labelWeatherType.ForeColor = System.Drawing.Color.White;
            this.labelWeatherType.Location = new System.Drawing.Point(380, 640);
            this.labelWeatherType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWeatherType.Name = "labelWeatherType";
            this.labelWeatherType.Size = new System.Drawing.Size(491, 62);
            this.labelWeatherType.TabIndex = 85;
            this.labelWeatherType.Text = "Weather";
            this.labelWeatherType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.labelWeatherType);
            this.Controls.Add(this.updateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.cityOutput);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(1248, 702);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label updateTime;
        private System.Windows.Forms.Label labelWeatherType;
    }
}
