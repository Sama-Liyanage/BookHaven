using BookHaven.Models.Services;
using BookHeaven.Models.Entity;
using System;
using System.Linq;
using System.Windows.Forms;


namespace BookHeaven.Views
{
    public partial class BookForm : Form
    {
        private readonly BookService _bookService;
        private readonly UserRole userRole;

        public BookForm(BookService bookService, UserRole userRole)
        {
            InitializeComponent();
            _bookService = bookService;
            this.userRole = userRole;

        }

        private async void BookForm_Load(object sender, EventArgs e)
        {
            var books = await _bookService.GetAllBooks();
            dataGridViewBooks.Rows.Clear();
            // Add each book's details to the DataGridView
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
            // Restrict access for SalesClerk role
            if (userRole == UserRole.SalesClerk)
            {
                btnAddBook.Enabled = false;
                btnUpdate.Enabled = false;
                dataGridViewBooks.Columns["colDelete"].Visible = false;
            }
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  
            {
                var selectedRow = dataGridViewBooks.Rows[e.RowIndex];

                // If the delete button is clicked, delete the book

                if (e.ColumnIndex == dataGridViewBooks.Columns["colDelete"].Index)
                {
                    var title = selectedRow.Cells["colTitle"].Value.ToString();
                    DeleteBook(title);
                }
                else
                {
                    // Populate text fields with selected book details
                    txtId.Text = selectedRow.Cells["colId"].Value.ToString();
                    txtTitle.Text = selectedRow.Cells["colTitle"].Value.ToString();
                    txtAuthor.Text = selectedRow.Cells["colAuthor"].Value.ToString();
                    txtGenre.Text = selectedRow.Cells["colGenre"].Value.ToString();
                    txtISBN.Text = selectedRow.Cells["colISBN"].Value.ToString();
                    txtPrice.Text = selectedRow.Cells["colPrice"].Value.ToString();
                    txtQuantity.Text = selectedRow.Cells["colQuantity"].Value.ToString();
                }
            }
        }


        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var newBook = new Book
            {
                Id = Guid.NewGuid(),
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Genre = txtGenre.Text,
                ISBN = txtISBN.Text,
                Price = decimal.TryParse(txtPrice.Text, out var price) ? price : 0,
                Quantity = int.TryParse(txtQuantity.Text, out var quantity) ? quantity : 0,
                SupplierId = null 
            };

            try
            {
                await _bookService.AddBook(newBook);

                // Refresh book list after adding a new book
                BookForm_Load(sender, e);

                MessageBox.Show("The book has been successfully added.");
                clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}");
            }
        }

        private async void DeleteBook(string title)
        {
            var books = await _bookService.GetAllBooks();
            var bookToDelete = books.FirstOrDefault(b => b.Title == title);

            if (bookToDelete != null)
            {
                try
                {
                    await _bookService.DeleteBook(bookToDelete.Id);

                    // Refresh book list after deletion
                    BookForm_Load(this, EventArgs.Empty);

                    MessageBox.Show("The book has been deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting book: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("The book could not be found.");
            }
        }

        // UI Components
        private Label lblId;
        private Label lblTitle;
        private Label Author;
        private Label lblAuthor;
        private Label lblGenre;
        private Label lblISBN;
        private Label lblPrice;
        private Label lblQty;
        private Button btnUpdate;
        private TextBox txtId;
        private Button btnBack;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colISBN;
        private DataGridViewTextBoxColumn colGenre;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewButtonColumn colDelete;
    }
}