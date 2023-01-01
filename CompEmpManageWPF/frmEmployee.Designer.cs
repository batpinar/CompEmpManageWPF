namespace CompEmpManageWPF
{
    partial class frmEmployee
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.compEmpManageWPFDataSet = new CompEmpManageWPF.CompEmpManageWPFDataSet();
            this.compEmpManageWPFDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCompId = new System.Windows.Forms.TextBox();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identitiyNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compEmpManageWPFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compEmpManageWPFDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.identitiyNumberCol,
            this.firstNameCol,
            this.lastNameCol,
            this.companyIdCol});
            this.dgvEmployee.GridColor = System.Drawing.Color.SlateGray;
            this.dgvEmployee.Location = new System.Drawing.Point(325, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(747, 587);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(307, 22);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "Identity Number..";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 22);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "First Name..";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(12, 156);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(307, 22);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.Text = "Last Name";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(197, 234);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(122, 38);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 234);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(122, 38);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 278);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 38);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // compEmpManageWPFDataSet
            // 
            this.compEmpManageWPFDataSet.DataSetName = "CompEmpManageWPFDataSet";
            this.compEmpManageWPFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compEmpManageWPFDataSetBindingSource
            // 
            this.compEmpManageWPFDataSetBindingSource.DataSource = this.compEmpManageWPFDataSet;
            this.compEmpManageWPFDataSetBindingSource.Position = 0;
            // 
            // txtCompId
            // 
            this.txtCompId.Location = new System.Drawing.Point(12, 194);
            this.txtCompId.Name = "txtCompId";
            this.txtCompId.Size = new System.Drawing.Size(307, 22);
            this.txtCompId.TabIndex = 15;
            this.txtCompId.Text = "Company Id";
            // 
            // idCol
            // 
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            // 
            // identitiyNumberCol
            // 
            this.identitiyNumberCol.HeaderText = "IdentitiyNumber";
            this.identitiyNumberCol.Name = "identitiyNumberCol";
            // 
            // firstNameCol
            // 
            this.firstNameCol.HeaderText = "First Name";
            this.firstNameCol.Name = "firstNameCol";
            // 
            // lastNameCol
            // 
            this.lastNameCol.HeaderText = "Last Name";
            this.lastNameCol.Name = "lastNameCol";
            // 
            // companyIdCol
            // 
            this.companyIdCol.HeaderText = "Company ID";
            this.companyIdCol.Name = "companyIdCol";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.txtCompId);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvEmployee);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compEmpManageWPFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compEmpManageWPFDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.BindingSource compEmpManageWPFDataSetBindingSource;
        private CompEmpManageWPFDataSet compEmpManageWPFDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn identitiyNumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIdCol;
        private System.Windows.Forms.TextBox txtCompId;
    }
}