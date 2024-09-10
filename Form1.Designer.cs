namespace WootenT_PigLatin
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.enterSentenceLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.translationLabel = new System.Windows.Forms.Label();
            this.outcomelabel = new System.Windows.Forms.Label();
            this.translateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(132, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(248, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Pig Latin Translator";
            // 
            // enterSentenceLabel
            // 
            this.enterSentenceLabel.AutoSize = true;
            this.enterSentenceLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.enterSentenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterSentenceLabel.Location = new System.Drawing.Point(159, 78);
            this.enterSentenceLabel.Name = "enterSentenceLabel";
            this.enterSentenceLabel.Size = new System.Drawing.Size(190, 24);
            this.enterSentenceLabel.TabIndex = 1;
            this.enterSentenceLabel.Text = "Enter your sentence: ";
            this.enterSentenceLabel.Click += new System.EventHandler(this.enterSentenceLabel_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(12, 113);
            this.userTextBox.Multiline = true;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(468, 32);
            this.userTextBox.TabIndex = 2;
            this.userTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.translationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLabel.Location = new System.Drawing.Point(182, 152);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(139, 29);
            this.translationLabel.TabIndex = 3;
            this.translationLabel.Text = "Translation:";
            // 
            // outcomelabel
            // 
            this.outcomelabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outcomelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outcomelabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.outcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcomelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outcomelabel.Location = new System.Drawing.Point(12, 190);
            this.outcomelabel.Name = "outcomelabel";
            this.outcomelabel.Size = new System.Drawing.Size(480, 92);
            this.outcomelabel.TabIndex = 4;
            this.outcomelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // translateButton
            // 
            this.translateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateButton.Location = new System.Drawing.Point(45, 320);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(118, 33);
            this.translateButton.TabIndex = 5;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(192, 320);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 33);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(346, 320);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 33);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.translateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.outcomelabel);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.enterSentenceLabel);
            this.Controls.Add(this.titleLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Pig Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label enterSentenceLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Label outcomelabel;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

