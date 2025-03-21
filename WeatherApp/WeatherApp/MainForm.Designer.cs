namespace WeatherApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCity = new TextBox();
            btnGetWeather = new Button();
            lblCity = new Label();
            lblWeather = new Label();
            lblTemperature = new Label();
            lblHumidity = new Label();
            lblWindSpeed = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 24);
            label1.TabIndex = 0;
            label1.Text = "城市名稱:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(108, 9);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(149, 23);
            txtCity.TabIndex = 1;
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(291, 10);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(75, 23);
            btnGetWeather.TabIndex = 2;
            btnGetWeather.Text = "查詢";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblCity.Location = new Point(23, 79);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(48, 24);
            lblCity.TabIndex = 3;
            lblCity.Text = "城市";
            // 
            // lblWeather
            // 
            lblWeather.AutoSize = true;
            lblWeather.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWeather.Location = new Point(23, 111);
            lblWeather.Name = "lblWeather";
            lblWeather.Size = new Size(48, 24);
            lblWeather.TabIndex = 4;
            lblWeather.Text = "天氣";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblTemperature.Location = new Point(23, 140);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(48, 24);
            lblTemperature.TabIndex = 5;
            lblTemperature.Text = "氣溫";
            // 
            // lblHumidity
            // 
            lblHumidity.AutoSize = true;
            lblHumidity.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblHumidity.Location = new Point(23, 168);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(48, 24);
            lblHumidity.TabIndex = 6;
            lblHumidity.Text = "濕度";
            // 
            // lblWindSpeed
            // 
            lblWindSpeed.AutoSize = true;
            lblWindSpeed.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWindSpeed.Location = new Point(23, 197);
            lblWindSpeed.Name = "lblWindSpeed";
            lblWindSpeed.Size = new Size(48, 24);
            lblWindSpeed.TabIndex = 7;
            lblWindSpeed.Text = "風速";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWindSpeed);
            Controls.Add(lblHumidity);
            Controls.Add(lblTemperature);
            Controls.Add(lblWeather);
            Controls.Add(lblCity);
            Controls.Add(btnGetWeather);
            Controls.Add(txtCity);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "天氣查詢系統";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCity;
        private Button btnGetWeather;
        private Label lblCity;
        private Label lblWeather;
        private Label lblTemperature;
        private Label lblHumidity;
        private Label lblWindSpeed;
    }
}
