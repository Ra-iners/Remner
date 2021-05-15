
namespace Remner
{
    partial class Remner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remner));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PetPetButton = new System.Windows.Forms.Button();
            this.ExclamationMark = new System.Windows.Forms.Label();
            this.PetCounter = new System.Windows.Forms.Label();
            this.BlinkLights = new System.Windows.Forms.Timer(this.components);
            this.BlinkExc = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // PetPetButton
            // 
            this.PetPetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(121)))), ((int)(((byte)(140)))));
            this.PetPetButton.FlatAppearance.BorderSize = 0;
            this.PetPetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PetPetButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PetPetButton.ForeColor = System.Drawing.Color.White;
            this.PetPetButton.Location = new System.Drawing.Point(27, 270);
            this.PetPetButton.Name = "PetPetButton";
            this.PetPetButton.Size = new System.Drawing.Size(166, 36);
            this.PetPetButton.TabIndex = 2;
            this.PetPetButton.Text = "Pet pet :3";
            this.PetPetButton.UseVisualStyleBackColor = false;
            this.PetPetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExclamationMark
            // 
            this.ExclamationMark.AutoSize = true;
            this.ExclamationMark.BackColor = System.Drawing.Color.Transparent;
            this.ExclamationMark.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ExclamationMark.Location = new System.Drawing.Point(407, 9);
            this.ExclamationMark.Name = "ExclamationMark";
            this.ExclamationMark.Size = new System.Drawing.Size(68, 90);
            this.ExclamationMark.TabIndex = 3;
            this.ExclamationMark.Text = "!!";
            // 
            // PetCounter
            // 
            this.PetCounter.BackColor = System.Drawing.Color.Transparent;
            this.PetCounter.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PetCounter.Location = new System.Drawing.Point(19, 307);
            this.PetCounter.Name = "PetCounter";
            this.PetCounter.Size = new System.Drawing.Size(184, 17);
            this.PetCounter.TabIndex = 4;
            this.PetCounter.Text = "Rai has been petted 0 times";
            this.PetCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlinkLights
            // 
            this.BlinkLights.Enabled = true;
            this.BlinkLights.Interval = 500;
            this.BlinkLights.Tick += new System.EventHandler(this.BlinkLights_Tick);
            // 
            // BlinkExc
            // 
            this.BlinkExc.Enabled = true;
            this.BlinkExc.Interval = 250;
            this.BlinkExc.Tick += new System.EventHandler(this.BlinkExc_Tick);
            // 
            // Remner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(487, 337);
            this.Controls.Add(this.PetCounter);
            this.Controls.Add(this.ExclamationMark);
            this.Controls.Add(this.PetPetButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Remner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button PetPetButton;
        private System.Windows.Forms.Label ExclamationMark;
        private System.Windows.Forms.Label PetCounter;
        private System.Windows.Forms.Timer BlinkLights;
        private System.Windows.Forms.Timer BlinkExc;
    }
}

