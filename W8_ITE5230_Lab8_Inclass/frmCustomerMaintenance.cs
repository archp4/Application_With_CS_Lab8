using System.Data;
using W8_ITE5230_Lab8_Inclass.Database;
using W8_ITE5230_Lab8_Inclass.Entity;

namespace W8_ITE5230_Lab8_Inclass
{
    public partial class frmCustomerMaintenance : Form
    {
        Customer? selectCustomer;
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtCustomerID.Text);
                Customer? customer = CustomerDB.GetCustomer(id);
                selectCustomer = customer;
                if (customer != null)
                {
                    txtName.Text = customer.Name;
                    txtAddress.Text = customer.Address;
                    txtCity.Text = customer.City;
                    txtState.Text = customer.State;
                    txtZipCode.Text = customer.ZipCode;

                    btnModify.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Customer Not Found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter CustomerId To Get Details", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyCustomer frmAdd = new frmAddModifyCustomer();
            frmAdd.ShowDialog(this);
            this.btnLoadCustomers_Click(sender, e);
            txtCustomerID.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (selectCustomer != null)
            {
                frmAddModifyCustomer frmAdd = new frmAddModifyCustomer(selectCustomer);
                frmAdd.ShowDialog(this);
                this.btnLoadCustomers_Click(sender, e);
                this.btnGetCustomer_Click(sender, e);
                txtCustomerID.Focus();
            }

        }

        private void clearSelectedCustomer()
        {
            selectCustomer = null;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtZipCode.Text = string.Empty;
            txtCustomerID.Text = string.Empty;

            btnModify.Enabled = false;
            btnDelete.Enabled = false;

            MessageBox.Show("Unselected Customer", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectCustomer != null)
            {
                bool result = CustomerDB.DeleteCustomer(selectCustomer);
                if (result)
                {
                    MessageBox.Show("Customer Deleted Successfully!!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearSelectedCustomer();
                    this.btnLoadCustomers_Click(sender, e);
                    txtCustomerID.Focus();
                }
            }
        }

        private void btnLoadCustomers_Click(object sender, EventArgs e)
        {
            DataTable customerList = CustomerDB.LoadCustomer();
            gvCustomers.DataSource = customerList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
