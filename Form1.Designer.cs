
namespace rage
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
            this.GL = new System.Windows.Forms.RadioButton();
            this.KR = new System.Windows.Forms.RadioButton();
            this.TW = new System.Windows.Forms.RadioButton();
            this.VN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GL
            // 
            this.GL.AutoSize = true;
            this.GL.Location = new System.Drawing.Point(12, 12);
            this.GL.Name = "GL";
            this.GL.Size = new System.Drawing.Size(39, 17);
            this.GL.TabIndex = 1;
            this.GL.TabStop = true;
            this.GL.Text = "GL";
            this.GL.UseVisualStyleBackColor = true;
            // 
            // KR
            // 
            this.KR.AutoSize = true;
            this.KR.Location = new System.Drawing.Point(57, 12);
            this.KR.Name = "KR";
            this.KR.Size = new System.Drawing.Size(40, 17);
            this.KR.TabIndex = 2;
            this.KR.TabStop = true;
            this.KR.Text = "KR";
            this.KR.UseVisualStyleBackColor = true;
            // 
            // TW
            // 
            this.TW.AutoSize = true;
            this.TW.Location = new System.Drawing.Point(103, 12);
            this.TW.Name = "TW";
            this.TW.Size = new System.Drawing.Size(43, 17);
            this.TW.TabIndex = 3;
            this.TW.TabStop = true;
            this.TW.Text = "TW";
            this.TW.UseVisualStyleBackColor = true;
            // 
            // VN
            // 
            this.VN.AutoSize = true;
            this.VN.Location = new System.Drawing.Point(152, 12);
            this.VN.Name = "VN";
            this.VN.Size = new System.Drawing.Size(40, 17);
            this.VN.TabIndex = 4;
            this.VN.TabStop = true;
            this.VN.Text = "VN";
            this.VN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 86);
            this.Controls.Add(this.VN);
            this.Controls.Add(this.TW);
            this.Controls.Add(this.KR);
            this.Controls.Add(this.GL);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton GL;
        private System.Windows.Forms.RadioButton KR;
        private System.Windows.Forms.RadioButton TW;
        private System.Windows.Forms.RadioButton VN;
    }
}

