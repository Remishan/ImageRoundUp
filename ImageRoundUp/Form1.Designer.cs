namespace ImageRoundUp
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
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.tmrStrwberry = new System.Windows.Forms.Timer(this.components);
            this.pbxMango = new System.Windows.Forms.PictureBox();
            this.pbxOrange = new System.Windows.Forms.PictureBox();
            this.pbxBanana = new System.Windows.Forms.PictureBox();
            this.pbxStrawberry = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMango)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrawberry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRight.Location = new System.Drawing.Point(192, 215);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(109, 24);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLeft.Location = new System.Drawing.Point(192, 185);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(109, 24);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPause.Location = new System.Drawing.Point(192, 245);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(109, 24);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // tmrStrwberry
            // 
            this.tmrStrwberry.Enabled = true;
            this.tmrStrwberry.Interval = 2;
            this.tmrStrwberry.Tick += new System.EventHandler(this.tmrStrwberry_Tick);
            // 
            // pbxMango
            // 
            this.pbxMango.Image = global::ImageRoundUp.Properties.Resources.download;
            this.pbxMango.Location = new System.Drawing.Point(334, 174);
            this.pbxMango.Name = "pbxMango";
            this.pbxMango.Size = new System.Drawing.Size(121, 102);
            this.pbxMango.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMango.TabIndex = 7;
            this.pbxMango.TabStop = false;
            // 
            // pbxOrange
            // 
            this.pbxOrange.Image = global::ImageRoundUp.Properties.Resources.download__2_;
            this.pbxOrange.Location = new System.Drawing.Point(180, 300);
            this.pbxOrange.Name = "pbxOrange";
            this.pbxOrange.Size = new System.Drawing.Size(121, 102);
            this.pbxOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOrange.TabIndex = 3;
            this.pbxOrange.TabStop = false;
            // 
            // pbxBanana
            // 
            this.pbxBanana.Image = global::ImageRoundUp.Properties.Resources.download__3_;
            this.pbxBanana.Location = new System.Drawing.Point(33, 174);
            this.pbxBanana.Name = "pbxBanana";
            this.pbxBanana.Size = new System.Drawing.Size(121, 102);
            this.pbxBanana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBanana.TabIndex = 2;
            this.pbxBanana.TabStop = false;
            // 
            // pbxStrawberry
            // 
            this.pbxStrawberry.Image = global::ImageRoundUp.Properties.Resources.images;
            this.pbxStrawberry.Location = new System.Drawing.Point(180, 60);
            this.pbxStrawberry.Name = "pbxStrawberry";
            this.pbxStrawberry.Size = new System.Drawing.Size(121, 102);
            this.pbxStrawberry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStrawberry.TabIndex = 0;
            this.pbxStrawberry.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.pbxMango);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.pbxOrange);
            this.Controls.Add(this.pbxBanana);
            this.Controls.Add(this.pbxStrawberry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMango)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStrawberry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxStrawberry;
        private System.Windows.Forms.PictureBox pbxBanana;
        private System.Windows.Forms.PictureBox pbxOrange;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Timer tmrStrwberry;
        private System.Windows.Forms.PictureBox pbxMango;
    }
}

