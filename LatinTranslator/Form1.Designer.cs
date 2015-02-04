namespace LatinTranslator
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
            this.sinsterButton = new System.Windows.Forms.Button();
            this.dexterButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.translatedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sinsterButton
            // 
            this.sinsterButton.Location = new System.Drawing.Point(49, 68);
            this.sinsterButton.Name = "sinsterButton";
            this.sinsterButton.Size = new System.Drawing.Size(100, 40);
            this.sinsterButton.TabIndex = 0;
            this.sinsterButton.Text = "Sinister";
            this.sinsterButton.UseVisualStyleBackColor = true;
            this.sinsterButton.Click += new System.EventHandler(this.sinsterButton_Click);
            // 
            // dexterButton
            // 
            this.dexterButton.Location = new System.Drawing.Point(167, 68);
            this.dexterButton.Name = "dexterButton";
            this.dexterButton.Size = new System.Drawing.Size(100, 40);
            this.dexterButton.TabIndex = 1;
            this.dexterButton.Text = "Dexter";
            this.dexterButton.UseVisualStyleBackColor = true;
            this.dexterButton.Click += new System.EventHandler(this.dexterButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(286, 68);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(100, 40);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(45, 34);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(192, 20);
            this.textLabel.TabIndex = 4;
            this.textLabel.Text = "Translate Latin to English:";
            // 
            // translatedLabel
            // 
            this.translatedLabel.AutoSize = true;
            this.translatedLabel.Location = new System.Drawing.Point(116, 122);
            this.translatedLabel.Name = "translatedLabel";
            this.translatedLabel.Size = new System.Drawing.Size(0, 20);
            this.translatedLabel.TabIndex = 5;
            this.translatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "English:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translatedLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.dexterButton);
            this.Controls.Add(this.sinsterButton);
            this.Name = "Form1";
            this.Text = "Latin Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sinsterButton;
        private System.Windows.Forms.Button dexterButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label translatedLabel;
        private System.Windows.Forms.Label label1;
    }
}

