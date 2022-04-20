namespace Text_Processing_Assignment
{
    partial class Form1
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
            this.numberOfWordsLab = new System.Windows.Forms.Label();
            this.correctCapitilizationLab = new System.Windows.Forms.Label();
            this.numberOfVowelsLab = new System.Windows.Forms.Label();
            this.descriptionLab = new System.Windows.Forms.Label();
            this.sentenceTB = new System.Windows.Forms.TextBox();
            this.numberOfVowelsLabel = new System.Windows.Forms.Label();
            this.correctCapitilizationLabel = new System.Windows.Forms.Label();
            this.numberOfWordsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.computeButton = new System.Windows.Forms.Button();
            this.numberOfWordsActualLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberOfWordsLab
            // 
            this.numberOfWordsLab.AutoSize = true;
            this.numberOfWordsLab.Location = new System.Drawing.Point(12, 248);
            this.numberOfWordsLab.Name = "numberOfWordsLab";
            this.numberOfWordsLab.Size = new System.Drawing.Size(105, 25);
            this.numberOfWordsLab.TabIndex = 0;
            this.numberOfWordsLab.Text = "# Of Words";
            // 
            // correctCapitilizationLab
            // 
            this.correctCapitilizationLab.AutoSize = true;
            this.correctCapitilizationLab.Location = new System.Drawing.Point(300, 248);
            this.correctCapitilizationLab.Name = "correctCapitilizationLab";
            this.correctCapitilizationLab.Size = new System.Drawing.Size(213, 25);
            this.correctCapitilizationLab.TabIndex = 1;
            this.correctCapitilizationLab.Text = "With Correct Captilization";
            this.correctCapitilizationLab.Click += new System.EventHandler(this.correctCapitilizationLab_Click);
            // 
            // numberOfVowelsLab
            // 
            this.numberOfVowelsLab.AutoSize = true;
            this.numberOfVowelsLab.Location = new System.Drawing.Point(676, 248);
            this.numberOfVowelsLab.Name = "numberOfVowelsLab";
            this.numberOfVowelsLab.Size = new System.Drawing.Size(108, 25);
            this.numberOfVowelsLab.TabIndex = 2;
            this.numberOfVowelsLab.Text = "# Of Vowels";
            // 
            // descriptionLab
            // 
            this.descriptionLab.AutoSize = true;
            this.descriptionLab.Location = new System.Drawing.Point(240, 9);
            this.descriptionLab.Name = "descriptionLab";
            this.descriptionLab.Size = new System.Drawing.Size(336, 25);
            this.descriptionLab.TabIndex = 3;
            this.descriptionLab.Text = "Enter A Few Words Or A Sentence Below:";
            // 
            // sentenceTB
            // 
            this.sentenceTB.Location = new System.Drawing.Point(123, 37);
            this.sentenceTB.Multiline = true;
            this.sentenceTB.Name = "sentenceTB";
            this.sentenceTB.Size = new System.Drawing.Size(547, 64);
            this.sentenceTB.TabIndex = 1;
            // 
            // numberOfVowelsLabel
            // 
            this.numberOfVowelsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfVowelsLabel.Location = new System.Drawing.Point(685, 287);
            this.numberOfVowelsLabel.Name = "numberOfVowelsLabel";
            this.numberOfVowelsLabel.Size = new System.Drawing.Size(88, 64);
            this.numberOfVowelsLabel.TabIndex = 5;
            // 
            // correctCapitilizationLabel
            // 
            this.correctCapitilizationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correctCapitilizationLabel.Location = new System.Drawing.Point(123, 287);
            this.correctCapitilizationLabel.Name = "correctCapitilizationLabel";
            this.correctCapitilizationLabel.Size = new System.Drawing.Size(547, 64);
            this.correctCapitilizationLabel.TabIndex = 6;
            this.correctCapitilizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfWordsLabel
            // 
            this.numberOfWordsLabel.AutoSize = true;
            this.numberOfWordsLabel.Location = new System.Drawing.Point(44, 326);
            this.numberOfWordsLabel.Name = "numberOfWordsLabel";
            this.numberOfWordsLabel.Size = new System.Drawing.Size(0, 25);
            this.numberOfWordsLabel.TabIndex = 7;
            this.numberOfWordsLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(672, 363);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 66);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(12, 363);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(115, 66);
            this.computeButton.TabIndex = 2;
            this.computeButton.Text = "Compute";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // numberOfWordsActualLabel
            // 
            this.numberOfWordsActualLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfWordsActualLabel.Location = new System.Drawing.Point(12, 287);
            this.numberOfWordsActualLabel.Name = "numberOfWordsActualLabel";
            this.numberOfWordsActualLabel.Size = new System.Drawing.Size(88, 64);
            this.numberOfWordsActualLabel.TabIndex = 10;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(330, 363);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 66);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.numberOfWordsActualLabel);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.numberOfWordsLabel);
            this.Controls.Add(this.correctCapitilizationLabel);
            this.Controls.Add(this.numberOfVowelsLabel);
            this.Controls.Add(this.sentenceTB);
            this.Controls.Add(this.descriptionLab);
            this.Controls.Add(this.numberOfVowelsLab);
            this.Controls.Add(this.correctCapitilizationLab);
            this.Controls.Add(this.numberOfWordsLab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label numberOfWordsLab;
        private Label correctCapitilizationLab;
        private Label numberOfVowelsLab;
        private Label descriptionLab;
        private TextBox sentenceTB;
        private Label numberOfVowelsLabel;
        private Label correctCapitilizationLabel;
        private Label numberOfWordsLabel;
        private Button exitButton;
        private Button computeButton;
        private Label numberOfWordsActualLabel;
        private Button clearButton;
    }
}