
namespace Fan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFanSpeed = new System.Windows.Forms.Button();
            this.btnRotation = new System.Windows.Forms.Button();
            this.lblFan = new System.Windows.Forms.Label();
            this.picFan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFanSpeed
            // 
            this.btnFanSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFanSpeed.Location = new System.Drawing.Point(307, 257);
            this.btnFanSpeed.Name = "btnFanSpeed";
            this.btnFanSpeed.Size = new System.Drawing.Size(146, 35);
            this.btnFanSpeed.TabIndex = 0;
            this.btnFanSpeed.Text = "Speed";
            this.btnFanSpeed.UseVisualStyleBackColor = true;
            this.btnFanSpeed.Click += new System.EventHandler(this.btnFanSpeed_Click);
            // 
            // btnRotation
            // 
            this.btnRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotation.Location = new System.Drawing.Point(88, 257);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.Size = new System.Drawing.Size(146, 35);
            this.btnRotation.TabIndex = 1;
            this.btnRotation.Text = "Rotation";
            this.btnRotation.UseVisualStyleBackColor = true;
            this.btnRotation.Click += new System.EventHandler(this.btnRotation_Click);
            // 
            // lblFan
            // 
            this.lblFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFan.Location = new System.Drawing.Point(12, 212);
            this.lblFan.Name = "lblFan";
            this.lblFan.Size = new System.Drawing.Size(535, 24);
            this.lblFan.TabIndex = 2;
            this.lblFan.Text = "fan info";
            this.lblFan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFan
            // 
            this.picFan.Image = global::Fan.Properties.Resources.fan;
            this.picFan.Location = new System.Drawing.Point(167, 27);
            this.picFan.Name = "picFan";
            this.picFan.Size = new System.Drawing.Size(221, 171);
            this.picFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFan.TabIndex = 3;
            this.picFan.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 319);
            this.Controls.Add(this.picFan);
            this.Controls.Add(this.lblFan);
            this.Controls.Add(this.btnRotation);
            this.Controls.Add(this.btnFanSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celling Fan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFanSpeed;
        private System.Windows.Forms.Button btnRotation;
        private System.Windows.Forms.Label lblFan;
        private System.Windows.Forms.PictureBox picFan;
    }
}

