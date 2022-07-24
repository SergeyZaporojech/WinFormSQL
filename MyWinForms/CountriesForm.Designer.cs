namespace MyWinForms
{
    partial class CountriesForm
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
            this.dgvCountries = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.CountryIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryFlageImageCol = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCountries
            // 
            this.dgvCountries.AllowUserToAddRows = false;
            this.dgvCountries.AllowUserToDeleteRows = false;
            this.dgvCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryIdCol,
            this.CountryNameCol,
            this.CountryFlageImageCol});
            this.dgvCountries.Location = new System.Drawing.Point(21, 121);
            this.dgvCountries.Name = "dgvCountries";
            this.dgvCountries.ReadOnly = true;
            this.dgvCountries.RowHeadersWidth = 51;
            this.dgvCountries.RowTemplate.Height = 29;
            this.dgvCountries.Size = new System.Drawing.Size(646, 240);
            this.dgvCountries.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(573, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(278, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Змінити";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // CountryIdCol
            // 
            this.CountryIdCol.HeaderText = "Id";
            this.CountryIdCol.MinimumWidth = 6;
            this.CountryIdCol.Name = "CountryIdCol";
            this.CountryIdCol.ReadOnly = true;
            this.CountryIdCol.Visible = false;
            this.CountryIdCol.Width = 125;
            // 
            // CountryNameCol
            // 
            this.CountryNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CountryNameCol.HeaderText = "Name";
            this.CountryNameCol.MinimumWidth = 6;
            this.CountryNameCol.Name = "CountryNameCol";
            this.CountryNameCol.ReadOnly = true;
            // 
            // CountryFlageImageCol
            // 
            this.CountryFlageImageCol.HeaderText = "FlageImage";
            this.CountryFlageImageCol.MinimumWidth = 6;
            this.CountryFlageImageCol.Name = "CountryFlageImageCol";
            this.CountryFlageImageCol.ReadOnly = true;
            this.CountryFlageImageCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CountryFlageImageCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CountryFlageImageCol.Width = 125;
            // 
            // CountriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvCountries);
            this.Name = "CountriesForm";
            this.Text = "Країни";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvCountries;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridViewTextBoxColumn CountryIdCol;
        private DataGridViewTextBoxColumn CountryNameCol;
        private DataGridViewImageColumn CountryFlageImageCol;
    }
}