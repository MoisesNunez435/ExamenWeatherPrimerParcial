namespace ExamenWeather
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.WeatherIcon = new System.Windows.Forms.PictureBox();
            this.lblWeather = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblAt = new System.Windows.Forms.Label();
            this.lblAm = new System.Windows.Forms.Label();
            this.lblWinS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPress = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblHumm = new System.Windows.Forms.Label();
            this.lblVis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(372, 52);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(229, 24);
            this.cmbCity.TabIndex = 1;
            // 
            // flpContent
            // 
            this.flpContent.AutoScroll = true;
            this.flpContent.Location = new System.Drawing.Point(16, 422);
            this.flpContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(728, 224);
            this.flpContent.TabIndex = 0;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(21, 37);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 42);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = " ";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(36, 220);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(46, 69);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = " ";
            // 
            // WeatherIcon
            // 
            this.WeatherIcon.Location = new System.Drawing.Point(75, 96);
            this.WeatherIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WeatherIcon.Name = "WeatherIcon";
            this.WeatherIcon.Size = new System.Drawing.Size(133, 62);
            this.WeatherIcon.TabIndex = 4;
            this.WeatherIcon.TabStop = false;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.Location = new System.Drawing.Point(68, 180);
            this.lblWeather.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(23, 36);
            this.lblWeather.TabIndex = 5;
            this.lblWeather.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amanecer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Atardecer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wind Speed";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(569, 117);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(17, 25);
            this.lblDetails.TabIndex = 10;
            this.lblDetails.Text = " ";
            // 
            // lblAt
            // 
            this.lblAt.AutoSize = true;
            this.lblAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAt.Location = new System.Drawing.Point(185, 309);
            this.lblAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAt.Name = "lblAt";
            this.lblAt.Size = new System.Drawing.Size(17, 25);
            this.lblAt.TabIndex = 11;
            this.lblAt.Text = " ";
            this.lblAt.Click += new System.EventHandler(this.Label6_Click);
            // 
            // lblAm
            // 
            this.lblAm.AutoSize = true;
            this.lblAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAm.Location = new System.Drawing.Point(185, 367);
            this.lblAm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAm.Name = "lblAm";
            this.lblAm.Size = new System.Drawing.Size(17, 25);
            this.lblAm.TabIndex = 12;
            this.lblAm.Text = " ";
            this.lblAm.Click += new System.EventHandler(this.Label7_Click);
            // 
            // lblWinS
            // 
            this.lblWinS.AutoSize = true;
            this.lblWinS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinS.Location = new System.Drawing.Point(569, 191);
            this.lblWinS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinS.Name = "lblWinS";
            this.lblWinS.Size = new System.Drawing.Size(17, 25);
            this.lblWinS.TabIndex = 13;
            this.lblWinS.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(348, 255);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Pressure";
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPress.Location = new System.Drawing.Point(569, 255);
            this.lblPress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(17, 25);
            this.lblPress.TabIndex = 15;
            this.lblPress.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(332, 309);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Hummidity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(348, 367);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Visibility";
            // 
            // lblHumm
            // 
            this.lblHumm.AutoSize = true;
            this.lblHumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumm.Location = new System.Drawing.Point(569, 309);
            this.lblHumm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHumm.Name = "lblHumm";
            this.lblHumm.Size = new System.Drawing.Size(17, 25);
            this.lblHumm.TabIndex = 18;
            this.lblHumm.Text = " ";
            // 
            // lblVis
            // 
            this.lblVis.AutoSize = true;
            this.lblVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVis.Location = new System.Drawing.Point(569, 367);
            this.lblVis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVis.Name = "lblVis";
            this.lblVis.Size = new System.Drawing.Size(17, 25);
            this.lblVis.TabIndex = 19;
            this.lblVis.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 656);
            this.Controls.Add(this.lblVis);
            this.Controls.Add(this.lblHumm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblWinS);
            this.Controls.Add(this.lblAm);
            this.Controls.Add(this.lblAt);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.WeatherIcon);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
        public System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.Label lblTemp;
        public System.Windows.Forms.PictureBox WeatherIcon;
        public System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblAt;
        private System.Windows.Forms.Label lblAm;
        private System.Windows.Forms.Label lblWinS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblHumm;
        private System.Windows.Forms.Label lblVis;
    }
}

