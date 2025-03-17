using BookHeaven.Models.Entity;
using System.Windows.Forms;

namespace BookHeaven.Views
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;

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
            dataGridViewUsers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            btnAddEmployee = new Button();
            txtUserName = new TextBox();
            label1 = new Label();
            btnUpdateEmployee = new Button();
            txtId = new TextBox();
            lblId = new Label();
            lblUserName = new Label();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblPassword = new Label();
            txtPassord = new TextBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { colId, colUsername, colRole, colDelete });
            dataGridViewUsers.Location = new Point(127, 310);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 60;
            dataGridViewUsers.Size = new Size(737, 143);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 6;
            colUsername.Name = "colUsername";
            // 
            // colRole
            // 
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 6;
            colRole.Name = "colRole";
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(40, 167, 69);
            btnAddEmployee.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = SystemColors.Window;
            btnAddEmployee.Location = new Point(591, 205);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(127, 43);
            btnAddEmployee.TabIndex = 1;
            btnAddEmployee.Text = "Add";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddClick;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(390, 128);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(200, 27);
            txtUserName.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(543, 66);
            label1.TabIndex = 43;
            label1.Text = "Employee Management";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.BackColor = SystemColors.Highlight;
            btnUpdateEmployee.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateEmployee.ForeColor = SystemColors.Window;
            btnUpdateEmployee.Location = new Point(737, 205);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(127, 43);
            btnUpdateEmployee.TabIndex = 16;
            btnUpdateEmployee.Text = "Update";
            btnUpdateEmployee.UseVisualStyleBackColor = false;
            btnUpdateEmployee.Click += btnUpdateClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(124, 128);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 17;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblId.Location = new Point(124, 105);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 18;
            lblId.Text = "Id";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblUserName.Location = new Point(393, 105);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(93, 20);
            lblUserName.TabIndex = 19;
            lblUserName.Text = "Username";
            lblUserName.Click += label3_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblRole.Location = new Point(127, 182);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(46, 20);
            lblRole.TabIndex = 20;
            lblRole.Text = "Role";
            lblRole.Click += labelEmail_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(127, 205);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(197, 28);
            cmbRole.TabIndex = 21;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblPassword.Location = new Point(664, 105);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 20);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Password";
            // 
            // txtPassord
            // 
            txtPassord.Location = new Point(664, 128);
            txtPassord.Name = "txtPassord";
            txtPassord.Size = new Size(200, 27);
            txtPassord.TabIndex = 23;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.Window;
            btnBack.Location = new Point(737, 486);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 43);
            btnBack.TabIndex = 42;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // EmployeeForm
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(989, 608);
            Controls.Add(btnBack);
            Controls.Add(txtPassord);
            Controls.Add(lblPassword);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(lblUserName);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(btnAddEmployee);
            Controls.Add(dataGridViewUsers);
            Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Form";
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
        private void clearTextBoxes()
        {
            txtId.Text = "";
            txtUserName.Text = "";
            txtPassord.Text = "";
            cmbRole.SelectedIndex = -1;

        }

        private async void StaffForm_Load(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            cmbRole.DataSource = Enum.GetValues(typeof(UserRole));
            var users = await userService.GetAllUsersAsync();
            dataGridViewUsers.Rows.Clear();
            foreach (var user in users)
            {
                dataGridViewUsers.Rows.Add(
                    user.Id,
                    user.Username,
                    user.Role
                );
            }
        }




        private void lblQty_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConatct_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private async void btnAddClick(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.SelectedValue == null)
                {
                    MessageBox.Show("Please choose a valid role.");
                    return;
                }

                if (!Enum.TryParse(cmbRole.SelectedValue.ToString(), out UserRole selectedRole))
                {
                    MessageBox.Show("Invalid role selection.");
                    return;
                }

                if (txtPassord.Text == null || txtPassord.Text == "")
                {
                    MessageBox.Show("Please enter valid password.");
                    return;
                }

                var user = new AppUser
                {
                    Id = Guid.NewGuid(),
                    Username = txtUserName.Text,
                    PasswordHash = txtPassord.Text,
                    Role = selectedRole
                };

                await userService.CreateUserAsync(user);

                StaffForm_Load(sender, e);

                MessageBox.Show("User added successfully!");
                clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
            }
        }

        private async void btnUpdateClick(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a User to update");
                return;
            }
            if (cmbRole.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid role.");
                return;
            }

            if (!Enum.TryParse(cmbRole.SelectedValue.ToString(), out UserRole selectedRole))
            {
                MessageBox.Show("Invalid role selection.");
                return;
            }

            try
            {
                var user = new AppUser
                {
                    Id = Guid.Parse(txtId.Text),
                    Username = txtUserName.Text,
                    PasswordHash = txtPassord.Text,
                    Role = selectedRole
                };
                MessageBox.Show(user.PasswordHash);
                await userService.UpdateUserAsync(user);

                MessageBox.Show("Employee updated successfully");
                StaffForm_Load(sender, e);
                clearTextBoxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("User update failed", (ex.Message));

            }
        }


        private async void DeleteUser(Guid id)
        {


            if (id != null)
            {
                try
                {
                    await userService.DeleteUserAsync(id);

                    StaffForm_Load(this, EventArgs.Empty);
                    clearTextBoxes();

                    MessageBox.Show("User deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting User: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("User not found!");
            }

        }


        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewUsers.Rows[e.RowIndex];

                if (e.ColumnIndex == dataGridViewUsers.Columns["colDelete"].Index)
                {
                    var id = Guid.Parse(selectedRow.Cells["colId"].Value.ToString());
                    DeleteUser(id);
                }
                else
                {
                    txtId.Text = selectedRow.Cells["colId"].Value.ToString();
                    txtUserName.Text = selectedRow.Cells["colUsername"].Value.ToString();
                    string roleText = selectedRow.Cells["colRole"].Value.ToString();
                    if (Enum.TryParse(roleText, out UserRole selectedRole))
                    {
                        cmbRole.SelectedItem = selectedRole;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminDashboardForm();
            adminForm.Show();
            this.Hide();
        }


    }
}