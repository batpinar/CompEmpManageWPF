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
    public partial class frmEmployee : Form
    {
        CEMEntities dbContext = new CEMEntities();
        public frmEmployee()
        {
            InitializeComponent();
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            dgvEmployee.Columns.Clear();
            dgvEmployee.DataSource = dbContext.Employees.ToList();
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();

            employees.IdentityNumber = txtID.Text;
            employees.FirstName = txtName.Text;
            employees.LastName = txtSurname.Text;
            employees.CompId = Convert.ToInt32(txtCompId.Text);

            var companyDb = dbContext.Companies.Find(employees.CompId);
            if(companyDb != null)
            {
                dbContext.Employees.Add(employees);
                dbContext.SaveChanges(); 
            }
            else
            {
                var message = "This Company id not found!";
                MessageBox.Show(message);
            }

            dgvEmployee.Columns.Clear();
            dgvEmployee.DataSource = dbContext.Employees.ToList();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvEmployee.CurrentRow.Cells[0].Value.ToString());

            var employees = dbContext.Employees.FirstOrDefault(x => x.EmpId == id);

            employees.IdentityNumber = txtID.Text;
            employees.FirstName = txtName.Text;
            employees.LastName = txtSurname.Text;
            employees.CompId = Convert.ToInt32(txtCompId.Text);

            dbContext.SaveChanges();

            dgvEmployee.DataSource = dbContext.Employees.ToList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvEmployee.CurrentRow.Cells[0].Value.ToString());


            var employee = dbContext.Employees.FirstOrDefault(x => x.CompId == id);
            DialogResult result = new DialogResult();

            result = MessageBox.Show($@"{employee.IdentityNumber} {employee.FirstName} {employee.LastName} {employee.CompId} Company Silinecek Company kalıcı olarak silmek istediğinizden emin misiniz?",
                "Kalıcı Olarak Silinecek", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dbContext.Employees.Remove(employee);
                dbContext.SaveChanges();

                dgvEmployee.DataSource = dbContext.Employees.ToList();

                txtID.Text = txtName.Text = txtSurname.Text = null;
                

            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgvEmployee.CurrentRow.Cells[2].Value.ToString();
            txtSurname.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            txtCompId.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
