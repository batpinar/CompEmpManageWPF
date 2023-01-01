namespace CompEmpManageWPF
{
    partial class frmCompany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCompany = new System.Windows.Forms.DataGridView();
            this.idCompCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxOfficeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createButton = new System.Windows.Forms.Button();
            this.txtTaxOffice = new System.Windows.Forms.TextBox();
            this.txtTaxNumber = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtAddresses = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompany
            // 
            this.dgvCompany.AllowUserToOrderColumns = true;
            this.dgvCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompCol,
            this.companyNameCol,
            this.taxNumberCol,
            this.taxOfficeCol,
            this.addressesCol});
            this.dgvCompany.GridColor = System.Drawing.Color.SlateGray;
            this.dgvCompany.Location = new System.Drawing.Point(335, 12);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.RowTemplate.Height = 24;
            this.dgvCompany.Size = new System.Drawing.Size(747, 587);
            this.dgvCompany.TabIndex = 1;
            this.dgvCompany.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompany_CellContentClick);
            // 
            // idCompCol
            // 
            this.idCompCol.HeaderText = "ID";
            this.idCompCol.Name = "idCompCol";
            // 
            // companyNameCol
            // 
            this.companyNameCol.HeaderText = "Company Name";
            this.companyNameCol.Name = "companyNameCol";
            // 
            // taxNumberCol
            // 
            this.taxNumberCol.HeaderText = "Tax Number";
            this.taxNumberCol.Name = "taxNumberCol";
            // 
            // taxOfficeCol
            // 
            this.taxOfficeCol.HeaderText = "Tax Office";
            this.taxOfficeCol.Name = "taxOfficeCol";
            // 
            // addressesCol
            // 
            this.addressesCol.HeaderText = "Addresses";
            this.addressesCol.Name = "addressesCol";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(207, 240);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(122, 38);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // txtTaxOffice
            // 
            this.txtTaxOffice.Location = new System.Drawing.Point(22, 162);
            this.txtTaxOffice.Name = "txtTaxOffice";
            this.txtTaxOffice.Size = new System.Drawing.Size(307, 22);
            this.txtTaxOffice.TabIndex = 9;
            this.txtTaxOffice.Text = "Tax Office..";
            // 
            // txtTaxNumber
            // 
            this.txtTaxNumber.Location = new System.Drawing.Point(22, 114);
            this.txtTaxNumber.Name = "txtTaxNumber";
            this.txtTaxNumber.Size = new System.Drawing.Size(307, 22);
            this.txtTaxNumber.TabIndex = 8;
            this.txtTaxNumber.Text = "Tax Number..";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(22, 67);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(307, 22);
            this.txtCompanyName.TabIndex = 7;
            this.txtCompanyName.Text = "Company Name..";
            // 
            // txtAddresses
            // 
            this.txtAddresses.Location = new System.Drawing.Point(22, 212);
            this.txtAddresses.Name = "txtAddresses";
            this.txtAddresses.Size = new System.Drawing.Size(307, 22);
            this.txtAddresses.TabIndex = 11;
            this.txtAddresses.Text = "Addresses..";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(22, 240);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(122, 38);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(22, 284);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 38);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.txtAddresses);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.txtTaxOffice);
            this.Controls.Add(this.txtTaxNumber);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.dgvCompany);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "frmCompany";
            this.Text = "frmCompany";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompany;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox txtTaxOffice;
        private System.Windows.Forms.TextBox txtTaxNumber;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtAddresses;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxNumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxOfficeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressesCol;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
    }
}