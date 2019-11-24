namespace SFV2RSubtitles
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
            this.openSourceFileButton = new System.Windows.Forms.Button();
            this.selectOutFileButton = new System.Windows.Forms.Button();
            this.inFilePathTextBox = new System.Windows.Forms.TextBox();
            this.outFilePathTextBox = new System.Windows.Forms.TextBox();
            this.defaultPostfixTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changeDefaultPostfixButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openSourceFileButton
            // 
            this.openSourceFileButton.Location = new System.Drawing.Point(683, 22);
            this.openSourceFileButton.Name = "openSourceFileButton";
            this.openSourceFileButton.Size = new System.Drawing.Size(75, 23);
            this.openSourceFileButton.TabIndex = 0;
            this.openSourceFileButton.Text = "Открыть";
            this.openSourceFileButton.UseVisualStyleBackColor = true;
            this.openSourceFileButton.Click += new System.EventHandler(this.openSourceFileButton_Click);
            // 
            // selectOutFileButton
            // 
            this.selectOutFileButton.Location = new System.Drawing.Point(683, 60);
            this.selectOutFileButton.Name = "selectOutFileButton";
            this.selectOutFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectOutFileButton.TabIndex = 1;
            this.selectOutFileButton.Text = "Выбрать";
            this.selectOutFileButton.UseVisualStyleBackColor = true;
            this.selectOutFileButton.Click += new System.EventHandler(this.selectOutFileButton_Click);
            // 
            // inFilePathTextBox
            // 
            this.inFilePathTextBox.Location = new System.Drawing.Point(122, 24);
            this.inFilePathTextBox.Name = "inFilePathTextBox";
            this.inFilePathTextBox.Size = new System.Drawing.Size(545, 20);
            this.inFilePathTextBox.TabIndex = 2;
            // 
            // outFilePathTextBox
            // 
            this.outFilePathTextBox.Location = new System.Drawing.Point(122, 62);
            this.outFilePathTextBox.Name = "outFilePathTextBox";
            this.outFilePathTextBox.Size = new System.Drawing.Size(545, 20);
            this.outFilePathTextBox.TabIndex = 3;
            // 
            // defaultPostfixTextBox
            // 
            this.defaultPostfixTextBox.Location = new System.Drawing.Point(291, 220);
            this.defaultPostfixTextBox.Name = "defaultPostfixTextBox";
            this.defaultPostfixTextBox.Size = new System.Drawing.Size(376, 20);
            this.defaultPostfixTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходный файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Итоговый файл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Постфикс для итогового файла по умолчанию:";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(43, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(700, 2);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // changeDefaultPostfixButton
            // 
            this.changeDefaultPostfixButton.Location = new System.Drawing.Point(683, 218);
            this.changeDefaultPostfixButton.Name = "changeDefaultPostfixButton";
            this.changeDefaultPostfixButton.Size = new System.Drawing.Size(75, 23);
            this.changeDefaultPostfixButton.TabIndex = 9;
            this.changeDefaultPostfixButton.Text = "Изменить";
            this.changeDefaultPostfixButton.UseVisualStyleBackColor = true;
            this.changeDefaultPostfixButton.Click += new System.EventHandler(this.changeDefaultPostfixButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(32, 103);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 84);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "Сделать";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(442, 108);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 11;
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Location = new System.Drawing.Point(145, 103);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(613, 84);
            this.logRichTextBox.TabIndex = 12;
            this.logRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 271);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.changeDefaultPostfixButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defaultPostfixTextBox);
            this.Controls.Add(this.outFilePathTextBox);
            this.Controls.Add(this.inFilePathTextBox);
            this.Controls.Add(this.selectOutFileButton);
            this.Controls.Add(this.openSourceFileButton);
            this.Name = "Form1";
            this.Text = "SFV2RSubtitles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openSourceFileButton;
        private System.Windows.Forms.Button selectOutFileButton;
        private System.Windows.Forms.TextBox inFilePathTextBox;
        private System.Windows.Forms.TextBox outFilePathTextBox;
        private System.Windows.Forms.TextBox defaultPostfixTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changeDefaultPostfixButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.RichTextBox logRichTextBox;
    }
}

