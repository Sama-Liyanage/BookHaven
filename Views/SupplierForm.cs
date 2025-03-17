
using BookHeaven.Models.Entity;
using System.Windows.Forms;

namespace BookHeaven.Views
{
    partial class SupplierForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label labelName;

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
            labelName = new Label();
            dataGridViewSuppliers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colBooks = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            btnAddBooks = new Button();
            btnUpdateBooks = new Button();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblConatct = new Label();
            txtContact = new TextBox();
            lblBooks = new Label();
            cmbBooks = new ComboBox();
            dataGridViewBooks = new DataGridView();
            bookId = new DataGridViewTextBoxColumn();
            bookTitle = new DataGridViewTextBoxColumn();
            bookAuthor = new DataGridViewTextBoxColumn();
            bookGenre = new DataGridViewTextBoxColumn();
            bookISBN = new DataGridViewTextBoxColumn();
            bookPrice = new DataGridViewTextBoxColumn();
            bookQuantity = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(206, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(543, 66);
            labelName.TabIndex = 9;
            labelName.Text = "Supplier Management";
            labelName.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuppliers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewSuppliers.BorderStyle = BorderStyle.None;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colContact, colBooks, colDelete });
            dataGridViewSuppliers.Location = new Point(30, 249);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowHeadersWidth = 51;
            dataGridViewSuppliers.Size = new Size(926, 105);
            dataGridViewSuppliers.TabIndex = 0;
            dataGridViewSuppliers.CellClick += dataGridViewSuppliers_Click;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            // 
            // colContact
            // 
            colContact.HeaderText = "Conatct No";
            colContact.MinimumWidth = 6;
            colContact.Name = "colContact";
            // 
            // colBooks
            // 
            colBooks.HeaderText = "Books";
            colBooks.MinimumWidth = 6;
            colBooks.Name = "colBooks";
            colBooks.Resizable = DataGridViewTriState.True;
            colBooks.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // btnAddBooks
            // 
            btnAddBooks.BackColor = Color.FromArgb(40, 167, 69);
            btnAddBooks.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBooks.ForeColor = SystemColors.Window;
            btnAddBooks.Location = new Point(675, 169);
            btnAddBooks.Name = "btnAddBooks";
            btnAddBooks.Size = new Size(127, 43);
            btnAddBooks.TabIndex = 1;
            btnAddBooks.Text = "Add";
            btnAddBooks.UseVisualStyleBackColor = false;
            btnAddBooks.Click += btnAddBookSupplier;
            // 
            // btnUpdateBooks
            // 
            btnUpdateBooks.BackColor = SystemColors.Highlight;
            btnUpdateBooks.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateBooks.ForeColor = SystemColors.Window;
            btnUpdateBooks.Location = new Point(829, 169);
            btnUpdateBooks.Name = "btnUpdateBooks";
            btnUpdateBooks.Size = new Size(127, 43);
            btnUpdateBooks.TabIndex = 16;
            btnUpdateBooks.Text = "Update";
            btnUpdateBooks.UseVisualStyleBackColor = false;
            btnUpdateBooks.Click += btnUpdateSupplier_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblId.Location = new Point(30, 100);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 18;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(30, 123);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 17;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblName.Location = new Point(283, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 20);
            lblName.TabIndex = 19;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(280, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 3;
            // 
            // lblConatct
            // 
            lblConatct.AutoSize = true;
            lblConatct.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblConatct.Location = new Point(527, 103);
            lblConatct.Name = "lblConatct";
            lblConatct.Size = new Size(101, 20);
            lblConatct.TabIndex = 12;
            lblConatct.Text = "Contact No";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(524, 126);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 27);
            txtContact.TabIndex = 5;
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblBooks.Location = new Point(766, 100);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(60, 20);
            lblBooks.TabIndex = 20;
            lblBooks.Text = "Books";
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(766, 126);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(190, 28);
            cmbBooks.TabIndex = 21;
            cmbBooks.MouseClick += cmbBooksMouseClick;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewBooks.BorderStyle = BorderStyle.None;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { bookId, bookTitle, bookAuthor, bookGenre, bookISBN, bookPrice, bookQuantity });
            dataGridViewBooks.Location = new Point(30, 386);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(926, 117);
            dataGridViewBooks.TabIndex = 1;
            dataGridViewBooks.CellContentClick += dataGridViewBooks_CellContentClick_1;
            // 
            // bookId
            // 
            bookId.HeaderText = "Book ID";
            bookId.MinimumWidth = 6;
            bookId.Name = "bookId";
            bookId.Width = 125;
            // 
            // bookTitle
            // 
            bookTitle.HeaderText = "Title";
            bookTitle.MinimumWidth = 6;
            bookTitle.Name = "bookTitle";
            bookTitle.Width = 125;
            // 
            // bookAuthor
            // 
            bookAuthor.HeaderText = "Author";
            bookAuthor.MinimumWidth = 6;
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Width = 125;
            // 
            // bookGenre
            // 
            bookGenre.HeaderText = "Genre";
            bookGenre.MinimumWidth = 6;
            bookGenre.Name = "bookGenre";
            bookGenre.Width = 125;
            // 
            // bookISBN
            // 
            bookISBN.HeaderText = "ISBN";
            bookISBN.MinimumWidth = 6;
            bookISBN.Name = "bookISBN";
            bookISBN.Width = 125;
            // 
            // bookPrice
            // 
            bookPrice.HeaderText = "Price";
            bookPrice.MinimumWidth = 6;
            bookPrice.Name = "bookPrice";
            bookPrice.Width = 125;
            // 
            // bookQuantity
            // 
            bookQuantity.HeaderText = "Quantity";
            bookQuantity.MinimumWidth = 6;
            bookQuantity.Name = "bookQuantity";
            bookQuantity.Width = 125;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.Window;
            btnBack.Location = new Point(829, 520);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 43);
            btnBack.TabIndex = 43;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SupplierForm
            // 
            BackColor = SystemColors.Window;
            ClientSize = new Size(989, 608);
            Controls.Add(btnBack);
            Controls.Add(cmbBooks);
            Controls.Add(lblBooks);
            Controls.Add(dataGridViewBooks);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnUpdateBooks);
            Controls.Add(lblConatct);
            Controls.Add(labelName);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Controls.Add(btnAddBooks);
            Controls.Add(dataGridViewSuppliers);
            Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "SupplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book List";
            Load += SupplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private async void SupplierForm_Load(object sender, EventArgs e)
        {
            dataGridViewBooks.Visible = false;
            await Task.Delay(1000);

            var suppliers = await supplierService.GetAllSuppliersAsync();
            dataGridViewSuppliers.Rows.Clear();
            foreach (var supplier in suppliers)
            {
                dataGridViewSuppliers.Rows.Add(
                    supplier.Id,
                    supplier.Name,
                    supplier.ContactInfo,
                    "View Books"
                );
            }
        }

        private void InitializeDataGridViewBooks()
        {
            dataGridViewBooks.Columns.Clear();
            dataGridViewBooks.Columns.Add("colBookId", "Book ID");
            dataGridViewBooks.Columns.Add("colTitle", "Title");
            dataGridViewBooks.Columns.Add("colAuthor", "Author");
            dataGridViewBooks.Columns.Add("colGenre", "Genre");
            dataGridViewBooks.Columns.Add("colISBN", "ISBN");
            dataGridViewBooks.Columns.Add("colPrice", "Price");
            dataGridViewBooks.Columns.Add("colQuantity", "Quantity");
        }


        private async void dataGridViewSuppliers_Click(object sender, DataGridViewCellEventArgs e)
        {
            var supplierId = (Guid)dataGridViewSuppliers.Rows[e.RowIndex].Cells["colId"].Value;
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSuppliers.Columns["colBooks"].Index)
            {
                LoadBooksForSupplier(supplierId);
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSuppliers.Columns["colDelete"].Index)
            {
                await DeleteSupplier(supplierId);
            }
            else
            {
                var selectedRow = dataGridViewSuppliers.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells["colId"].Value.ToString();
                txtName.Text = selectedRow.Cells["colName"].Value.ToString();
                txtContact.Text = selectedRow.Cells["colContact"].Value.ToString();
            }
        }

        private async void LoadBooksForSupplier(Guid supplierId)
        {
            dataGridViewBooks.Visible = true;

            var books = await bookService.GetBooksBySupplier(supplierId);
            dataGridViewBooks.Rows.Clear();

            foreach (var book in books)
            {
                dataGridViewBooks.Rows.Add(
                    book.Id,
                    book.Title,
                    book.Author,
                    book.Genre,
                    book.ISBN,
                    book.Price,
                    book.Quantity
                );
            }
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


        private void ClearTextBoxes()
        {

            txtId.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            dataGridViewBooks.Rows.Clear();
            dataGridViewBooks.Visible = false;
            cmbBooks.SelectedIndex = -1;
        }


        private void dataGridViewBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async Task LoadBooks()
        {
            var books = await bookService.GetAllBooks();
            cmbBooks.DataSource = books;
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "Id";
            cmbBooks.SelectedIndex = -1;
        }





        private async void cmbBooksMouseClick(object sender, MouseEventArgs e)
        {
            await LoadBooks();
        }

        private async void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please choose a supplier to update the information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var supplierId = Guid.Parse(txtId.Text);
            var supplier = await supplierService.GetSupplierByIdAsync(supplierId);

            if (supplier != null)
            {
                supplier.Name = txtName.Text;
                supplier.ContactInfo = txtContact.Text;
                if (cmbBooks.SelectedValue != null)
                {
                    var selectedBookId = (Guid)cmbBooks.SelectedValue;
                    var selectedBook = await bookService.GetBookById(selectedBookId);

                    if (selectedBook != null && !supplier.Books.Any(b => b.Id == selectedBookId))
                    {
                        supplier.Books.Add(selectedBook);
                        selectedBook.SupplierId = supplier.Id;
                        await bookService.UpdateBook(selectedBook);
                    }
                }

                await supplierService.UpdateSupplierAsync(supplier);
                MessageBox.Show("Supplier information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadSuppliers();
                ClearTextBoxes();
            }
        }



        private async Task LoadSuppliers()
        {
            var suppliers = await supplierService.GetAllSuppliersAsync();
            dataGridViewSuppliers.Rows.Clear();

            foreach (var supplier in suppliers)
            {
                dataGridViewSuppliers.Rows.Add(
                    supplier.Id,
                    supplier.Name,
                    supplier.ContactInfo,
                    "View Books"
                );
            }
        }

        private async Task DeleteSupplier(Guid id)
        {
            var supplier = await supplierService.GetSupplierByIdAsync(id);
            if (supplier != null)
            {
                var books = await bookService.GetBooksBySupplier(id);

                if (books != null)
                {
                    foreach (var book in books)
                    {
                        book.SupplierId = null;
                        await bookService.UpdateBook(book);
                    }
                }
                await supplierService.DeleteSupplierAsync(id);

                MessageBox.Show("Supplier information deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadSuppliers();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Supplier not found in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminDashboardForm();
            adminForm.Show();
            this.Hide();
        }



        private async void btnAddBookSupplier(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please enter supplier name and contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var supplier = new Supplier
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                ContactInfo = txtContact.Text
            };

            await supplierService.CreateSupplierAsync(supplier);

            if (cmbBooks.SelectedValue != null)
            {
                var selectedBookId = (Guid)cmbBooks.SelectedValue;
                var selectedBook = await bookService.GetBookById(selectedBookId);

                if (selectedBook != null)
                {
                    selectedBook.SupplierId = supplier.Id;

                    var updateResult = await bookService.UpdateBook(selectedBook);
                    if (!updateResult.HasValue)
                    {
                        MessageBox.Show("Failed to update book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            MessageBox.Show("Supplier added and book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadSuppliers();
            ClearTextBoxes();

        }

       
    }
}
