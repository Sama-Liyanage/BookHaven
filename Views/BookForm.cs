
using BookHeaven.Models.Entity;
using System.Data;
using System.Windows.Forms;

namespace BookHeaven.Views
{
    partial class BookForm
    {
        // Components declaration
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;

        // Dispose method to clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Method to initialize components
        private void InitializeComponent()
        {
            dataGridViewBooks = new DataGridView();
            // DataGridView column definitions
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colGenre = new DataGridViewTextBoxColumn();
            colISBN = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            btnAddBook = new Button();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtGenre = new TextBox();
            txtISBN = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label1 = new Label();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblGenre = new Label();
            lblISBN = new Label();
            lblPrice = new Label();
            lblQty = new Label();
            btnUpdate = new Button();
            txtId = new TextBox();
            lblId = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();

            // DataGridView properties
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colAuthor, colGenre, colISBN, colPrice, colQuantity, colDelete });
            dataGridViewBooks.Location = new Point(18, 317);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(913, 157);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
           
            // colId 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            
            // colTitle
            colTitle.HeaderText = "Title";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "colTitle";
             
            // colAuthor
            colAuthor.HeaderText = "Author";
            colAuthor.MinimumWidth = 6;
            colAuthor.Name = "colAuthor";
        
            // colGenre
            colGenre.HeaderText = "Genre";
            colGenre.MinimumWidth = 6;
            colGenre.Name = "colGenre";
            
            // colISBN 
            colISBN.HeaderText = "ISBN";
            colISBN.MinimumWidth = 6;
            colISBN.Name = "colISBN";
            
            // colPrice 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            
            // colQuantity 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
          
            // colDelete
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            
            // btnAddBook 
            btnAddBook.BackColor = Color.Green;
            btnAddBook.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBook.ForeColor = SystemColors.Window;
            btnAddBook.Location = new Point(671, 238);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(127, 43);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Add ";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            
            // txtTitle 
            txtTitle.Location = new Point(260, 110);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 27);
            txtTitle.TabIndex = 3;
            txtTitle.TextChanged += txtTitle_TextChanged;
             
            // txtAuthor 
            txtAuthor.Location = new Point(492, 110);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(200, 27);
            txtAuthor.TabIndex = 4;
            
            // txtGenre 
            txtGenre.Location = new Point(731, 110);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(200, 27);
            txtGenre.TabIndex = 5;
            
            // txtISBN 
            txtISBN.Location = new Point(28, 190);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(200, 27);
            txtISBN.TabIndex = 6;
          
            // txtPrice 
            txtPrice.Location = new Point(260, 190);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 7;
            txtPrice.TextChanged += txtPrice_TextChanged;
      
            // txtQuantity
            txtQuantity.Location = new Point(492, 190);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 27);
            txtQuantity.TabIndex = 8;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            
            // label1 
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 9);
            label1.Name = "label1";
            label1.Size = new Size(529, 66);
            label1.TabIndex = 9;
            label1.Text = "Book Management";
            label1.TextAlign = ContentAlignment.TopCenter;
          
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(260, 87);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(46, 20);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Title";
          
            // lblAuthor
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(492, 87);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(64, 20);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Author";
          
            // lblGenre
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGenre.Location = new Point(731, 87);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(59, 20);
            lblGenre.TabIndex = 12;
            lblGenre.Text = "Genre";
           
            // lblISBN
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(34, 167);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(50, 20);
            lblISBN.TabIndex = 13;
            lblISBN.Text = "ISBN";
           
            // lblPrice
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(260, 167);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 20);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price";
           
            // lblQty
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(492, 167);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(72, 20);
            lblQty.TabIndex = 15;
            lblQty.Text = "Quanity";
             
            // btnUpdate
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.Window;
            btnUpdate.Location = new Point(804, 238);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 43);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdateClick;
             
            // txtId
            txtId.Location = new Point(28, 110);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 27);
            txtId.TabIndex = 17;
            txtId.TextChanged += txtId_TextChanged;
          
            // lblId
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(28, 87);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 18;
            lblId.Text = "Id";
           
            // btnBack 
            btnBack.BackColor = Color.CornflowerBlue;
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.Window;
            btnBack.Location = new Point(804, 525);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 43);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
         
            // BookForm 
            BackColor = SystemColors.Window;
            ClientSize = new Size(989, 608);
            Controls.Add(btnBack);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(lblQty);
            Controls.Add(lblPrice);
            Controls.Add(lblISBN);
            Controls.Add(lblGenre);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtISBN);
            Controls.Add(txtGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(btnAddBook);
            Controls.Add(dataGridViewBooks);
            Name = "BookForm";
            Text = "Book List";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

   

        // Method to clear textboxes after an operation
        private void clearTextBoxes()
        {
            txtId.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtGenre.Text = "";
            txtISBN.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }


        // Method to update book information
        private async void btnUpdateClick(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a book to update");
                return;
            }
            var newBook = new Book
            {
                Id = Guid.Parse(txtId.Text),
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Genre = txtGenre.Text,
                ISBN = txtISBN.Text,
                Price = decimal.TryParse(txtPrice.Text, out var price) ? price : 0,
                Quantity = int.TryParse(txtQuantity.Text, out var quantity) ? quantity : 0,
                SupplierId = null
            };

            var updated = await _bookService.UpdateBook(newBook);
            if (updated != null && updated > 0)
            {
                MessageBox.Show("Book updated successfully");
                BookForm_Load(sender, e);
                clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Book update failed");
            }
        }


        // Event handler for going back to the dashboard
        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminDashboardForm();
            var clerkForm = new ClerkDashboardForm();
            if (userRole == UserRole.Admin)
            {
                adminForm.Show();
            }
            else
            {
                clerkForm.Show();
            }
            this.Hide();
        }

       

        private void dataGridViewBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtId_TextChanged(object sender, EventArgs e)
        {

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
    }
}
