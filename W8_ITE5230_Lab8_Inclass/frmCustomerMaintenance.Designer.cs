namespace W8_ITE5230_Lab8_Inclass
{
    partial class frmCustomerMaintenance
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
            groupBoxGetCustomer = new GroupBox();
            btnGetCustomer = new Button();
            txtCustomerID = new TextBox();
            label1 = new Label();
            groupBoxCustomerDetails = new GroupBox();
            txtZipCode = new TextBox();
            label6 = new Label();
            txtState = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            groupBoxCustomerOperations = new GroupBox();
            btnLoadCustomers = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            btnModify = new Button();
            btnAdd = new Button();
            groupBoxCustomersList = new GroupBox();
            gvCustomers = new DataGridView();
            groupBoxGetCustomer.SuspendLayout();
            groupBoxCustomerDetails.SuspendLayout();
            groupBoxCustomerOperations.SuspendLayout();
            groupBoxCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvCustomers).BeginInit();
            SuspendLayout();
            // 
            // groupBoxGetCustomer
            // 
            groupBoxGetCustomer.Controls.Add(btnGetCustomer);
            groupBoxGetCustomer.Controls.Add(txtCustomerID);
            groupBoxGetCustomer.Controls.Add(label1);
            groupBoxGetCustomer.Location = new Point(12, 11);
            groupBoxGetCustomer.Name = "groupBoxGetCustomer";
            groupBoxGetCustomer.Size = new Size(562, 66);
            groupBoxGetCustomer.TabIndex = 0;
            groupBoxGetCustomer.TabStop = false;
            groupBoxGetCustomer.Text = "Get Customer";
            // 
            // btnGetCustomer
            // 
            btnGetCustomer.Location = new Point(214, 27);
            btnGetCustomer.Name = "btnGetCustomer";
            btnGetCustomer.Size = new Size(162, 29);
            btnGetCustomer.TabIndex = 2;
            btnGetCustomer.Text = "Get Customer";
            btnGetCustomer.UseVisualStyleBackColor = true;
            btnGetCustomer.Click += btnGetCustomer_Click;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(117, 27);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(69, 27);
            txtCustomerID.TabIndex = 1;
            txtCustomerID.Tag = "Customer ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer ID:";
            // 
            // groupBoxCustomerDetails
            // 
            groupBoxCustomerDetails.Controls.Add(txtZipCode);
            groupBoxCustomerDetails.Controls.Add(label6);
            groupBoxCustomerDetails.Controls.Add(txtState);
            groupBoxCustomerDetails.Controls.Add(label5);
            groupBoxCustomerDetails.Controls.Add(txtCity);
            groupBoxCustomerDetails.Controls.Add(label4);
            groupBoxCustomerDetails.Controls.Add(txtAddress);
            groupBoxCustomerDetails.Controls.Add(label3);
            groupBoxCustomerDetails.Controls.Add(txtName);
            groupBoxCustomerDetails.Controls.Add(label2);
            groupBoxCustomerDetails.Location = new Point(12, 83);
            groupBoxCustomerDetails.Name = "groupBoxCustomerDetails";
            groupBoxCustomerDetails.Size = new Size(562, 163);
            groupBoxCustomerDetails.TabIndex = 1;
            groupBoxCustomerDetails.TabStop = false;
            groupBoxCustomerDetails.Text = "Customer Details";
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = SystemColors.Control;
            txtZipCode.Location = new Point(406, 124);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.ReadOnly = true;
            txtZipCode.Size = new Size(139, 27);
            txtZipCode.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 127);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 8;
            label6.Text = "Zip code:";
            // 
            // txtState
            // 
            txtState.BackColor = SystemColors.Control;
            txtState.Location = new Point(106, 120);
            txtState.Name = "txtState";
            txtState.ReadOnly = true;
            txtState.Size = new Size(60, 27);
            txtState.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 123);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "State:";
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.Control;
            txtCity.Location = new Point(106, 87);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(439, 27);
            txtCity.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 90);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 4;
            label4.Text = "City:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.Location = new Point(106, 53);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(439, 27);
            txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 56);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Control;
            txtName.Location = new Point(106, 20);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(439, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 23);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // groupBoxCustomerOperations
            // 
            groupBoxCustomerOperations.Controls.Add(btnLoadCustomers);
            groupBoxCustomerOperations.Controls.Add(btnExit);
            groupBoxCustomerOperations.Controls.Add(btnDelete);
            groupBoxCustomerOperations.Controls.Add(btnModify);
            groupBoxCustomerOperations.Controls.Add(btnAdd);
            groupBoxCustomerOperations.Location = new Point(587, 12);
            groupBoxCustomerOperations.Name = "groupBoxCustomerOperations";
            groupBoxCustomerOperations.Size = new Size(201, 234);
            groupBoxCustomerOperations.TabIndex = 2;
            groupBoxCustomerOperations.TabStop = false;
            groupBoxCustomerOperations.Text = "Customer Operations";
            // 
            // btnLoadCustomers
            // 
            btnLoadCustomers.Location = new Point(35, 161);
            btnLoadCustomers.Name = "btnLoadCustomers";
            btnLoadCustomers.Size = new Size(127, 29);
            btnLoadCustomers.TabIndex = 4;
            btnLoadCustomers.Text = "Load Customers";
            btnLoadCustomers.UseVisualStyleBackColor = true;
            btnLoadCustomers.Click += btnLoadCustomers_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(35, 195);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(35, 96);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Enabled = false;
            btnModify.Location = new Point(35, 61);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(127, 29);
            btnModify.TabIndex = 1;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(35, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBoxCustomersList
            // 
            groupBoxCustomersList.Controls.Add(gvCustomers);
            groupBoxCustomersList.Location = new Point(12, 252);
            groupBoxCustomersList.Name = "groupBoxCustomersList";
            groupBoxCustomersList.Size = new Size(776, 381);
            groupBoxCustomersList.TabIndex = 3;
            groupBoxCustomersList.TabStop = false;
            groupBoxCustomersList.Text = "Customers List";
            // 
            // gvCustomers
            // 
            gvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCustomers.Location = new Point(6, 26);
            gvCustomers.Name = "gvCustomers";
            gvCustomers.RowHeadersWidth = 51;
            gvCustomers.RowTemplate.Height = 29;
            gvCustomers.Size = new Size(764, 349);
            gvCustomers.TabIndex = 0;
            // 
            // frmCustomerMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 645);
            Controls.Add(groupBoxCustomersList);
            Controls.Add(groupBoxCustomerOperations);
            Controls.Add(groupBoxCustomerDetails);
            Controls.Add(groupBoxGetCustomer);
            Name = "frmCustomerMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Maintenance";
            groupBoxGetCustomer.ResumeLayout(false);
            groupBoxGetCustomer.PerformLayout();
            groupBoxCustomerDetails.ResumeLayout(false);
            groupBoxCustomerDetails.PerformLayout();
            groupBoxCustomerOperations.ResumeLayout(false);
            groupBoxCustomersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGetCustomer;
        private TextBox txtCustomerID;
        private Label label1;
        private Button btnGetCustomer;
        private GroupBox groupBoxCustomerDetails;
        private TextBox txtName;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtState;
        private Label label5;
        private TextBox txtZipCode;
        private Label label6;
        private GroupBox groupBoxCustomerOperations;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnModify;
        private Button btnExit;
        private Button btnLoadCustomers;
        private GroupBox groupBoxCustomersList;
        private DataGridView gvCustomers;
    }
}
