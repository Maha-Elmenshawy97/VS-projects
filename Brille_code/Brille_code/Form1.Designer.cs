namespace Brille_code
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Area)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 25);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(451, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Braille code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.click);
            // 
            // Area
            // 
            this.Area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Area.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Area.Location = new System.Drawing.Point(0, 70);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(680, 172);
            this.Area.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Area.TabIndex = 2;
            this.Area.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(683, 244);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Area;
    }
}

