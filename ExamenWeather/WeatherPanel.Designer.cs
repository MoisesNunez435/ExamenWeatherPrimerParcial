namespace ExamenWeather
{
    partial class WeatherPanel
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
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.WeatherIcon = new System.Windows.Forms.PictureBox();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.flpContent2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(244, 84);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(152, 55);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "label1";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(282, 24);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(66, 33);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.Location = new System.Drawing.Point(266, 154);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(103, 29);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "Weather";
            // 
            // WeatherIcon
            // 
            this.WeatherIcon.Location = new System.Drawing.Point(59, 154);
            this.WeatherIcon.Name = "WeatherIcon";
            this.WeatherIcon.Size = new System.Drawing.Size(100, 50);
            this.WeatherIcon.TabIndex = 3;
            this.WeatherIcon.TabStop = false;
            // 
            // flpContent
            // 
            this.flpContent.Location = new System.Drawing.Point(0, 229);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(626, 317);
            this.flpContent.TabIndex = 4;
            // 
            // flpContent2
            // 
            this.flpContent2.AutoScroll = true;
            this.flpContent2.Location = new System.Drawing.Point(0, 546);
            this.flpContent2.Name = "flpContent2";
            this.flpContent2.Size = new System.Drawing.Size(626, 204);
            this.flpContent2.TabIndex = 5;
            // 
            // WeatherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpContent2);
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.WeatherIcon);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblTemp);
            this.Name = "WeatherPanel";
            this.Size = new System.Drawing.Size(626, 750);
            this.Load += new System.EventHandler(this.WeatherPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTemp;
        public System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.Label lblWeather;
        public System.Windows.Forms.PictureBox WeatherIcon;
        public System.Windows.Forms.FlowLayoutPanel flpContent;
        public System.Windows.Forms.FlowLayoutPanel flpContent2;
    }
}
