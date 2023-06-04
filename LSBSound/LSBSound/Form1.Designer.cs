namespace LSBSound
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
             this.imageBox = new System.Windows.Forms.PictureBox();
             this.label1 = new System.Windows.Forms.Label();
             this.encryptButton = new System.Windows.Forms.Button();
             this.decryptButton = new System.Windows.Forms.Button();
             this.loadDialog = new System.Windows.Forms.OpenFileDialog();
             this.saveDialog = new System.Windows.Forms.SaveFileDialog();
             this.console = new System.Windows.Forms.ListBox();
             this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
             this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
             this.textBox = new System.Windows.Forms.RichTextBox();
             this.label2 = new System.Windows.Forms.Label();
             this.loadWavFile = new System.Windows.Forms.Button();
             this.loadWav = new System.Windows.Forms.OpenFileDialog();
             this.saveWav = new System.Windows.Forms.SaveFileDialog();
             this.audioLabel = new System.Windows.Forms.Label();
             this.button1 = new System.Windows.Forms.Button();
             this.label3 = new System.Windows.Forms.Label();
             ((System.ComponentModel.ISupportInitialize) (this.imageBox)).BeginInit();
             this.SuspendLayout();
             // 
             // imageBox
             // 
             this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
             this.imageBox.Location = new System.Drawing.Point(14, 29);
             this.imageBox.Name = "imageBox";
             this.imageBox.Size = new System.Drawing.Size(247, 115);
             this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
             this.imageBox.TabIndex = 0;
             this.imageBox.TabStop = false;
             // 
             // label1
             // 
             this.label1.AutoSize = true;
             this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.label1.Location = new System.Drawing.Point(279, 7);
             this.label1.Name = "label1";
             this.label1.Size = new System.Drawing.Size(238, 20);
             this.label1.TabIndex = 2;
             this.label1.Text = "Текст скрытого сообщения";
             // 
             // encryptButton
             // 
             this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.encryptButton.Location = new System.Drawing.Point(279, 150);
             this.encryptButton.Name = "encryptButton";
             this.encryptButton.Size = new System.Drawing.Size(202, 34);
             this.encryptButton.TabIndex = 4;
             this.encryptButton.Text = "Зашифровать строку";
             this.encryptButton.UseVisualStyleBackColor = true;
             this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
             // 
             // decryptButton
             // 
             this.decryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.decryptButton.Location = new System.Drawing.Point(487, 150);
             this.decryptButton.Name = "decryptButton";
             this.decryptButton.Size = new System.Drawing.Size(199, 34);
             this.decryptButton.TabIndex = 5;
             this.decryptButton.Text = "Расшифровать строку";
             this.decryptButton.UseVisualStyleBackColor = true;
             this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
             // 
             // loadDialog
             // 
             this.loadDialog.FileName = ".*";
             this.loadDialog.Filter = "Image Files (*.bmp,*.jpg,*.png)|*.bmp,*.jpg,*.png";
             // 
             // saveDialog
             // 
             this.saveDialog.Filter = "Image Files (*.bmp,*.png)|*.bmp,*.png";
             // 
             // console
             // 
             this.console.FormattingEnabled = true;
             this.console.Location = new System.Drawing.Point(20, 224);
             this.console.Name = "console";
             this.console.Size = new System.Drawing.Size(825, 173);
             this.console.TabIndex = 6;
             this.console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.console_KeyDown);
             this.console.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.console_MouseDoubleClick);
             // 
             // loadFileDialog
             // 
             this.loadFileDialog.FileName = ".*";
             this.loadFileDialog.Filter = "Any file (*.*) | *.*";
             // 
             // textBox
             // 
             this.textBox.Location = new System.Drawing.Point(282, 28);
             this.textBox.Name = "textBox";
             this.textBox.Size = new System.Drawing.Size(563, 116);
             this.textBox.TabIndex = 12;
             this.textBox.Text = "";
             // 
             // label2
             // 
             this.label2.AutoSize = true;
             this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.label2.Location = new System.Drawing.Point(14, 201);
             this.label2.Name = "label2";
             this.label2.Size = new System.Drawing.Size(165, 20);
             this.label2.TabIndex = 13;
             this.label2.Text = "Журнал состояния";
             // 
             // loadWavFile
             // 
             this.loadWavFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.loadWavFile.Location = new System.Drawing.Point(12, 150);
             this.loadWavFile.Name = "loadWavFile";
             this.loadWavFile.Size = new System.Drawing.Size(247, 34);
             this.loadWavFile.TabIndex = 14;
             this.loadWavFile.Text = "Загрузка Wav-файла";
             this.loadWavFile.UseVisualStyleBackColor = true;
             this.loadWavFile.Click += new System.EventHandler(this.loadWavFile_Click);
             // 
             // loadWav
             // 
             this.loadWav.FileName = "*.wav";
             this.loadWav.Filter = "Wav File (*.wav) | *.wav";
             // 
             // saveWav
             // 
             this.saveWav.FileName = "*.wav";
             this.saveWav.Filter = "Wav File (*.wav) | *.wav";
             // 
             // audioLabel
             // 
             this.audioLabel.Location = new System.Drawing.Point(20, 36);
             this.audioLabel.Name = "audioLabel";
             this.audioLabel.Size = new System.Drawing.Size(233, 97);
             this.audioLabel.TabIndex = 15;
             this.audioLabel.Visible = false;
             // 
             // button1
             // 
             this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.button1.Location = new System.Drawing.Point(692, 150);
             this.button1.Name = "button1";
             this.button1.Size = new System.Drawing.Size(153, 34);
             this.button1.TabIndex = 16;
             this.button1.Text = "Очистить строку";
             this.button1.UseVisualStyleBackColor = true;
             this.button1.Click += new System.EventHandler(this.button1_Click);
             // 
             // label3
             // 
             this.label3.AutoSize = true;
             this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
             this.label3.Location = new System.Drawing.Point(10, 7);
             this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
             this.label3.Name = "label3";
             this.label3.Size = new System.Drawing.Size(203, 20);
             this.label3.TabIndex = 17;
             this.label3.Text = "Название аудиофайла";
             // 
             // Form1
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.AutoSize = true;
             this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
             this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
             this.ClientSize = new System.Drawing.Size(855, 411);
             this.Controls.Add(this.label3);
             this.Controls.Add(this.button1);
             this.Controls.Add(this.audioLabel);
             this.Controls.Add(this.loadWavFile);
             this.Controls.Add(this.label2);
             this.Controls.Add(this.textBox);
             this.Controls.Add(this.console);
             this.Controls.Add(this.decryptButton);
             this.Controls.Add(this.encryptButton);
             this.Controls.Add(this.label1);
             this.Controls.Add(this.imageBox);
             this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
             this.MaximizeBox = false;
             this.Name = "Form1";
             this.Text = "LSBSound";
             ((System.ComponentModel.ISupportInitialize) (this.imageBox)).EndInit();
             this.ResumeLayout(false);
             this.PerformLayout();
         }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.OpenFileDialog loadDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ListBox console;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadWavFile;
        private System.Windows.Forms.OpenFileDialog loadWav;
        private System.Windows.Forms.SaveFileDialog saveWav;
        private System.Windows.Forms.Label audioLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;

    }
}