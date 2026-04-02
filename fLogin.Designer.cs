namespace PasswordManagerV2
{
    partial class fLogin
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblManagerPass = new System.Windows.Forms.Label();
            this.lblEnterPass = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(197, 224);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(128, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // lblManagerPass
            // 
            this.lblManagerPass.AutoSize = true;
            this.lblManagerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblManagerPass.Location = new System.Drawing.Point(55, 57);
            this.lblManagerPass.Name = "lblManagerPass";
            this.lblManagerPass.Size = new System.Drawing.Size(447, 54);
            this.lblManagerPass.TabIndex = 2;
            this.lblManagerPass.Text = "Менеджер паролей";
            // 
            // lblEnterPass
            // 
            this.lblEnterPass.AutoSize = true;
            this.lblEnterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnterPass.Location = new System.Drawing.Point(203, 192);
            this.lblEnterPass.Name = "lblEnterPass";
            this.lblEnterPass.Size = new System.Drawing.Size(114, 17);
            this.lblEnterPass.TabIndex = 3;
            this.lblEnterPass.Text = "Введите пароль";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(225, 275);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 481);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblEnterPass);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblManagerPass);
            this.Name = "fLogin";
            this.Text = "Менеджер паролей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblManagerPass;
        private System.Windows.Forms.Label lblEnterPass;
        private System.Windows.Forms.Button btnEnter;
    }
}

