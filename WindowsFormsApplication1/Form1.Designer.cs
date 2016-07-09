namespace WindowsFormsApplication1
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
            this.questionText = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.WhatWasIt = new System.Windows.Forms.Label();
            this.SubmitBox = new System.Windows.Forms.TextBox();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.AnotherQuestion = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionText
            // 
            this.questionText.AutoSize = true;
            this.questionText.Location = new System.Drawing.Point(28, 30);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(46, 17);
            this.questionText.TabIndex = 0;
            this.questionText.Text = "label1";
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(196, 27);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 23);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(196, 65);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // WhatWasIt
            // 
            this.WhatWasIt.AutoSize = true;
            this.WhatWasIt.Location = new System.Drawing.Point(28, 115);
            this.WhatWasIt.Name = "WhatWasIt";
            this.WhatWasIt.Size = new System.Drawing.Size(88, 17);
            this.WhatWasIt.TabIndex = 3;
            this.WhatWasIt.Text = "What was it?";
            // 
            // SubmitBox
            // 
            this.SubmitBox.Location = new System.Drawing.Point(122, 115);
            this.SubmitBox.Name = "SubmitBox";
            this.SubmitBox.ReadOnly = true;
            this.SubmitBox.Size = new System.Drawing.Size(149, 22);
            this.SubmitBox.TabIndex = 4;
            // 
            // QuestionBox
            // 
            this.QuestionBox.Location = new System.Drawing.Point(31, 182);
            this.QuestionBox.Multiline = true;
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.ReadOnly = true;
            this.QuestionBox.Size = new System.Drawing.Size(240, 41);
            this.QuestionBox.TabIndex = 6;
            // 
            // AnotherQuestion
            // 
            this.AnotherQuestion.AutoSize = true;
            this.AnotherQuestion.Location = new System.Drawing.Point(28, 162);
            this.AnotherQuestion.Name = "AnotherQuestion";
            this.AnotherQuestion.Size = new System.Drawing.Size(175, 17);
            this.AnotherQuestion.TabIndex = 5;
            this.AnotherQuestion.Text = "Give me another question:";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(196, 229);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(115, 229);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 272);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.AnotherQuestion);
            this.Controls.Add(this.SubmitBox);
            this.Controls.Add(this.WhatWasIt);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.questionText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label WhatWasIt;
        private System.Windows.Forms.TextBox SubmitBox;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.Label AnotherQuestion;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button SubmitButton;
    }
}

