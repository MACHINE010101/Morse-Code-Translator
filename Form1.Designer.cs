namespace Translator_Morse_Code
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.translateTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.translateButton = new System.Windows.Forms.Button();
            this.abcLabel = new System.Windows.Forms.Label();
            this.morseLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.translatedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // translateTextBox
            // 
            this.translateTextBox.BackColor = System.Drawing.Color.PowderBlue;
            this.translateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translateTextBox.Location = new System.Drawing.Point(66, 125);
            this.translateTextBox.Multiline = true;
            this.translateTextBox.Name = "translateTextBox";
            this.translateTextBox.Size = new System.Drawing.Size(339, 278);
            this.translateTextBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(348, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(308, 37);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Morse Code Translator";
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(464, 228);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(103, 55);
            this.translateButton.TabIndex = 3;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // abcLabel
            // 
            this.abcLabel.AutoSize = true;
            this.abcLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.abcLabel.ForeColor = System.Drawing.Color.White;
            this.abcLabel.Location = new System.Drawing.Point(66, 85);
            this.abcLabel.Name = "abcLabel";
            this.abcLabel.Size = new System.Drawing.Size(70, 37);
            this.abcLabel.TabIndex = 4;
            this.abcLabel.Text = "ABC";
            // 
            // morseLabel
            // 
            this.morseLabel.AutoSize = true;
            this.morseLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.morseLabel.ForeColor = System.Drawing.Color.White;
            this.morseLabel.Location = new System.Drawing.Point(624, 85);
            this.morseLabel.Name = "morseLabel";
            this.morseLabel.Size = new System.Drawing.Size(64, 37);
            this.morseLabel.TabIndex = 5;
            this.morseLabel.Text = "**_*";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(751, 409);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(103, 55);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // translatedTextBox
            // 
            this.translatedTextBox.BackColor = System.Drawing.Color.PowderBlue;
            this.translatedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translatedTextBox.Location = new System.Drawing.Point(624, 125);
            this.translatedTextBox.Multiline = true;
            this.translatedTextBox.Name = "translatedTextBox";
            this.translatedTextBox.Size = new System.Drawing.Size(339, 278);
            this.translatedTextBox.TabIndex = 7;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1028, 500);
            this.Controls.Add(this.translatedTextBox);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.morseLabel);
            this.Controls.Add(this.abcLabel);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.translateTextBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox translateTextBox;
        private Label titleLabel;
        private Button translateButton;
        private Label abcLabel;
        private Label morseLabel;
        private Button playButton;
        private TextBox translatedTextBox;
    }
}