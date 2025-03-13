using BookHaven.Models.Services;
using System;
using System.Linq;
using System.Windows.Forms;


namespace BookHeaven.Views
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierService supplierService;
        private readonly BookService bookService;

        public SupplierForm(SupplierService supplierService, BookService bookService)
        {
            InitializeComponent();
            this.supplierService = supplierService;
            this.bookService = bookService;
        }

        private Label lblId;
        private Label lblTitle;
        private Label Author;
        private Label lblAuthor;
        private Label lblConatct;
        private Label lblISBN;
        private Label lblPrice;
        private Label lblQty;
        private Button btnUpdateBooks;
        private TextBox txtId;
        private Label lblName;
        private Button btnAddBooks;
        private DataGridView dataGridViewBooks;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private Label lblBooks;
        private ComboBox cmbBooks;
        private Button btnBack;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewButtonColumn colBooks;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewTextBoxColumn bookId;
        private DataGridViewTextBoxColumn bookTitle;
        private DataGridViewTextBoxColumn bookAuthor;
        private DataGridViewTextBoxColumn bookGenre;
        private DataGridViewTextBoxColumn bookISBN;
        private DataGridViewTextBoxColumn bookPrice;
        private DataGridViewTextBoxColumn bookQuantity;
    }
}