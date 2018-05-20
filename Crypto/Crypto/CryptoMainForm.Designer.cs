namespace Crypto
{
    partial class CryptoMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveEncryptedFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SessionKey = new System.Windows.Forms.Label();
            this.GenerateDS = new System.Windows.Forms.Button();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.SaveDecryptedFile = new System.Windows.Forms.Button();
            this.DigitalSignature = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckDS = new System.Windows.Forms.Button();
            this.DecryptSessionKey = new System.Windows.Forms.Button();
            this.EncryptSessionKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveEncryptedFile
            // 
            this.SaveEncryptedFile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveEncryptedFile.Location = new System.Drawing.Point(394, 118);
            this.SaveEncryptedFile.Name = "SaveEncryptedFile";
            this.SaveEncryptedFile.Size = new System.Drawing.Size(162, 32);
            this.SaveEncryptedFile.TabIndex = 1;
            this.SaveEncryptedFile.Text = "Зашифровать";
            this.SaveEncryptedFile.UseVisualStyleBackColor = true;
            this.SaveEncryptedFile.Click += new System.EventHandler(this.SaveEncryptedFile_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сеансовый ключ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SessionKey
            // 
            this.SessionKey.BackColor = System.Drawing.Color.White;
            this.SessionKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SessionKey.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SessionKey.Location = new System.Drawing.Point(171, 9);
            this.SessionKey.Name = "SessionKey";
            this.SessionKey.Size = new System.Drawing.Size(554, 32);
            this.SessionKey.TabIndex = 4;
            this.SessionKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateDS
            // 
            this.GenerateDS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateDS.Location = new System.Drawing.Point(394, 231);
            this.GenerateDS.Name = "GenerateDS";
            this.GenerateDS.Size = new System.Drawing.Size(162, 32);
            this.GenerateDS.TabIndex = 6;
            this.GenerateDS.Text = "Сгенерировать";
            this.GenerateDS.UseVisualStyleBackColor = true;
            this.GenerateDS.Click += new System.EventHandler(this.GenerateDS_Click);
            // 
            // ChooseFile
            // 
            this.ChooseFile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseFile.Location = new System.Drawing.Point(11, 82);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(162, 32);
            this.ChooseFile.TabIndex = 11;
            this.ChooseFile.Text = "Выбрать файл";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // SaveDecryptedFile
            // 
            this.SaveDecryptedFile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveDecryptedFile.Location = new System.Drawing.Point(563, 118);
            this.SaveDecryptedFile.Name = "SaveDecryptedFile";
            this.SaveDecryptedFile.Size = new System.Drawing.Size(162, 32);
            this.SaveDecryptedFile.TabIndex = 12;
            this.SaveDecryptedFile.Text = "Расшифровать";
            this.SaveDecryptedFile.UseVisualStyleBackColor = true;
            this.SaveDecryptedFile.Click += new System.EventHandler(this.SaveDecryptedFile_Click);
            // 
            // DigitalSignature
            // 
            this.DigitalSignature.BackColor = System.Drawing.Color.White;
            this.DigitalSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DigitalSignature.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DigitalSignature.Location = new System.Drawing.Point(171, 155);
            this.DigitalSignature.Name = "DigitalSignature";
            this.DigitalSignature.Size = new System.Drawing.Size(554, 32);
            this.DigitalSignature.TabIndex = 14;
            this.DigitalSignature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilePath
            // 
            this.FilePath.BackColor = System.Drawing.Color.White;
            this.FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilePath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePath.Location = new System.Drawing.Point(171, 82);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(554, 32);
            this.FilePath.TabIndex = 15;
            this.FilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Цифровая подпись";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckDS
            // 
            this.CheckDS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckDS.Location = new System.Drawing.Point(563, 231);
            this.CheckDS.Name = "CheckDS";
            this.CheckDS.Size = new System.Drawing.Size(162, 32);
            this.CheckDS.TabIndex = 13;
            this.CheckDS.Text = "Проверить";
            this.CheckDS.UseVisualStyleBackColor = true;
            this.CheckDS.Click += new System.EventHandler(this.CheckDS_Click);
            // 
            // DecryptSessionKey
            // 
            this.DecryptSessionKey.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecryptSessionKey.Location = new System.Drawing.Point(563, 45);
            this.DecryptSessionKey.Name = "DecryptSessionKey";
            this.DecryptSessionKey.Size = new System.Drawing.Size(162, 32);
            this.DecryptSessionKey.TabIndex = 18;
            this.DecryptSessionKey.Text = "Расшифровать";
            this.DecryptSessionKey.UseVisualStyleBackColor = true;
            this.DecryptSessionKey.Click += new System.EventHandler(this.DecryptSessionKey_Click);
            // 
            // EncryptSessionKey
            // 
            this.EncryptSessionKey.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptSessionKey.Location = new System.Drawing.Point(394, 45);
            this.EncryptSessionKey.Name = "EncryptSessionKey";
            this.EncryptSessionKey.Size = new System.Drawing.Size(162, 32);
            this.EncryptSessionKey.TabIndex = 17;
            this.EncryptSessionKey.Text = "Зашифровать";
            this.EncryptSessionKey.UseVisualStyleBackColor = true;
            this.EncryptSessionKey.Click += new System.EventHandler(this.EncryptSessionKey_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ключ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(171, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(554, 32);
            this.label3.TabIndex = 19;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CryptoMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DecryptSessionKey);
            this.Controls.Add(this.EncryptSessionKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.DigitalSignature);
            this.Controls.Add(this.CheckDS);
            this.Controls.Add(this.SaveDecryptedFile);
            this.Controls.Add(this.ChooseFile);
            this.Controls.Add(this.GenerateDS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SessionKey);
            this.Controls.Add(this.SaveEncryptedFile);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CryptoMainForm";
            this.Text = "Crypto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button SaveEncryptedFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SessionKey;
        private System.Windows.Forms.Button GenerateDS;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.Button SaveDecryptedFile;
        private System.Windows.Forms.Label DigitalSignature;
        private System.Windows.Forms.Label FilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CheckDS;
        private System.Windows.Forms.Button DecryptSessionKey;
        private System.Windows.Forms.Button EncryptSessionKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

