using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompEmpManageWPF
{
    public partial class frmCompany : Form
    {
        CEMEntities dbContext = new CEMEntities();
        public frmCompany()
        {
            InitializeComponent();
        }
        private void frmCompany_Load(object sender, EventArgs e)
        {
            dgvCompany.Columns.Clear();
            dgvCompany.DataSource = dbContext.Companies.ToList();
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            Companies company = new Companies();

            company.CompanyName = txtCompanyName.Text;
            company.TaxNumnber = txtTaxNumber.Text;
            company.TaxOffice = txtTaxOffice.Text;
            company.Addresses = txtAddresses.Text;

            dbContext.Companies.Add(company);
            dbContext.SaveChanges();

            dgvCompany.Columns.Clear();
            dgvCompany.DataSource = dbContext.Companies.ToList();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCompany.CurrentRow.Cells[0].Value.ToString());

            var company = dbContext.Companies.FirstOrDefault(x => x.CompId == id);

            company.CompanyName = txtCompanyName.Text;
            company.TaxNumnber = txtTaxNumber.Text;
            company.TaxOffice = txtTaxOffice.Text;
            company.Addresses = txtAddresses.Text;

            dbContext.SaveChanges();

            dgvCompany.DataSource = dbContext.Companies.ToList();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCompany.CurrentRow.Cells[0].Value.ToString());


            var company = dbContext.Companies.FirstOrDefault(x => x.CompId == id);
            DialogResult result = new DialogResult();

            result = MessageBox.Show($@"{company.CompanyName} {company.TaxNumnber} {company.TaxOffice} {company.Addresses} Company Silinecek Company kalıcı olarak silmek istediğinizden emin misiniz?",
                "Kalıcı Olarak Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                dbContext.Companies.Remove(company);
                dbContext.SaveChanges();

                dgvCompany.DataSource = dbContext.Companies.ToList();

                txtCompanyName.Text = txtTaxNumber.Text = txtTaxOffice.Text = txtAddresses.Text = null;

            }
        }

        private void dgvCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCompanyName.Text = dgvCompany.CurrentRow.Cells[1].Value.ToString();
            txtTaxNumber.Text = dgvCompany.CurrentRow.Cells[2].Value.ToString();
            txtTaxOffice.Text = dgvCompany.CurrentRow.Cells[3].Value.ToString();
            txtAddresses.Text = dgvCompany.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
