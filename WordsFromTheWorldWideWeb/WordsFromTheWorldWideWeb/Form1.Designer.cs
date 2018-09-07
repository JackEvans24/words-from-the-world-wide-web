namespace WordsFromTheWorldWideWeb
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
            this.StartStopButton = new System.Windows.Forms.Button();
            this.DisplayTextbox = new System.Windows.Forms.RichTextBox();
            this.WordInfoLabel = new System.Windows.Forms.Label();
            this.TermInfoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartStopButton
            // 
            this.StartStopButton.BackColor = System.Drawing.Color.White;
            this.StartStopButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStopButton.ForeColor = System.Drawing.Color.Teal;
            this.StartStopButton.Location = new System.Drawing.Point(150, 377);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(140, 39);
            this.StartStopButton.TabIndex = 0;
            this.StartStopButton.Text = "Start";
            this.StartStopButton.UseVisualStyleBackColor = false;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // DisplayTextbox
            // 
            this.DisplayTextbox.BackColor = System.Drawing.Color.White;
            this.DisplayTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTextbox.ForeColor = System.Drawing.Color.Teal;
            this.DisplayTextbox.Location = new System.Drawing.Point(13, 88);
            this.DisplayTextbox.Name = "DisplayTextbox";
            this.DisplayTextbox.ReadOnly = true;
            this.DisplayTextbox.Size = new System.Drawing.Size(398, 274);
            this.DisplayTextbox.TabIndex = 1;
            this.DisplayTextbox.Text = "";
            // 
            // WordInfoLabel
            // 
            this.WordInfoLabel.AutoSize = true;
            this.WordInfoLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordInfoLabel.ForeColor = System.Drawing.Color.Teal;
            this.WordInfoLabel.Location = new System.Drawing.Point(108, 11);
            this.WordInfoLabel.Name = "WordInfoLabel";
            this.WordInfoLabel.Size = new System.Drawing.Size(197, 24);
            this.WordInfoLabel.TabIndex = 2;
            this.WordInfoLabel.Text = "Pulled 0 unique words";
            // 
            // TermInfoLabel
            // 
            this.TermInfoLabel.AutoSize = true;
            this.TermInfoLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermInfoLabel.ForeColor = System.Drawing.Color.Teal;
            this.TermInfoLabel.Location = new System.Drawing.Point(77, 35);
            this.TermInfoLabel.Name = "TermInfoLabel";
            this.TermInfoLabel.Size = new System.Drawing.Size(259, 24);
            this.TermInfoLabel.TabIndex = 3;
            this.TermInfoLabel.Text = "using 0 different search terms";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WordInfoLabel);
            this.panel1.Controls.Add(this.TermInfoLabel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 69);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(424, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DisplayTextbox);
            this.Controls.Add(this.StartStopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Words from the Web";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.RichTextBox DisplayTextbox;
        private System.Windows.Forms.Label WordInfoLabel;
        private System.Windows.Forms.Label TermInfoLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

