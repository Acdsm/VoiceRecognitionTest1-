namespace VoiceRecognitionTest1
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
            this.BtnEnabled = new System.Windows.Forms.Button();
            this.BtnDisable = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnEnabled
            // 
            this.BtnEnabled.Location = new System.Drawing.Point(16, 234);
            this.BtnEnabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEnabled.Name = "BtnEnabled";
            this.BtnEnabled.Size = new System.Drawing.Size(157, 28);
            this.BtnEnabled.TabIndex = 0;
            this.BtnEnabled.Text = " Enable Voice Control";
            this.BtnEnabled.UseVisualStyleBackColor = true;
            this.BtnEnabled.Click += new System.EventHandler(this.BtnEnabled_Click);
            // 
            // BtnDisable
            // 
            this.BtnDisable.Enabled = false;
            this.BtnDisable.Location = new System.Drawing.Point(205, 234);
            this.BtnDisable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDisable.Name = "BtnDisable";
            this.BtnDisable.Size = new System.Drawing.Size(171, 28);
            this.BtnDisable.TabIndex = 1;
            this.BtnDisable.Text = "Disable Voice Control";
            this.BtnDisable.UseVisualStyleBackColor = true;
            this.BtnDisable.Click += new System.EventHandler(this.BtnDisable_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 2);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 223);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "-Log-";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 266);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnDisable);
            this.Controls.Add(this.BtnEnabled);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speech Recognition Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEnabled;
        private System.Windows.Forms.Button BtnDisable;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

