﻿namespace gyak_8_gwsb1a
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
            this.components = new System.ComponentModel.Container();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.buttonSzinvalaszto = new System.Windows.Forms.Button();
            this.buttonBall = new System.Windows.Forms.Button();
            this.buttonCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonPresent = new System.Windows.Forms.Button();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainpanel.Controls.Add(this.buttonPresent);
            this.mainpanel.Controls.Add(this.buttonSzinvalaszto);
            this.mainpanel.Controls.Add(this.buttonBall);
            this.mainpanel.Controls.Add(this.buttonCar);
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Location = new System.Drawing.Point(30, 37);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(737, 382);
            this.mainpanel.TabIndex = 0;
            // 
            // buttonSzinvalaszto
            // 
            this.buttonSzinvalaszto.BackColor = System.Drawing.Color.Coral;
            this.buttonSzinvalaszto.Location = new System.Drawing.Point(156, 276);
            this.buttonSzinvalaszto.Name = "buttonSzinvalaszto";
            this.buttonSzinvalaszto.Size = new System.Drawing.Size(75, 23);
            this.buttonSzinvalaszto.TabIndex = 3;
            this.buttonSzinvalaszto.UseVisualStyleBackColor = false;
            this.buttonSzinvalaszto.Click += new System.EventHandler(this.ButtonSzinvalaszto_Click);
            // 
            // buttonBall
            // 
            this.buttonBall.Location = new System.Drawing.Point(156, 228);
            this.buttonBall.Name = "buttonBall";
            this.buttonBall.Size = new System.Drawing.Size(75, 23);
            this.buttonBall.TabIndex = 2;
            this.buttonBall.Text = "BALL";
            this.buttonBall.UseVisualStyleBackColor = true;
            this.buttonBall.Click += new System.EventHandler(this.ButtonBall_Click);
            // 
            // buttonCar
            // 
            this.buttonCar.Location = new System.Drawing.Point(31, 228);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(75, 23);
            this.buttonCar.TabIndex = 1;
            this.buttonCar.Text = "CAR";
            this.buttonCar.UseVisualStyleBackColor = true;
            this.buttonCar.Click += new System.EventHandler(this.ButtonCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coming next";
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.CreateTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.ConveyorTimer_Tick);
            // 
            // buttonPresent
            // 
            this.buttonPresent.Location = new System.Drawing.Point(271, 228);
            this.buttonPresent.Name = "buttonPresent";
            this.buttonPresent.Size = new System.Drawing.Size(84, 23);
            this.buttonPresent.TabIndex = 4;
            this.buttonPresent.Text = "PRESENT";
            this.buttonPresent.UseVisualStyleBackColor = true;
            this.buttonPresent.Click += new System.EventHandler(this.ButtonPresent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.mainpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button buttonBall;
        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSzinvalaszto;
        private System.Windows.Forms.Button buttonPresent;
    }
}

