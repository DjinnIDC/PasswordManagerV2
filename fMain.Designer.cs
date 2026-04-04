namespace PasswordManagerV2
{
    partial class fMain
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
            this.dgvNames = new System.Windows.Forms.DataGridView();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTogglePasswordVisibility = new System.Windows.Forms.Button();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNewLogin = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblLoginPass2 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNames)).BeginInit();
            this.pnlTools.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNames
            // 
            this.dgvNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNames.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNames.Location = new System.Drawing.Point(0, 50);
            this.dgvNames.Margin = new System.Windows.Forms.Padding(0);
            this.dgvNames.Name = "dgvNames";
            this.dgvNames.Size = new System.Drawing.Size(212, 712);
            this.dgvNames.TabIndex = 0;
            this.dgvNames.SelectionChanged += new System.EventHandler(this.dgvNames_SelectionChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(24, 29);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(199, 26);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(202, 63);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(27, 63);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '*';
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // pnlTools
            // 
            this.pnlTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTools.Controls.Add(this.btnDelete);
            this.pnlTools.Controls.Add(this.btnAdd);
            this.pnlTools.Controls.Add(this.btnTogglePasswordVisibility);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(598, 50);
            this.pnlTools.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(92, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTogglePasswordVisibility
            // 
            this.btnTogglePasswordVisibility.ImageKey = "(отсутствует)";
            this.btnTogglePasswordVisibility.Location = new System.Drawing.Point(553, 5);
            this.btnTogglePasswordVisibility.Margin = new System.Windows.Forms.Padding(5);
            this.btnTogglePasswordVisibility.Name = "btnTogglePasswordVisibility";
            this.btnTogglePasswordVisibility.Size = new System.Drawing.Size(40, 40);
            this.btnTogglePasswordVisibility.TabIndex = 0;
            this.btnTogglePasswordVisibility.Tag = "active";
            this.btnTogglePasswordVisibility.UseVisualStyleBackColor = true;
            this.btnTogglePasswordVisibility.Click += new System.EventHandler(this.btnTogglePasswordVisibility_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Controls.Add(this.btnCancelAdd);
            this.pnlAdd.Controls.Add(this.txtNewName);
            this.pnlAdd.Controls.Add(this.lblName);
            this.pnlAdd.Controls.Add(this.txtNewLogin);
            this.pnlAdd.Controls.Add(this.btnSave);
            this.pnlAdd.Controls.Add(this.lblLogin2);
            this.pnlAdd.Controls.Add(this.txtNewPassword);
            this.pnlAdd.Controls.Add(this.lblLoginPass2);
            this.pnlAdd.Location = new System.Drawing.Point(212, 50);
            this.pnlAdd.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(386, 713);
            this.pnlAdd.TabIndex = 6;
            this.pnlAdd.Visible = false;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(106, 135);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAdd.TabIndex = 4;
            this.btnCancelAdd.Text = "Отмена";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(18, 63);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(100, 20);
            this.txtNewName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(15, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 17);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Название";
            // 
            // txtNewLogin
            // 
            this.txtNewLogin.Location = new System.Drawing.Point(137, 63);
            this.txtNewLogin.Name = "txtNewLogin";
            this.txtNewLogin.Size = new System.Drawing.Size(100, 20);
            this.txtNewLogin.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLogin2
            // 
            this.lblLogin2.AutoSize = true;
            this.lblLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin2.Location = new System.Drawing.Point(134, 29);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(47, 17);
            this.lblLogin2.TabIndex = 7;
            this.lblLogin2.Text = "Логин";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(253, 63);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(100, 20);
            this.txtNewPassword.TabIndex = 3;
            // 
            // lblLoginPass2
            // 
            this.lblLoginPass2.AutoSize = true;
            this.lblLoginPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoginPass2.Location = new System.Drawing.Point(250, 29);
            this.lblLoginPass2.Name = "lblLoginPass2";
            this.lblLoginPass2.Size = new System.Drawing.Size(57, 17);
            this.lblLoginPass2.TabIndex = 8;
            this.lblLoginPass2.Text = "Пароль";
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblLogin);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Controls.Add(this.txtLogin);
            this.pnlMain.Location = new System.Drawing.Point(213, 50);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(385, 713);
            this.pnlMain.TabIndex = 7;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 762);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.dgvNames);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTools);
            this.Name = "fMain";
            this.Text = "fMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNames)).EndInit();
            this.pnlTools.ResumeLayout(false);
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNames;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnTogglePasswordVisibility;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.TextBox txtNewLogin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLogin2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblLoginPass2;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancelAdd;
    }
}