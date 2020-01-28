﻿namespace Dashboard
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
            this.label3 = new System.Windows.Forms.Label();
            this.carName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mpg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.miles = new System.Windows.Forms.Label();
            this.driveB = new System.Windows.Forms.Button();
            this.minTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fillB = new System.Windows.Forms.Button();
            this.galTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.newCar = new System.Windows.Forms.Button();
            this.setSpeed = new System.Windows.Forms.Button();
            this.speedTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.gasBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.gasLight = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasLight)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "MPH";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carName
            // 
            this.carName.BackColor = System.Drawing.Color.White;
            this.carName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carName.Location = new System.Drawing.Point(12, 9);
            this.carName.Margin = new System.Windows.Forms.Padding(0);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(484, 30);
            this.carName.TabIndex = 4;
            this.carName.Text = "car";
            this.carName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(782, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed
            // 
            this.speed.BackColor = System.Drawing.Color.White;
            this.speed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.speed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.Location = new System.Drawing.Point(60, 216);
            this.speed.Margin = new System.Windows.Forms.Padding(0);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(72, 30);
            this.speed.TabIndex = 6;
            this.speed.Text = "60";
            this.speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 60);
            this.label5.TabIndex = 7;
            this.label5.Text = "Miles Per Gallon";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mpg
            // 
            this.mpg.BackColor = System.Drawing.Color.Olive;
            this.mpg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mpg.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpg.Location = new System.Drawing.Point(146, 97);
            this.mpg.Margin = new System.Windows.Forms.Padding(0);
            this.mpg.Name = "mpg";
            this.mpg.Size = new System.Drawing.Size(107, 60);
            this.mpg.TabIndex = 8;
            this.mpg.Text = "0";
            this.mpg.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(565, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gas Left:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gas
            // 
            this.gas.BackColor = System.Drawing.Color.White;
            this.gas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gas.Location = new System.Drawing.Point(416, 215);
            this.gas.Margin = new System.Windows.Forms.Padding(0);
            this.gas.Name = "gas";
            this.gas.Size = new System.Drawing.Size(72, 30);
            this.gas.TabIndex = 10;
            this.gas.Text = "60";
            this.gas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(565, 267);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 60);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tank Capacity:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // capacity
            // 
            this.capacity.BackColor = System.Drawing.Color.Olive;
            this.capacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.capacity.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.Location = new System.Drawing.Point(146, 157);
            this.capacity.Margin = new System.Windows.Forms.Padding(0);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(107, 60);
            this.capacity.TabIndex = 12;
            this.capacity.Text = "0";
            this.capacity.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(565, 327);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 30);
            this.label11.TabIndex = 13;
            this.label11.Text = "Miles Driven:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miles
            // 
            this.miles.BackColor = System.Drawing.Color.Olive;
            this.miles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.miles.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miles.Location = new System.Drawing.Point(146, 215);
            this.miles.Margin = new System.Windows.Forms.Padding(0);
            this.miles.Name = "miles";
            this.miles.Size = new System.Drawing.Size(107, 60);
            this.miles.TabIndex = 14;
            this.miles.Text = "0";
            this.miles.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // driveB
            // 
            this.driveB.Location = new System.Drawing.Point(124, 291);
            this.driveB.Margin = new System.Windows.Forms.Padding(0);
            this.driveB.Name = "driveB";
            this.driveB.Size = new System.Drawing.Size(117, 30);
            this.driveB.TabIndex = 15;
            this.driveB.Text = "Drive";
            this.driveB.UseVisualStyleBackColor = true;
            this.driveB.Click += new System.EventHandler(this.driveB_Click);
            // 
            // minTB
            // 
            this.minTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTB.Location = new System.Drawing.Point(241, 291);
            this.minTB.Margin = new System.Windows.Forms.Padding(0);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(141, 29);
            this.minTB.TabIndex = 16;
            this.minTB.Text = "0";
            this.minTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(728, 267);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 30);
            this.label13.TabIndex = 17;
            this.label13.Text = "Minutes";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fillB
            // 
            this.fillB.Location = new System.Drawing.Point(124, 320);
            this.fillB.Margin = new System.Windows.Forms.Padding(0);
            this.fillB.Name = "fillB";
            this.fillB.Size = new System.Drawing.Size(117, 30);
            this.fillB.TabIndex = 18;
            this.fillB.Text = "Fill Gas";
            this.fillB.UseVisualStyleBackColor = true;
            this.fillB.Click += new System.EventHandler(this.fillB_Click);
            // 
            // galTB
            // 
            this.galTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galTB.Location = new System.Drawing.Point(241, 320);
            this.galTB.Margin = new System.Windows.Forms.Padding(0);
            this.galTB.Name = "galTB";
            this.galTB.Size = new System.Drawing.Size(141, 29);
            this.galTB.TabIndex = 19;
            this.galTB.Text = "0";
            this.galTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(728, 296);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 30);
            this.label14.TabIndex = 20;
            this.label14.Text = "Gallons";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newCar
            // 
            this.newCar.Location = new System.Drawing.Point(124, 378);
            this.newCar.Margin = new System.Windows.Forms.Padding(0);
            this.newCar.Name = "newCar";
            this.newCar.Size = new System.Drawing.Size(258, 30);
            this.newCar.TabIndex = 21;
            this.newCar.Text = "New Car";
            this.newCar.UseVisualStyleBackColor = true;
            this.newCar.Click += new System.EventHandler(this.newCar_Click);
            // 
            // setSpeed
            // 
            this.setSpeed.Location = new System.Drawing.Point(124, 349);
            this.setSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.setSpeed.Name = "setSpeed";
            this.setSpeed.Size = new System.Drawing.Size(117, 30);
            this.setSpeed.TabIndex = 22;
            this.setSpeed.Text = "Set Speed";
            this.setSpeed.UseVisualStyleBackColor = true;
            this.setSpeed.Click += new System.EventHandler(this.setSpeed_Click);
            // 
            // speedTB
            // 
            this.speedTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedTB.Location = new System.Drawing.Point(241, 349);
            this.speedTB.Margin = new System.Windows.Forms.Padding(0);
            this.speedTB.Name = "speedTB";
            this.speedTB.Size = new System.Drawing.Size(141, 29);
            this.speedTB.TabIndex = 23;
            this.speedTB.Text = "0";
            this.speedTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(728, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "MPH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // speedBar
            // 
            this.speedBar.Enabled = false;
            this.speedBar.Location = new System.Drawing.Point(12, 45);
            this.speedBar.Maximum = 100;
            this.speedBar.Name = "speedBar";
            this.speedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.speedBar.Size = new System.Drawing.Size(45, 231);
            this.speedBar.TabIndex = 25;
            // 
            // gasBar
            // 
            this.gasBar.Enabled = false;
            this.gasBar.Location = new System.Drawing.Point(368, 44);
            this.gasBar.Maximum = 100;
            this.gasBar.Name = "gasBar";
            this.gasBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.gasBar.Size = new System.Drawing.Size(45, 231);
            this.gasBar.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "gallons";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gasLight
            // 
            this.gasLight.Image = global::Dashboard.Properties.Resources.orange_removebg_preview;
            this.gasLight.Location = new System.Drawing.Point(415, 192);
            this.gasLight.Name = "gasLight";
            this.gasLight.Size = new System.Drawing.Size(20, 20);
            this.gasLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gasLight.TabIndex = 28;
            this.gasLight.TabStop = false;
            this.gasLight.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Olive;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 60);
            this.label6.TabIndex = 31;
            this.label6.Text = "mi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Olive;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(253, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 60);
            this.label8.TabIndex = 30;
            this.label8.Text = "tank cap gals     ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Olive;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(253, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 60);
            this.label10.TabIndex = 29;
            this.label10.Text = "MPG";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(505, 432);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gasLight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gasBar);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedTB);
            this.Controls.Add(this.setSpeed);
            this.Controls.Add(this.newCar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.galTB);
            this.Controls.Add(this.fillB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.minTB);
            this.Controls.Add(this.driveB);
            this.Controls.Add(this.miles);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mpg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label carName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mpg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label miles;
        private System.Windows.Forms.Button driveB;
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button fillB;
        private System.Windows.Forms.TextBox galTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button newCar;
        private System.Windows.Forms.Button setSpeed;
        private System.Windows.Forms.TextBox speedTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.TrackBar gasBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox gasLight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}

