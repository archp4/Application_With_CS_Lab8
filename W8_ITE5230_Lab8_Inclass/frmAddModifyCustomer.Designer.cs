namespace W8_ITE5230_Lab8_Inclass
{
    partial class frmAddModifyCustomer
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
            label1 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            label2 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtZipCode = new TextBox();
            label5 = new Label();
            btnAccept = new Button();
            btnCancel = new Button();
            cboStates = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 11);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(94, 8);
            txtName.Name = "txtName";
            txtName.Size = new Size(442, 27);
            txtName.TabIndex = 1;
            txtName.Tag = "Name";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(94, 41);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(442, 27);
            txtAddress.TabIndex = 3;
            txtAddress.Tag = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Address:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(94, 74);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(442, 27);
            txtCity.TabIndex = 5;
            txtCity.Tag = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 77);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 4;
            label3.Text = "City:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 110);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "State:";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(433, 107);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(101, 27);
            txtZipCode.TabIndex = 9;
            txtZipCode.Tag = "Zip code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 110);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 8;
            label5.Text = "Zip code:";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(42, 156);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(164, 29);
            btnAccept.TabIndex = 10;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(377, 156);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboStates
            // 
            cboStates.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStates.FormattingEnabled = true;
            cboStates.Location = new Point(94, 107);
            cboStates.Name = "cboStates";
            cboStates.Size = new Size(211, 28);
            cboStates.TabIndex = 12;
            cboStates.Tag = "State";
            // 
            // frmAddModifyCustomer
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(550, 199);
            Controls.Add(cboStates);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtZipCode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "frmAddModifyCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddModifyCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtAddress;
        private Label label2;
        private TextBox txtCity;
        private Label label3;
        private Label label4;
        private TextBox txtZipCode;
        private Label label5;
        private Button btnAccept;
        private Button btnCancel;
        private ComboBox cboStates;
    }
}