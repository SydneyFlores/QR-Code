
namespace QR_Code
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
            this.camerabox = new System.Windows.Forms.PictureBox();
            this.buttonstart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.camerabox)).BeginInit();
            this.SuspendLayout();
            // 
            // camerabox
            // 
            this.camerabox.Location = new System.Drawing.Point(93, 28);
            this.camerabox.Name = "camerabox";
            this.camerabox.Size = new System.Drawing.Size(624, 406);
            this.camerabox.TabIndex = 0;
            this.camerabox.TabStop = false;
            this.camerabox.Click += new System.EventHandler(this.camerabox_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(360, 492);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(75, 23);
            this.buttonstart.TabIndex = 1;
            this.buttonstart.Text = "Start";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.camerabox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camerabox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox camerabox;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Timer timer1;
    }
}

