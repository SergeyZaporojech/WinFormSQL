namespace MyWinForms
{
    partial class MainForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.UserIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserImageCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(772, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 44);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIdCol,
            this.UserImageCol,
            this.UserNameCol,
            this.UserEmailCol,
            this.UserPhoneCol});
            this.dgvUsers.Location = new System.Drawing.Point(2, 116);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 100;
            this.dgvUsers.Size = new System.Drawing.Size(1163, 320);
            this.dgvUsers.TabIndex = 1;
            // 
            // UserIdCol
            // 
            this.UserIdCol.HeaderText = "Id";
            this.UserIdCol.MinimumWidth = 6;
            this.UserIdCol.Name = "UserIdCol";
            this.UserIdCol.ReadOnly = true;
            this.UserIdCol.Visible = false;
            this.UserIdCol.Width = 125;
            // 
            // UserImageCol
            // 
            this.UserImageCol.HeaderText = "Фото";
            this.UserImageCol.MinimumWidth = 6;
            this.UserImageCol.Name = "UserImageCol";
            this.UserImageCol.ReadOnly = true;
            this.UserImageCol.Width = 125;
            // 
            // UserNameCol
            // 
            this.UserNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserNameCol.HeaderText = "ПІБ";
            this.UserNameCol.MinimumWidth = 6;
            this.UserNameCol.Name = "UserNameCol";
            this.UserNameCol.ReadOnly = true;
            // 
            // UserEmailCol
            // 
            this.UserEmailCol.HeaderText = "Пошта";
            this.UserEmailCol.MinimumWidth = 6;
            this.UserEmailCol.Name = "UserEmailCol";
            this.UserEmailCol.ReadOnly = true;
            this.UserEmailCol.Width = 150;
            // 
            // UserPhoneCol
            // 
            this.UserPhoneCol.HeaderText = "Телефон";
            this.UserPhoneCol.MinimumWidth = 6;
            this.UserPhoneCol.Name = "UserPhoneCol";
            this.UserPhoneCol.ReadOnly = true;
            this.UserPhoneCol.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(358, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1042, 442);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 52);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(26, 442);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(123, 52);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(26, 62);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 48);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Змінити";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 506);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnSearch);
            this.Name = "MainForm";
            this.Text = "Головне вікно";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSearch;
        private Button btnAdd;
        private DataGridView dgvUsers;
        private Button btnDelete;
        private Button btnNext;
        private Button btnPrev;
        private DataGridViewTextBoxColumn UserIdCol;
        private DataGridViewImageColumn UserImageCol;
        private DataGridViewTextBoxColumn UserNameCol;
        private DataGridViewTextBoxColumn UserEmailCol;
        private DataGridViewTextBoxColumn UserPhoneCol;
        private Button btnEdit;
    }
}