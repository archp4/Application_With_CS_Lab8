using W8_ITE5230_Lab8_Inclass.Database;
using W8_ITE5230_Lab8_Inclass.Entity;

namespace W8_ITE5230_Lab8_Inclass
{
    public partial class frmAddModifyCustomer : Form
    {
        Customer? customer;
        public frmAddModifyCustomer()
        {
            InitializeComponent();
            cboStates.Items.Clear();
            foreach (State state in StateDB.LoadStates())
            {
                cboStates.Items.Add(state);
            }
            cboStates.SelectedIndex = 0;
            this.Text = "Add New Customer";
        }

        public frmAddModifyCustomer(Customer customer)
        {
            InitializeComponent();
            cboStates.Items.Clear();

            List<State> states = StateDB.LoadStates();
            int selectedIndex = 0;
            for (int i = 0; i < states.Count; i++)
            {
                if (states[i].StateCode == customer.State)
                {
                    selectedIndex = i;
                }
            }
            foreach (State state in states)
            {
                cboStates.Items.Add(state);
            }
            cboStates.SelectedIndex = selectedIndex;
            this.customer = customer;

            txtName.Text = customer.Name;
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtZipCode.Text = customer.ZipCode;

            this.Text = "Modify Customer";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                Customer newCustomer = new Customer();
                newCustomer.Name = txtName.Text;
                newCustomer.Address = txtAddress.Text;
                newCustomer.City = txtCity.Text;
                newCustomer.State = ((State)cboStates.Items[cboStates.SelectedIndex]).StateCode;
                newCustomer.ZipCode = txtZipCode.Text;

                bool result = CustomerDB.UpdateCustomer(newCustomer, customer);
                if (result)
                    MessageBox.Show("Customer Details Updated !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Update Failed!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
            else
            {
                Customer newCustomer = new Customer();
                newCustomer.Name = txtName.Text;
                newCustomer.Address = txtAddress.Text;
                newCustomer.City = txtCity.Text;
                newCustomer.State = ((State)cboStates.SelectedItem).StateCode.ToString().Substring(0, 2);
                newCustomer.ZipCode = txtZipCode.Text;

                int customerID = CustomerDB.AddCustomer(newCustomer);
                if (customerID > 0)
                    MessageBox.Show($"New Customer With ID:{customerID} Added Successfully!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Insert Failed!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void frmAddModifyCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
