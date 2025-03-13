
using BookHeaven.Models.Entity;
using System.Text.RegularExpressions;


namespace BookHeaven.Views
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblCustomer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Initialize UI components for customer management
            dataGridViewCustomers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            btnAddCustomer = new Button();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            lblCustomer = new Label();
            lblConatct = new Label();
            btnUpdateCustomer = new Button();
            txtId = new TextBox();
            lblId = new Label();
            lblName = new Label();
            lblEmail = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();

            // Set up the data grid view for displaying customer details
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colEmail, colContact, colDelete });
            dataGridViewCustomers.Location = new Point(129, 322);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.Size = new Size(744, 146);
            dataGridViewCustomers.TabIndex = 0;
            dataGridViewCustomers.CellClick += dataGridViewCustomers_CellClick;

            // Define the columns of the data grid view
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
             
            // colName 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            
            // colEmail
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
             
            // colContact
            colContact.HeaderText = "Conatct No";
            colContact.MinimumWidth = 6;
            colContact.Name = "colContact";
            
            // colDelete 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;

            // Set up the Add Customer button
            btnAddCustomer.BackColor = Color.FromArgb(40, 167, 69);
            btnAddCustomer.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCustomer.ForeColor = SystemColors.Window;
            btnAddCustomer.Location = new Point(586, 204);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(127, 43);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddClick;

            // Initialize text boxes for customer details
            // txtName
            txtName.Location = new Point(386, 133);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 3;
        
            // txtEmail
            txtEmail.Location = new Point(660, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtAuthor_TextChanged;
           
            // txtContact 
            txtContact.Location = new Point(129, 220);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 27);
            txtContact.TabIndex = 5;

            // Set up labels for customer form fields
            // lblCustomer 
            lblCustomer.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(227, 21);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(543, 66);
            lblCustomer.TabIndex = 9;
            lblCustomer.Text = "Customer Management";
            lblCustomer.TextAlign = ContentAlignment.TopCenter;
             
            // lblConatct 
            lblConatct.AutoSize = true;
            lblConatct.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblConatct.Location = new Point(132, 197);
            lblConatct.Name = "lblConatct";
            lblConatct.Size = new Size(101, 20);
            lblConatct.TabIndex = 12;
            lblConatct.Text = "Contact No";

            // Set up the Update Customer button
            btnUpdateCustomer.BackColor = SystemColors.Highlight;
            btnUpdateCustomer.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateCustomer.ForeColor = SystemColors.Window;
            btnUpdateCustomer.Location = new Point(733, 204);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(127, 43);
            btnUpdateCustomer.TabIndex = 16;
            btnUpdateCustomer.Text = "Update";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += btnUpdateClick;

            // Set up text box for customer Id
            // txtId
            txtId.Location = new Point(129, 133);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 17;
            
            // lblId 
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblId.Location = new Point(129, 110);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 18;
            lblId.Text = "Id";
           
            // lblName
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblName.Location = new Point(389, 110);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 20);
            lblName.TabIndex = 19;
            lblName.Text = "Name";
            
            // lblEmail 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblEmail.Location = new Point(663, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 20);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "Email";  

            // Set up the Back button
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.Window;
            btnBack.Location = new Point(746, 493);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 43);
            btnBack.TabIndex = 21;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            
            // CustomerForm 
            BackColor = SystemColors.Window;
            ClientSize = new Size(989, 608);
            Controls.Add(btnBack);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(lblConatct);
            Controls.Add(lblCustomer);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnAddCustomer);
            Controls.Add(dataGridViewCustomers);
            Name = "CustomerForm";
            Text = "Customer List";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        // Clear the text boxes for inputs
        private void clearTextBoxes()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
        }





        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

       


        // Validate the inputs before submitting
        private bool ValidateInputs()
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Name cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return false;
                }

                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtEmail.Text, emailPattern))
                {
                    MessageBox.Show("Invalid Email Format", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }

                string contactPattern = @"^\d{10}$";
                if (!Regex.IsMatch(txtContact.Text, contactPattern))
                {
                    MessageBox.Show("Contact Number must be exactly 10 digits", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContact.Focus();
                    return false;
                }

                return true;
            }


        // Handle Add button click event
        private async void btnAddClick(object sender, EventArgs e)
                {
                    if (!ValidateInputs()) return; 

                    var customer = new Customer
                    {
                        Id = Guid.NewGuid(),
                        Name = txtName.Text,
                        Email = txtEmail.Text,
                        PhoneNumber = txtContact.Text,
                    };

                    try
                    {
                        await customerService.AddCustomer(customer);

                        CustomerForm_Load(sender, e);

                        MessageBox.Show("Customer added successfully!");
                        clearTextBoxes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding Customer: {ex.Message}");
                    }
                }

        // Handle Update button click event
        private async void btnUpdateClick(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a Customer to update");
                return;
            }
            if (!ValidateInputs()) return;

            var customer = new Customer
            {
                Id = Guid.Parse(txtId.Text),
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtContact.Text,
            };

            var updated = await customerService.UpdateCustomer(customer);
            if (updated != null && updated > 0)
            {
                MessageBox.Show("Customer updated successfully");
                CustomerForm_Load(sender, e);
                clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Customer update failed");
            }
        }


        private async void DeleteCustomer(Guid id)
        {
            if (id != null)
            {
                try
                {
                    await customerService.DeleteCustomer(id);

                    CustomerForm_Load(this, EventArgs.Empty);

                    MessageBox.Show("Customer deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting book: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Customer not found!");
            }
        }

        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewCustomers.Rows[e.RowIndex];

                if (e.ColumnIndex == dataGridViewCustomers.Columns["colDelete"].Index)
                {
                    var id = Guid.Parse(selectedRow.Cells["colId"].Value.ToString());
                    DeleteCustomer(id);
                }
                else
                {
                    txtId.Text = selectedRow.Cells["colId"].Value.ToString();
                    txtName.Text = selectedRow.Cells["colName"].Value.ToString();
                    txtEmail.Text = selectedRow.Cells["colEmail"].Value.ToString();
                    txtContact.Text = selectedRow.Cells["colContact"].Value.ToString();
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminDashboardForm();
            var clerkForm = new ClerkDashboardForm();
            if (role == UserRole.Admin)
            {
                adminForm.Show();
            }
            else
            {
                clerkForm.Show();
            }
            this.Hide();
        }
    }
}
